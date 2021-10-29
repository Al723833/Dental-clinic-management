using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class Admin
    {
        public String admin_name { get; private set; }
        public String admin_pass { get; private set; }
        public String permission { get; private set; }


        public Admin(String admin_name, String admin_pass, String permission)
        {
            this.admin_name = admin_name;
            this.admin_pass = admin_pass;
            this.permission = permission;
        }

    }
}
