﻿using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Overview";
          //  guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Dashboard Overview";
          //  guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            //guna2PictureBox_val.Image = Properties.Resources.person__1_;
            //container(new Patient());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label_val.Text = "Messages";
            //guna2PictureBox_val.Image = Properties.Resources.chat__1_;
            //container(new Messages());
        }

        private void guna2Panel_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
         //   guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new Patient_view());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            //guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new EMPLOY());
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            //guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new mostod3());
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            //guna2PictureBox_val.Image = Properties.Resources.person__1_;
            //container(new M3AMEL());

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            //guna2PictureBox_val.Image = Properties.Resources.person__1_;
            //container(new MSROFA());
        }
    }
}
