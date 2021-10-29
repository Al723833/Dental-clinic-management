using System;

namespace Dental_clinic_management
{
    class room
    {
        public int room_id { get; private set; }
        public String room_name { get; private set; }
        public String roo_status { get; private set; }


        public room(int room_id, String room_name, String roo_status)
        {
            this.room_id = room_id;
            this.room_name = room_name;
            this.roo_status = roo_status;
        }
    }
}
