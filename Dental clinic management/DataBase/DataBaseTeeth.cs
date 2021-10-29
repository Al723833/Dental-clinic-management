using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Dental_clinic_management
{
    class DataBaseTeeth
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<Teeth> TeethCRUD(int Teeth_id, String Teeth_name, string StatementType)
        {
            List<Teeth> TeethList = new List<Teeth>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "TeethCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@Teeth_id", Teeth_id));
                cmd.Parameters.Add(
                    new SqlParameter("@Teeth_name", Teeth_name));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Teeth teeth = new Teeth(Convert.ToInt32(dr["Teeth_id"].ToString()), dr["Teeth_name"].ToString());
                    TeethList.Add(teeth);
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
            return TeethList;
        }
    }
}
