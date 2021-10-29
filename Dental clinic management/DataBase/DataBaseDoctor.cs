using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBaseDoctor
    {

        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<Doctor> DoctorCRUD(int Doctor_id, String Doctor_name, string StatementType)
        {
            List<Doctor> DoctorList = new List<Doctor>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "DoctorCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@Doctor_id", Doctor_id));
                cmd.Parameters.Add(
                    new SqlParameter("@Doctor_name", Doctor_name));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Doctor doctor = new Doctor(Convert.ToInt32(dr["Doctor_id"].ToString()), dr["Doctor_name"].ToString());
                    DoctorList.Add(doctor);
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
            return DoctorList;
        }
    }
}
