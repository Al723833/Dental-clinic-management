using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBaseEmployee
    {


        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;


        public List<Employee> EmployeeCURD(int EmployeeID,
            String FirstName,
            String LastName,
            String mobileNumber,
            String EmployeeAddress,
            double Salary,
            string StatementType)
        {
            List<Employee> EmployeeList = new List<Employee>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "EmployeeCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@EmployeeID", EmployeeID));
                cmd.Parameters.Add(
                    new SqlParameter("@FirstName", FirstName));
                cmd.Parameters.Add(
                new SqlParameter("@LastName", LastName));
                cmd.Parameters.Add(
               new SqlParameter("@mobileNumber", mobileNumber)); 
                cmd.Parameters.Add(
               new SqlParameter("@EmployeeAddress", EmployeeAddress));
                cmd.Parameters.Add(
               new SqlParameter("@Salary", Salary));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee employee = new Employee(Convert.ToInt32(dr["EmployeeID"].ToString()),
                        dr["FirstName"].ToString(),
                        dr["LastName"].ToString(),
                        dr["mobileNumber"].ToString(),
                        dr["EmployeeAddress"].ToString(),
                        Convert.ToDouble(dr["Salary"].ToString())
                        );
                    EmployeeList.Add(employee);
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
            return EmployeeList;
        }
    }
}
