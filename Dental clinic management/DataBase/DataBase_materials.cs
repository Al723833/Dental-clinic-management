using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBase_materials
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<materials> materials_CRUD(int material_id,
            String material_name,
            String date_of_purchase,
            int Quantity,
            double total_price,
            string StatementType)
        {
            List<materials> materialsList = new List<materials>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "materials_CRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@material_id", material_id));
                cmd.Parameters.Add(
                    new SqlParameter("@material_name", material_name));
                cmd.Parameters.Add(
                new SqlParameter("@date_of_purchase", date_of_purchase));
                cmd.Parameters.Add(
               new SqlParameter("@Quantity", Quantity));
                cmd.Parameters.Add(
               new SqlParameter("@total_price", total_price));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    materials materials = new materials(Convert.ToInt32(dr["material_id"].ToString()),
                        dr["material_name"].ToString(),
                        dr["date_of_purchase"].ToString(),
                        Convert.ToInt32(dr["Quantity"].ToString()),
                        Convert.ToDouble(dr["total_price"].ToString())
                        );
                    materialsList.Add(materials);
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (dr != null)
                {
                    dr.Close();
                }
            }
            return materialsList;
        }
    }
}
