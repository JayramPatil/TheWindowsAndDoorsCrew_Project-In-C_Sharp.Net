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
    public partial class frm_AddUser : Form
    {
        public frm_AddUser()
        {
            InitializeComponent();
        }
        public frm_AddUser(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update User Details";
            btn_Add.Text = "Update";
            btn_Search.Visible = true;
        }
    }
}
