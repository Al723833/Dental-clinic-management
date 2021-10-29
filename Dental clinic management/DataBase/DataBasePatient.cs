using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBasePatient
    {


        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        Patient patient;

        public Patient getPatientById(int id)
        {
            try
            {
                // create and open a connection object			
                con.Open();
                // 1. create a command object identifying
                // the stored procedure
                cmd = new SqlCommand(
                   "GetPatientDataById", con);
                // 2. set the command object so it knows
                // to execute a stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
              
                cmd.Parameters.Add(
                   new SqlParameter("@id", id));

                dr = cmd.ExecuteReader();
                // iterate through results, printing each to console
                while (dr.Read())
                {
                    patient = new Patient(Convert.ToInt32(dr["id"].ToString()),
                        dr["First_Name"].ToString(),
                        dr["middle_name"].ToString(),
                        dr["last_name"].ToString(),
                        dr["day_data"].ToString(),
                        dr["note_sick"].ToString(),
                        0.0,
                        0.0,
                        0.0,
                        0,
                        dr["date_of_birth"].ToString(),
                        dr["mobile_number"].ToString(),
                        dr["mobile_number_Spare"].ToString(),
                        dr["Patient_Address"].ToString(),
                        dr["chronic_diseases"].ToString(),
                        dr["Polarization_method"].ToString()
                        );
                    
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
            return patient;
        }

        public Patient PatientSearch(String search_word,String searchType)
        {
            try
            {
                // create and open a connection object			
                con.Open();
                // 1. create a command object identifying
                // the stored procedure
                cmd = new SqlCommand(
                   "PatientSearch", con);
                // 2. set the command object so it knows
                // to execute a stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(
                   new SqlParameter("@search_word", search_word));
                cmd.Parameters.Add(
                   new SqlParameter("@searchType", searchType));

                dr = cmd.ExecuteReader();
                // iterate through results, printing each to console
                while (dr.Read())
                {
                    patient = new Patient(Convert.ToInt32(dr["id"].ToString()),
                        dr["First_Name"].ToString(),
                        dr["middle_name"].ToString(),
                        dr["last_name"].ToString(),
                        dr["day_data"].ToString(),
                        dr["note_sick"].ToString(),
                        0.0,
                        0.0,
                        0.0,
                        0,
                        dr["date_of_birth"].ToString(),
                        dr["mobile_number"].ToString(),
                        dr["mobile_number_Spare"].ToString(),
                        dr["Patient_Address"].ToString(),
                        dr["chronic_diseases"].ToString(),
                        dr["Polarization_method"].ToString()
                        );

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
            return patient;
        }

        // run a stored procedure that takes a parameter
        public List<Patient> PatientCURD(int id,
                String First_Name,
                String middle_name,
                String last_name,
                String day_data,
                String note_sick,
                double sum_value,
                double value_dofaa,
                double value_Discount,
                int sub_Patient_id,
                String date_of_birth,
                String mobile_number,
                String mobile_number_Spare,
                String Patient_Address,
                String chronic_diseases,
                String Polarization_method,
            string StatementType)
        {
            //082461286
            List<Patient> PatientList = new List<Patient>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                   "PatientCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@id", id));
                cmd.Parameters.Add(
                   new SqlParameter("@First_Name", First_Name));
                cmd.Parameters.Add(
                   new SqlParameter("@middle_name", middle_name));
                cmd.Parameters.Add(
                   new SqlParameter("@last_name", last_name));
                cmd.Parameters.Add(
                new SqlParameter("@note_sick", note_sick));
                cmd.Parameters.Add(
               new SqlParameter("@sum_value", sum_value));
                cmd.Parameters.Add(
               new SqlParameter("@value_dofaa", value_dofaa));
                cmd.Parameters.Add(
               new SqlParameter("@value_Discount", value_Discount));
                cmd.Parameters.Add(
               new SqlParameter("@sub_Patient_id", sub_Patient_id));
                cmd.Parameters.Add(
               new SqlParameter("@date_of_birth", date_of_birth));
                cmd.Parameters.Add(
               new SqlParameter("@mobile_number", mobile_number));
                cmd.Parameters.Add(
               new SqlParameter("@mobile_number_Spare", mobile_number_Spare));
                cmd.Parameters.Add(
               new SqlParameter("@Patient_Address", Patient_Address));
                cmd.Parameters.Add(
               new SqlParameter("@chronic_diseases", chronic_diseases));
                cmd.Parameters.Add(
               new SqlParameter("@Polarization_method", Polarization_method));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Patient adm = new Patient(Convert.ToInt32(dr["id"].ToString()),
                        dr["First_Name"].ToString(),
                        dr["middle_name"].ToString(),
                        dr["last_name"].ToString(),
                        dr["day_data"].ToString(),
                        dr["note_sick"].ToString(),
                        0.0,
                        0.0,
                        0.0,
                        0,
                        dr["date_of_birth"].ToString(),
                        dr["mobile_number"].ToString(),
                        dr["mobile_number_Spare"].ToString(),
                        dr["Patient_Address"].ToString(),
                        dr["chronic_diseases"].ToString(),
                        dr["Polarization_method"].ToString()
                        );
                    PatientList.Add(adm);
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
            return PatientList;
        }

    }
}
