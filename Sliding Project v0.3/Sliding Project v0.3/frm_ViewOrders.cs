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
    public partial class frm_ViewOrders : Form
    {
        public frm_ViewOrders()
        {
            InitializeComponent();

            using (CrewEntities DB = new CrewEntities())
            {
                dgv_Orders.DataSource = DB.Orders.ToList();
            }
        }
    }
}
