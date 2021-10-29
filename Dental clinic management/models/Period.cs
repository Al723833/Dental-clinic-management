using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class Period
    {
        public int Period_id { get; set; }
        public String Period_name { get; private set; }
        public String start_time { get; private set; }
        public String end_time { get; private set; }


        public Period(int Period_id, String Period_name, String start_time, String end_time)
        {
            this.Period_id = Period_id;
            this.Period_name = Period_name;
            this.start_time = start_time;
            this.end_time = end_time;

        }
    }
}
