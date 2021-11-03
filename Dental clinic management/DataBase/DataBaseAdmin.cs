using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBaseAdmin
    {


        public static string url_data_servar = "Data Source=B-0081\\SQLEXPRESS;Initial Catalog=Dental Clinic;Integrated Security=True";

        SqlConnection con = new SqlConnection(@url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;






        //get all user acount




        //public List<Admin> getAdmins()
        //{
        //    List<Admin> AdminList = new List<Admin>();
        //    try
        //    {
        //        // create and open a connection object			
        //        con.Open();
        //        // 1. create a command object identifying
        //        // the stored procedure
        //        cmd = new SqlCommand(
        //           "getAllAdmins", con);
        //        // 2. set the command object so it knows
        //        // to execute a stored procedure
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        // execute the command
        //        dr = cmd.ExecuteReader();
        //        // iterate through results, printing each to console
        //        while (dr.Read())
        //        {
        //            Admin adm = new Admin(dr["admin_name"].ToString(), dr["admin_pass"].ToString(), dr["permission"].ToString());
        //            AdminList.Add(adm);
        //        }
        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //        if (dr != null)
        //        {
        //            dr.Close();
        //        }
        //    }
        //    return AdminList;
        //}















        // run a stored procedure that takes a parameter
        public List<Admin> AdminCURD(int admin_id, string admin_name, string admin_pass ,string permission,string StatementType)
        {
            List<Admin> AdminList = new List<Admin>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "AdminCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@admin_id", admin_id));
                cmd.Parameters.Add(
                    new SqlParameter("@admin_name", admin_name));
                cmd.Parameters.Add(
                new SqlParameter("@admin_pass", admin_pass));
                 cmd.Parameters.Add(
                new SqlParameter("@permission", permission));
                 cmd.Parameters.Add(
                new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Admin adm = new Admin(dr["admin_name"].ToString(), dr["admin_pass"].ToString(), dr["permission"].ToString());
                    AdminList.Add(adm);
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
            return AdminList;
        }


        //add user to data baes in Admins tauble


        //cmd = new SqlCommand("select * from Admins ", con);
        //con.Open();
        //dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{
        //    Admin adm = new Admin(dr["admin_name"].ToString(), dr["admin_pass"].ToString(), dr["permission"].ToString());
        //    AdminList.Add(adm);
        //}
        //dr.Close();
        //con.Close();
    }


}