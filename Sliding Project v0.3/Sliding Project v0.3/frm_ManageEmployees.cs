﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding_Project_v0._3
{
    public partial class frm_ManageEmployees : Form
    {
        public frm_ManageEmployees()
        {
            InitializeComponent();
        }

        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddEmployee());
        }

        private void btn_UpdateEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddEmployee(1));
        }

        private void btn_RemoveEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Remove This Employee ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
