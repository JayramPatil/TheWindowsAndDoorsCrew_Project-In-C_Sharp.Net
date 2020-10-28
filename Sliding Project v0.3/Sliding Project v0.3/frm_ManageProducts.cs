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
    public partial class frm_ManageProducts : Form
    {
        public frm_ManageProducts()
        {
            InitializeComponent();
        }
        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddProduct(1));
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Delete This Product ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Change This Products Availability ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
