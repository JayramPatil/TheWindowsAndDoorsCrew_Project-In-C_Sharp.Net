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
    public partial class frm_AcceptMoney : Form
    {
        public frm_AcceptMoney()
        {
            InitializeComponent();
        }
        public frm_AcceptMoney(int i)
        {
            InitializeComponent();
            if(i == 1)
            {
                lbl_Header.Text = "Update Order";
            }
            else
            {
                lbl_Header.Text = "Cancel Order";
            }
        }
    }
}