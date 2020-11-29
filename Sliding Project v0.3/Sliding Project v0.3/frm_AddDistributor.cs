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
    public partial class frm_AddDistributor : Form
    {
        public frm_AddDistributor()
        {
            InitializeComponent();
        }
        public frm_AddDistributor(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Distributor Details";
            btn_Search.Visible = true;
            btn_Add.Text = "Update";
        }

        private void frm_AddDistributor_Load(object sender, EventArgs e)
        {
            using (CrewEntities DB = new CrewEntities())
            {
                var Material = (from m in DB.Material_Info where m.Group_ID == 1 || m.Group_ID == 2 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    clb_Window.Items.Add(M);
                }

                Material = (from m in DB.Material_Info where m.Group_ID == 3 || m.Group_ID == 4 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    clb_Other.Items.Add(M);
                }

                int? id = DB.Distributors.Max(i => (int?)i.Distributor_ID);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "100";

                tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
        }
    }
}
