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
    public partial class EditPatient : Form
    {
        public EditPatient(Patient_view frm, int indexss)
        {
            this.editpationt1 = new Dental_clinic_management.Editpationt(frm, indexss);
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }
    }
}
