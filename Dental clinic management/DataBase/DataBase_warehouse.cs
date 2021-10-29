using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBase_warehouse
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;


        public List<warehouse> WarehouseCRUD(int warehouse_id,
            String warehouse_name,
            String mobile_number,
            String warehouse_address,
            string StatementType)
        {
            List<warehouse> warehouseList = new List<warehouse>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "WarehouseCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@warehouse_id", warehouse_id));
                cmd.Parameters.Add(
                    new SqlParameter("@warehouse_name", warehouse_name));
                cmd.Parameters.Add(
                new SqlParameter("@mobile_number", mobile_number));
                cmd.Parameters.Add(
               new SqlParameter("@warehouse_address", warehouse_address));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    warehouse warehouse = new warehouse(Convert.ToInt32(dr["warehouse_id"].ToString()),
                        dr["warehouse_name"].ToString(),
                        dr["mobile_number"].ToString(),
                        dr["warehouse_address"].ToString()
                        );
                    warehouseList.Add(warehouse);
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
            return warehouseList;
        }

    }
}
