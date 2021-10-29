using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBase_operations_tooth
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;


        public List<operations_tooth> operations_tooth_CRUD(int operations_tooth_id,
            int session_id,
            int Teeth_id,
            int Operations_id,
            int number_pieces,
            double price,
          string StatementType)
        {
            List<operations_tooth> operations_tooth_List = new List<operations_tooth>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "operations_tooth_CRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@operations_tooth", operations_tooth_id));
                cmd.Parameters.Add(
                    new SqlParameter("@session_id", session_id));
                cmd.Parameters.Add(
                new SqlParameter("@Teeth_id", Teeth_id));
                cmd.Parameters.Add(
               new SqlParameter("@Operations_id", Operations_id));
                cmd.Parameters.Add(
               new SqlParameter("@number_pieces", number_pieces));
                cmd.Parameters.Add(
               new SqlParameter("@price", price));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    operations_tooth operations_Tooth = new operations_tooth(Convert.ToInt32(dr["operations_tooth"].ToString()),
                        Convert.ToInt32(dr["session_id"].ToString()),
                        Convert.ToInt32(dr["Teeth_id"].ToString()),
                        Convert.ToInt32(dr["Operations_id"].ToString()),
                        Convert.ToInt32(dr["number_pieces"].ToString()),
                        Convert.ToDouble(dr["price"].ToString())
                        );
                    operations_tooth_List.Add(operations_Tooth);
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
            return operations_tooth_List;
        }
    }
}
