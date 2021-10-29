using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class warehouse
    {
        public int warehouse_id { get; set; }
        public String warehouse_name { get; set; }
        public String mobile_number { get; set; }
        public String warehouse_address { get; set; }

        public warehouse(int warehouse_id, String warehouse_name, String mobile_number, String warehouse_address)
        {
            this.warehouse_id = warehouse_id;
            this.warehouse_name = warehouse_name;
            this.mobile_number = mobile_number;
            this.warehouse_address = warehouse_address;

        }
    }
}
