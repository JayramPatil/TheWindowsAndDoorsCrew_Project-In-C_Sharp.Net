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
    public partial class frm_AddProduct : Form
    {
        public frm_AddProduct()
        {
            InitializeComponent();
        }
        public frm_AddProduct(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Product";
            btn_Add.Text = "Update";
            btn_Search.Visible = true;
        }
    }
}
