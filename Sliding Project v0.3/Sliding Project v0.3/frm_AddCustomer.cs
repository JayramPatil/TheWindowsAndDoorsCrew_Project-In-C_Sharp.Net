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
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }
        public frm_AddCustomer(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Customer Details";
            btn_Add.Text = "Update";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using(CrewEntities DB = new CrewEntities())
            {

                DB.Customers.Add(new Customer { Name = tb_Name.Text, Mobile_No = tb_MobileNo.Text, Address = tb_Address.Text });
                DB.SaveChanges();
            }
        }
    }
}
