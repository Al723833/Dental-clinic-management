using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBaseMedicine
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<Medicine> MedicineCRUD(int Medicine_id, String Medicine_name, string StatementType)
        {
            List<Medicine> MedicineList = new List<Medicine>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "MedicineCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@Medicine_id", Medicine_id));
                cmd.Parameters.Add(
                    new SqlParameter("@Medicine_name", Medicine_name));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Medicine medicine = new Medicine(Convert.ToInt32(dr["Medicine_id"].ToString()), dr["Medicine_name"].ToString());
                    MedicineList.Add(medicine);
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
            return MedicineList;
        }
    }
}
