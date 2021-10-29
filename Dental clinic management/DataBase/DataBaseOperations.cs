using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Dental_clinic_management
{
    class DataBaseOperations
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<Operations> OperationsCRUD(int Operations_id, String Operations_name, string StatementType)
        {
            List<Operations> OperationsList = new List<Operations>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "OperationsCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@Operations_id", Operations_id));
                cmd.Parameters.Add(
                    new SqlParameter("@Operations_name", Operations_name));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Operations operations = new Operations(Convert.ToInt32(dr["Operations_id"].ToString()), dr["Operations_name"].ToString());
                    OperationsList.Add(operations);
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
            return OperationsList;
        }
    }
}
