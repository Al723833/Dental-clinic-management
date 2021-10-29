using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_clinic_management
{
    public partial class AddNewPatient : Form
    {

        public AddNewPatient(Patient_view frm)
        {
            this.addpationt1 = new Dental_clinic_management.addpationt(frm);
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }
    }
}
