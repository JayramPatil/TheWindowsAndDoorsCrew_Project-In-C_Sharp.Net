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
            pictureBox1.Visible = true;
            Cons = i;
            lbl_Header.Text = "Update Customer Details";
            btn_Add.Text = "Update";
            using(CrewEntities DB = new CrewEntities())
            {
                var Cust = DB.Customers.Find(Cons);

                if(Cust != null)
                {
                    tb_ID.Text = Cons.ToString();
                    tb_Address.Text = Cust.Address;
                    tb_Name.Text = Cust.Name;
                    tb_MobileNo.Text = Cust.Mobile_No;
                }

            }
        }
        public void Refresh()
        {
            tb_Address.Text = "";
            tb_Name.Text = "";
            tb_MobileNo.Text = "";
            tb_ID.Text = "";

            if (Cons == 0)
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
        public int CheckFilled()
        {
            if(tb_Address.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "" && tb_ID.Text != "")
            {
                return 1;
            }
            return 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (CheckFilled() == 1)
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    if (btn_Add.Text == "Add")
                    {
                        DB.Customers.Add(new Customer { Name = tb_Name.Text, Mobile_No = tb_MobileNo.Text, Address = tb_Address.Text });
                        DB.SaveChanges();
                    }
                    else
                    {
                        int i = Convert.ToInt32(tb_ID.Text);
                        Customer Cust = DB.Customers.Where(c => c.Customer_ID == i).FirstOrDefault();
                        Cust.Name = tb_Name.Text;
                        Cust.Mobile_No = tb_MobileNo.Text;
                        Cust.Address = tb_Address.Text;
                        DB.SaveChanges();
                    }

                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Feilds !!!");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int i = Convert.ToInt32(tb_ID.Text);
                var Cust = DB.Customers.Find(i);

                if (Cust != null)
                {
                    tb_ID.Text = Cons.ToString();
                    tb_Address.Text = Cust.Address;
                    tb_Name.Text = Cust.Name;
                    tb_MobileNo.Text = Cust.Mobile_No;
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID");
                }
            }
        }
    }
}
