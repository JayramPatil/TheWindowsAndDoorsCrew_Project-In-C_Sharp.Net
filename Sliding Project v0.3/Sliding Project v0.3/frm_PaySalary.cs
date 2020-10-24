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
    public partial class frm_PaySalary : Form
    {
        public frm_PaySalary()
        {
            InitializeComponent();
        }
        public frm_PaySalary(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Pending Bills";
        }
    }
}
