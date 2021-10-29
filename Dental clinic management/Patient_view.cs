using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Dental_clinic_management
{
    public partial class Patient_view : Form
    {
        //   List<tbel_pationt> m_students = new List<tbel_pationt>();

        public Patient_view()
        {
            InitializeComponent();
            //  Patient(tbel_pationt);
            //  tabel_desghine();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            load_Data();
        }




        public void load_Data()
        {
            flowLayoutPanel1.Controls.Clear();

            int i = 0;
            List<Patient> listPatie = new DataBasePatient().PatientCURD(1,"","", "", "", "", 0.0, 0.0, 0.0, 0, "", "", "", "", "", "", "Select");
            count_patient.Text = listPatie.Count.ToString();
            patient_element[] lis = new patient_element[listPatie.Count];

            foreach (Patient element in listPatie)
            {
                lis[i] = new patient_element(this);
                lis[i].ID_ = element.id.ToString();
                lis[i].Name_ = element.First_Name +" "+element.middle_name + " " + element.last_name;
                lis[i].Last_visit = "";
                lis[i].mobileNember_ = element.mobile_number;
                lis[i].address_ = element.Patient_Address;
                lis[i].total_price_ = element.sum_value.ToString();
                lis[i].Total_Payments_ = element.value_dofaa.ToString();
                lis[i].Total_discount_ = element.value_Discount.ToString();
                flowLayoutPanel1.Controls.Add(lis[i]);
            }

        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AddNewPatient Add_Patinet = new AddNewPatient(this);
            Add_Patinet.Show();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int filterSelect = filter.SelectedIndex + 1;
                    Patient patient = new DataBasePatient().PatientSearch(guna2TextBox1.Text, filterSelect.ToString());
                    flowLayoutPanel1.Controls.Clear();
                    patient_element pat = new patient_element(this);
                    if(pat != null)
                    {
                        pat.ID_ = patient.id.ToString();
                        pat.Name_ = patient.First_Name + " " + patient.middle_name + " " + patient.last_name;
                        pat.Last_visit = "";
                        pat.mobileNember_ = patient.mobile_number;
                        pat.address_ = patient.Patient_Address;
                        pat.total_price_ = patient.sum_value.ToString();
                        pat.Total_Payments_ = patient.value_dofaa.ToString();
                        pat.Total_discount_ = patient.value_Discount.ToString();
                        flowLayoutPanel1.Controls.Add(pat);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("لا يوجد بيانات");
                }
            
            }
        }
    }
}
