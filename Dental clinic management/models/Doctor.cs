using System;

namespace Dental_clinic_management
{
    class Doctor
    {
        public int Doctor_id { get; set; }
        public String Doctor_name { get; set; }

        public Doctor(int Doctor_id, String Doctor_name)
        {
            this.Doctor_id = Doctor_id;
            this.Doctor_name = Doctor_name;
        }
    }
}
