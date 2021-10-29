using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBase_session
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;



        public List<session> sessionCRUD(int session_id,
        String start_time,
        String end_time,
        String x_ray_image,
        double Payment_amount,
        double discount_value,
        double price,
        int Patient_id,
        int Doctor_id,
        int room_id,
        int Period_id,
        int Medicine_id,
        String Notes,
    string StatementType)
        {
            List<session> sessionList = new List<session>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                   "sessionCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@session_id", session_id));
                cmd.Parameters.Add(
                   new SqlParameter("@start_time", start_time));
                cmd.Parameters.Add(
                new SqlParameter("@end_time", end_time));
                cmd.Parameters.Add(
               new SqlParameter("@x_ray_image", x_ray_image));
                cmd.Parameters.Add(
               new SqlParameter("@Payment_amount", Payment_amount));
                cmd.Parameters.Add(
               new SqlParameter("@discount_value", discount_value));
                cmd.Parameters.Add(
               new SqlParameter("@price", price));
                cmd.Parameters.Add(
               new SqlParameter("@Patient_id", Patient_id));
                cmd.Parameters.Add(
               new SqlParameter("@Doctor_id", Doctor_id));
                cmd.Parameters.Add(
               new SqlParameter("@room_id", room_id));
                cmd.Parameters.Add(
               new SqlParameter("@Period_id", Period_id));
                cmd.Parameters.Add(
               new SqlParameter("@Medicine_id", Medicine_id));
                cmd.Parameters.Add(
               new SqlParameter("@Notes", Notes));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //
                    //تعديل على البروسيجر ما ترع الايدي ترجع الاسم
                    //اقرا سترينق وخزن رقم
                    //المديول يكون سترينق والبرانيتر يمون انتيجر
                    session session = new session(Convert.ToInt32(dr["session_id"].ToString()),
                        dr["start_time"].ToString(),
                        dr["end_time"].ToString(),
                        dr["x_ray_image"].ToString(),
                        Convert.ToDouble(dr["Payment_amount"].ToString()),
                        Convert.ToDouble(dr["discount_value"].ToString()),
                        Convert.ToDouble(dr["price"].ToString()),
                        dr["Patient_id"].ToString(),
                        dr["Doctor_id"].ToString(),
                        dr["room_id"].ToString(),
                        dr["Period_id"].ToString(),
                        dr["Medicine_id"].ToString(),
                        dr["Notes"].ToString()
                        );
                    sessionList.Add(session);
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
            return sessionList;
        }
    }
}
