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
    public partial class add_User : Form
    {
        public add_User()
        {
            InitializeComponent();

            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
