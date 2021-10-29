using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class Medicine
    {
        public int Medicine_id { get; set; }
        public String Medicine_name { get; set; }

        public Medicine(int Medicine_id, String Medicine_name)
        {
            this.Medicine_id = Medicine_id;
            this.Medicine_name = Medicine_name;

        }
    }
}
