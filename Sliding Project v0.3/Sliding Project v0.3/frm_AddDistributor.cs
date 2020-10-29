using System;
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
    }
}
