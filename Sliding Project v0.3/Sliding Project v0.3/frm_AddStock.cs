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
    public partial class frm_AddStock : Form
    {
        public frm_AddStock()
        {
            InitializeComponent();
        }
        public frm_AddStock(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Stock";
            btn_Search.Visible = true;
            //groupBox1.Enabled = false;
            btn_Save.Text = "Update";
        }
    }
}
