using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dental_clinic_management
{
    public partial class Editpationt : UserControl
    {
        int indexss;
        private readonly Patient_view frm1; //readonly is optional (For safety purposes)

        public Editpationt(Patient_view frm, int indexss)
        {
            InitializeComponent();
            this.indexss = indexss;
            frm1 = frm;
            Patient patient = new DataBasePatient().getPatientById(indexss);


            patineName.Text = patient.First_Name;
            medName.Text = patient.middle_name;
            lastName.Text = patient.last_name;

            pohneNumber.Text = patient.mobile_number;
            DateOfBart.Text = patient.date_of_birth;
            Address.Text = patient.Patient_Address;
            polarization_path.Text = patient.Polarization_method;
            chronic_diseases.Text = patient.chronic_diseases;
            //edit form id to name //
            //create prosegar to return name from id
            Appendix.Text = patient.sub_Patient_id.ToString();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    List<Patient> list = new DataBasePatient().PatientCURD(indexss,
                        patine_Name ,
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
                        "Update"
                          );
                    frm1.load_Data();
                    this.Hide();

                }
                catch
                {
                    MessageBox.Show("فشل تحديث بيانات المريض ");
                }
            }
            else
            {
                MessageBox.Show("الرجاء ادخال البيانات الاساسية للمريض");
            }
        }
    }
}
