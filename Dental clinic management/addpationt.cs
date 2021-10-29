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
    public partial class addpationt : UserControl
    {

        private readonly Patient_view frm1;
        public addpationt(Patient_view frm)
        {
            InitializeComponent();
            frm1 = frm ;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            String patine_Name = patineName.Text;
            String med_Name = medName.Text;
            String last_Name = lastName.Text;
            String DateOf_Bart = DateOfBart.Text;
            String phone = pohneNumber.Text;
            String note = Note.Text;

            if (patine_Name.Length != 0 &&
                med_Name.Length != 0 &&
                last_Name.Length != 0 &&
                DateOf_Bart != "" &&
                phone.Length != 0
                )
            {
                try
                {
                    List<Patient> list = new DataBasePatient().PatientCURD(0,
                        patine_Name,
                        med_Name ,
                        last_Name,
                        "",
                        note,
                        0.0,
                        0.0,
                        0.0,
                        0,
                        DateOf_Bart,
                        phone,
                        phone,
                        Address.Text,
                        chronic_diseases.Text,
                        polarization_path.Text,
                        "Insert"
                          );

                    frm1.load_Data();
                    Form.ActiveForm.Close();

                }
                catch
                {
                    MessageBox.Show("فشل اضافة المريض ");

                }
            }
            else
            {
                MessageBox.Show("الرجاء ادخال البيانات الاساسية للمريض");
            }
        }
    }
}
