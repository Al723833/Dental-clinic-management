using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class Teeth
    {
        public int Teeth_id { get; set; }
        public String Teeth_name { get; set; }

        public Teeth(int Teeth_id, String Teeth_name)
        {
            this.Teeth_id = Teeth_id;
            this.Teeth_name = Teeth_name;
        }
    }
}
