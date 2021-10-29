using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBasePeriod
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<Period> PeriodCRUD(int Period_id, String Period_name, String start_time, String end_time, string StatementType)
        {
            List<Period> PeriodList = new List<Period>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "PeriodCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@Period_id", Period_id));
                cmd.Parameters.Add(
                    new SqlParameter("@Period_name", Period_name));
                cmd.Parameters.Add(
                new SqlParameter("@start_time", start_time));
                cmd.Parameters.Add(
               new SqlParameter("@end_time", end_time));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Period period = new Period(Convert.ToInt32(dr["Period_id"].ToString()),
                        dr["Period_name"].ToString(),
                        dr["start_time"].ToString(),
                        dr["end_time"].ToString()
                        );
                    PeriodList.Add(period);
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
            return PeriodList;
        }

    }
}
