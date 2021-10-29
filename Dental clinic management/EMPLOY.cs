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
    public partial class EMPLOY : Form
    {
        public EMPLOY()
        {
            InitializeComponent();
        }

        private void EMPLOY_Load(object sender, EventArgs e)
        {
            load_Data();
        }


        public void load_Data()
        {
            guna2DataGridView1.Controls.Clear();

            int i = 0;
            List<Employee> listPatie = new DataBaseEmployee().EmployeeCURD(1, "", "", "","",0, "Select");
            countEmplyee.Text = listPatie.Count.ToString();
            Employees_element[] lis = new Employees_element[listPatie.Count];

            foreach (Employee element in listPatie)
            {
                lis[i] = new Employees_element();
                lis[i].ID_ = element.EmployeeID.ToString();
                lis[i].FirstName_ = element.FirstName;
                lis[i].LastName_ = element.LastName;
                lis[i].mobileNember_ = element.mobileNumber;
                lis[i].address_ = element.EmployeeAddress;
                lis[i].Salary_ = element.Salary.ToString();
                guna2DataGridView1.Controls.Add(lis[i]);
            }

        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
