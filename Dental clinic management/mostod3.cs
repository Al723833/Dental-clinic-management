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
    public partial class mostod3 : Form
    {
        public mostod3()
        {
            InitializeComponent();
        }

        private void mostod3_Load(object sender, EventArgs e)
        {
            load_Data();
        }
        public void load_Data()
        {
            guna2DataGridView1.Controls.Clear();

            int i = 0;
            List<warehouse> listPatie = new DataBase_warehouse().WarehouseCRUD(1, "", "", "", "Select");
            count_mostod3.Text = listPatie.Count.ToString();
            mostod3at_element[] lis = new mostod3at_element[listPatie.Count];

            foreach (warehouse element in listPatie)
            {
                lis[i] = new mostod3at_element();
                lis[i].ID_ = element.warehouse_id.ToString();
                lis[i].Name_ = element.warehouse_name;
                lis[i].mobileNember_ = element.mobile_number;
                lis[i].address_ = element.warehouse_address;
                guna2DataGridView1.Controls.Add(lis[i]);
            }

        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
