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
    public partial class frm_AddEmployee : Form
    {
        public frm_AddEmployee()
        {
            InitializeComponent();
        }
        public frm_AddEmployee(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Employee Details";
            btn_Search.Visible = true;
            btn_Save.Text = "Update";
        }
    }
}
