using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
namespace Dental_clinic_management
{
    public partial class mostod3at_element : UserControl
    {
        public mostod3at_element()
        {
            InitializeComponent();
        }
        private string _name_;
        public string Name_
        {
            get { return _name_; }
            set { _name_ = value; name.Text = value; }
        }

        private string _id_;
        public string ID_
        {
            get { return _id_; }
            set { _id_ = value; ID_PATIENT.Text = value; }
        }

       private string _mobileNember_;
        public string mobileNember_
        {
            get { return _mobileNember_; }
            set { _mobileNember_ = value; mobileNember.Text = value; }
        }

                private string _address_;
        public string address_
        {
            get { return _address_; }
            set { _address_ = value; address.Text = value; }
        }

   
        private void rowpationt_Load(object sender, EventArgs e)
        {

        }

        private void rowpationt_MouseHover(object sender, EventArgs e)
        {
           BackColor = Color.CornflowerBlue;
        }

        private void rowpationt_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void guna2CirclePictureBox8_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void guna2CirclePictureBox8_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;

        }

        private void name_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void nomberjwaaala_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void name_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;

        }

        private void nomberjwaaala_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;

        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;

        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
          String id =  this.ID_PATIENT.Text;
          MessageBox.Show(id);

            //EditNewPatine Add_Patinet = new EditNewPatine();
            //Add_Patinet.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            String id = this.ID_PATIENT.Text;
            int indexss = Convert.ToInt32(id);
            MessageBox.Show(id);

            DialogResult dr = MessageBox.Show("هل تريد بالفعل حذف ملف المريض " , "! تنبيه", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                List<Patient> list = new DataBasePatient().PatientCURD(indexss,"","","", "", "", 0.0, 0.0, 0.0, 0, "", "", "", "", "", "", "Delete");
                MessageBox.Show("تم حذف البيانات بنجاح");
            }
        }
    }
}
