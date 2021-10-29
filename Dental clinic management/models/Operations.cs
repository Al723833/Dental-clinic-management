using System;

namespace Dental_clinic_management
{
    class Operations
    {
        public int Operations_id { get; set; }
        public String Operations_name { get; set; }

        public Operations(int Operations_id, String Operations_name)
        {
            this.Operations_id = Operations_id;
            this.Operations_name = Operations_name;
        }
    }
}
