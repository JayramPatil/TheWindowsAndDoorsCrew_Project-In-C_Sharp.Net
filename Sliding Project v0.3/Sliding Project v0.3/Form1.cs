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
    public partial class frm_AcceptOrder : Form
    {
        public frm_AcceptOrder()
        {
            InitializeComponent();
            Cust_ID();
            Orders_ID();
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        public frm_AcceptOrder(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Order";
            panel_NewOldCustomer.Enabled = false;
            btn_Search.Visible = true;
            tb_Date.Enabled = false;
            tb_Name.Enabled = false;
            tb_Address.Enabled = false;
            tb_MobileNo.Enabled = false;
            btn_Refresh.Text = "Reset";
            btn_UpdatePaymentDetails.Visible = true;
            lbl_ID.Text = "Order ID";
            Order_ID.Visible = false;
            lbl_OrderID.Visible = false;
        }
        public void Orders_ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int? id = DB.Orders.Max(i => (int?)i.Order_ID);

                if (id != null)
                    Order_ID.Text = (id + 1).ToString();
                else
                    Order_ID.Text = "1000";
            }
        }
        public void Cust_ID()
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
        private void frm_AcceptOrder_Load(object sender, EventArgs e)
        {
            rb_NewCustomer.Select();

            using(CrewEntities DB = new CrewEntities())
            {
                var cat = DB.Catagories.ToList();

                foreach (var c in cat)
                {
                    cmb_Catagory.Items.Add(c.Name);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            Form formBackground = new Form();
            try
            {
                using (frm_FinalAmount obj = new frm_FinalAmount())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    obj.Owner = formBackground;
                    obj.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void rb_OldCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_OldCustomer.Checked)
            {
                btn_Search.Visible = true;
                tb_Date.Enabled = false;
                tb_Name.Enabled = false;
                tb_Address.Enabled = false;
                tb_MobileNo.Enabled = false;
                tb_ID.Text = "";
                
            }
            else
            {
                btn_Search.Visible = false;
                tb_Date.Enabled = true;
                tb_Name.Enabled = true;
                tb_Address.Enabled = true;
                tb_MobileNo.Enabled = true;
                //tb_Date.Text = "";
                tb_Name.Text = "";
                tb_Address.Text = "";
                tb_MobileNo.Text = "";
                Cust_ID();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_ID.Text != "")
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    var Cust = DB.Customers.Find(Convert.ToInt32(tb_ID.Text));

                    if (Cust != null)
                    {
                        tb_Name.Text = Cust.Name;
                        tb_MobileNo.Text = Cust.Mobile_No;
                        tb_Address.Text = Cust.Address;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Customer ID");
                    }
                }
            }
            
        }

        private void cmb_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Product.Items.Clear();
            cmb_Product.Text = "";
            cmb_Colour.Text = "";
            cmb_GlassType.Text = "";
            cmb_Track.Text = "";
            cmb_MaterialType.Text = "";

            if(cmb_Catagory.Text != "Door")
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    var p = (from a in DB.Products where a.Catagory == "Window" select a.Product_Name).ToList();

                    foreach (var i in p)
                    {
                        cmb_Product.Items.Add(i);
                    }
                }
                cmb_MaterialType.Enabled = true;
                cmb_Colour.Enabled = true;
                cmb_GlassType.Enabled = true;
                cmb_Track.Enabled = true;
            }
            else
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    var p = (from a in DB.Products where a.Catagory == "Door" select a.Product_Name).ToList();

                    foreach (var i in p)
                    {
                        cmb_Product.Items.Add(i);
                    }
                }
                cmb_MaterialType.Enabled = false;
                cmb_Colour.Enabled = false;
                cmb_GlassType.Enabled = false;
                cmb_Track.Enabled = false;
            }
        }

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(CrewEntities DB = new CrewEntities())
            {
                var GlassType = (from g in DB.Product_Material where g.Material.Contains("Glass") select g).ToList();

                var Track = (from T in DB.Products select T.Track).ToList();

                if (GlassType != null)
                {
                    cmb_GlassType.Enabled = true;

                    foreach (var i in GlassType)
                    {
                        cmb_GlassType.Items.Add(i.Material);
                    }
                }
                else
                {
                    cmb_GlassType.Enabled = false;
                }

            }
        }
    }
}
