using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBase_warehouse_invoice
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<warehouse_invoice> warehouse_invoice_CRUD(int warehouse_invoice_id,
            int warehouse_id,
            int invoice_number,
            int Quantity,
            double price,
            double Amount_paid,
            String Notes,
            int material_id,
            string StatementType)
        {
            List<warehouse_invoice> warehouse_invoice_List = new List<warehouse_invoice>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                   "warehouse_invoice_CRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@warehouse_invoice_id", warehouse_invoice_id));
                cmd.Parameters.Add(
                   new SqlParameter("@warehouse_id", warehouse_id));
                cmd.Parameters.Add(
                new SqlParameter("@invoice_number", invoice_number));
                cmd.Parameters.Add(
               new SqlParameter("@Quantity", Quantity));
                cmd.Parameters.Add(
               new SqlParameter("@price", price));
                cmd.Parameters.Add(
               new SqlParameter("@Amount_paid", Amount_paid));
                cmd.Parameters.Add(
               new SqlParameter("@Notes", Notes));
                cmd.Parameters.Add(
               new SqlParameter("@material_id", material_id));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    warehouse_invoice warehouse_Invoice = new warehouse_invoice(Convert.ToInt32(dr["warehouse_invoice_id"].ToString()),
                        Convert.ToInt32(dr["warehouse_id"].ToString()),
                        Convert.ToInt32(dr["invoice_number"].ToString()),
                        Convert.ToInt32(dr["Quantity"].ToString()),
                        Convert.ToDouble(dr["price"].ToString()),
                        Convert.ToDouble(dr["Amount_paid"].ToString()),
                        dr["Notes"].ToString(),
                        Convert.ToInt32(dr["material_id"].ToString())
                        );
                    warehouse_invoice_List.Add(warehouse_Invoice);
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
            return warehouse_invoice_List;
        }
    }
}
