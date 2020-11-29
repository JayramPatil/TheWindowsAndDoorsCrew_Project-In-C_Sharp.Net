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
        int Cons = 0;
        public frm_AddCustomer()
        {
            InitializeComponent();
            ID();
        }
        public frm_AddCustomer(int i)
        {
            InitializeComponent();
            Cons = i;
            lbl_Header.Text = "Update Customer Details";
            btn_Add.Text = "Update";
        }
        public void Refresh()
        {
            tb_Address.Text = "";
            tb_Name.Text = "";
            tb_MobileNo.Text = "";

            if (Cons != 1)
                ID();
        }
        public void ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int? id = DB.Customers.Max(i => (int?)i.Customer_ID);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "100";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using(CrewEntities DB = new CrewEntities())
            {

                DB.Customers.Add(new Customer { Name = tb_Name.Text, Mobile_No = tb_MobileNo.Text, Address = tb_Address.Text });
                DB.SaveChanges();

                Refresh();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
