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
    public partial class MDI_Home : Form
    {
        public MDI_Home()
        {
            InitializeComponent();
            Hide_SubMenu();
        }
        private void Hide_SubMenu()
        {
            foreach (Control panel in this.Controls)
            {
                foreach (Control panel1 in panel.Controls)
                {
                    if (panel1.GetType() == typeof(Panel) && panel1 != panel_LoginInfo)
                    {
                        panel1.Visible = false;
                    }
                }
            }
            /*panel_LoginInfo.Visible = true;
            panel_SpareParts.Visible = false;
            panel_Services.Visible = false;*/
        }
        private void Hide_Opened_SubMenu()
        {

            foreach (Control panel in this.Controls)
            {
                foreach (Control panel1 in panel.Controls)
                {
                    if (panel1.GetType() == typeof(Panel) && panel1 != panel_LoginInfo)
                    {
                        if(panel1.Visible == true)
                        {
                            panel1.Visible = false;
                        }
                    }
                }
            }

            /*if (panel_Products.Visible == true)
                {
                    panel_Products.Visible = false;
                }
                if (panel_SpareParts.Visible == true)
                {
                    panel_SpareParts.Visible = false;
                }
                if (panel_Services.Visible == true)
                {
                    panel_Services.Visible = false;
                }
            */
        }
        private void Btn_Colour()
        {
            foreach (Control btn in this.Controls)
            {
                foreach (Control btn1 in btn.Controls)
                {
                    if (btn1.GetType() == typeof(Button))
                    {
                        if (btn1.BackColor == Color.DarkBlue)
                        {
                            btn1.BackColor = Color.FromArgb(74, 83, 107);
                        }
                    }
                }
            }
        }
        private void Show_SubMenu(Panel SubPanel, Button Btn)
        {
            if (SubPanel.Visible == false)
            {
                Hide_Opened_SubMenu();
                Btn_Colour();
                SubPanel.Visible = true;
                Btn.BackColor = Color.DarkBlue;
            }
            else
            {
                SubPanel.Visible = false;
                Btn.BackColor = Color.FromArgb(74, 83, 107);
            }
        }

        public void OpenForm(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_Order_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_subOrders, btn_Order);
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubStock, btn_Stock);
        }

        private void btn_EditPrices_Click(object sender, EventArgs e)
        {
            if(btn_EditPrices.BackColor == Color.DarkBlue)
            {
                btn_EditPrices.BackColor = Color.FromArgb(74, 83, 107);
            }
            else
            {
                Btn_Colour();
                Hide_Opened_SubMenu();
                btn_EditPrices.BackColor = Color.DarkBlue;
                OpenForm(new frm_EditPrices());
            }

        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubPay, btn_Pay);
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubUser, btn_User);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubProduct, btn_Product);
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubEmployee, btn_Employee);
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubDistributor, btn_Distributor);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubCustomer, btn_Customer);
        }

        private void btn_TotalEE_Click(object sender, EventArgs e)
        {
            if (btn_TotalEE.BackColor == Color.DarkBlue)
            {
                btn_TotalEE.BackColor = Color.FromArgb(74, 83, 107);
            }
            else
            {
                Btn_Colour();
                Hide_Opened_SubMenu();
                btn_TotalEE.BackColor = Color.DarkBlue;
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Show_SubMenu(panel_SubReport, btn_Report);
        }

        private void btn_AcceptOrder_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AcceptOrder());
            Hide_Opened_SubMenu();

            /*frm_AcceptOrder frm = new frm_AcceptOrder();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();*/
        }

        private void btn_MarkAsCompleted_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_ManageOrders());
            Hide_Opened_SubMenu();
        }

        private void btn_AcceptMoney_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AcceptMoney());
            Hide_Opened_SubMenu();
        }

        private void btn_UpdateOrder_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AcceptOrder(1));
            //OpenForm(new frm_AcceptMoney(1));
            Hide_Opened_SubMenu();
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AcceptMoney(2));
            Hide_Opened_SubMenu();
        }

        private void btn_ViewOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_ViewOrders());
            Hide_Opened_SubMenu();
        }

        private void btn_ViewStock_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddStock());
            Hide_Opened_SubMenu();
        }

        private void btn_AddStock_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_ViewStock());
            Hide_Opened_SubMenu();
        }

        private void btn_UpdateStock_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddStock(1));
            Hide_Opened_SubMenu();
        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_PaySalary());
            Hide_Opened_SubMenu();
        }

        private void btn_DistributorBill_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_PaySalary(1));
            Hide_Opened_SubMenu();
        }

        private void btn_Maintainance_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_PayMaintenance());
            Hide_Opened_SubMenu();
        }

        private void btn_AddNewUser_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddUser());
            Hide_Opened_SubMenu();
        }

        private void btn_UpdateUserDetails_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddUser(1));
            Hide_Opened_SubMenu();
        }

        private void btn_ManageUser_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_ManageUsers());
            Hide_Opened_SubMenu();
        }
    }
}
