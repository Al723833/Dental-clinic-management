using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBase_room
    {
        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;



        public List<room> roomCURD(int room_id, String room_name, String roo_status, string StatementType)
        {
            List<room> roomList = new List<room>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "roomCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@room_id", room_id));
                cmd.Parameters.Add(
                    new SqlParameter("@room_name", room_name));
                cmd.Parameters.Add(
                new SqlParameter("@roo_status", roo_status));
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    room room = new room(Convert.ToInt32(dr["room_id"].ToString()), dr["room_name"].ToString(), dr["roo_status"].ToString());
                    roomList.Add(room);
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
            return roomList;
        }
    }
}
