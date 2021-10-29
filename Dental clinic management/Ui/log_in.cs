using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Dental_clinic_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserName.Focus();
            List<session> sessionnList = new DataBase_session().sessionCRUD(1, "", "", "", 0, 0, 0, 1026, 1, 1, 1, 1, "", "Select");
            MessageBox.Show(""+sessionnList[1].Patient_id);
        }



     
        private void UserName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PassWord.Focus();
        }

        private void PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.Focus();
                login.PerformClick();
            }

            if (e.KeyCode == Keys.Back && PassWord.TextLength ==0)
                UserName.Focus();
        }

        private void login_Click(object sender, EventArgs e)
        {
          
            List<Admin> AdminList = new DataBaseAdmin().AdminCURD(1,"","","", "Select");

            if (UserName.Text != "" && PassWord.Text != "")
            {
                //foreach (Admin element in AdminList)
                //{

                    //if (UserName.Text.Equals(element.admin_name) && PassWord.Text.Equals(element.admin_pass))
                    //{
                        //MessageBox.Show("" + element.admin_name + " اهلا بك " + element.admin_pass);

                        //Home home_form = new Home();
                        //home_form.Show();
                        //this.Hide();

                        //return;
                    //}
                //}
                //MessageBox.Show("البيانات المدخلة خاطئة");
            }
            else
            {
                MessageBox.Show("خطا في الاخال البيانات الرجاء ادخال اسم المستخدم وكلمة المرور");
            }

            UserName.Text = "";
            PassWord.Text = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
