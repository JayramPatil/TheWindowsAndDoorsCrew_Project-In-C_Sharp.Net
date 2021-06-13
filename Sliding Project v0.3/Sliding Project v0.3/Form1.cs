using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sliding_Project_v0._3.MDI_Home;

namespace Sliding_Project_v0._3
{
    public partial class frm_AcceptOrder : Form
    {
        Decimal Total = 0;

        DataTable dt = new DataTable();
        public frm_AcceptOrder()
        {
            InitializeComponent();
            Cust_ID();
            Orders_ID();
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            //tb_Address.Text = User_ID.ToString();
            CreateColums();

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
            lbl_ID.Text = "Order ID";
            Order_ID.Visible = false;
            lbl_OrderID.Visible = false;
            CreateColums();
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

            using (CrewEntities DB = new CrewEntities())
            {
                var cat = DB.Catagories.ToList();

                foreach (var c in cat)
                {
                    cmb_Catagory.Items.Add(c.Name);
                }
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "" && tb_Address.Text != "")
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    if (lbl_Header.Text == "Accept Order" && rb_OldCustomer.Checked != true)
                    {
                        DB.Customers.Add(new Customer { Name = tb_Name.Text, Mobile_No = tb_MobileNo.Text, Address = tb_Address.Text });
                        DB.SaveChanges();

                        string str = tb_ID.Text;
                        rb_OldCustomer.Checked = true;
                        tb_ID.Text = str;
                    }
                }

                if (lbl_Header.Text == "Accept Order")
                {
                    Form formBackground = new Form();
                    try
                    {
                        using (frm_FinalAmount obj = new frm_FinalAmount(tb_Total.Text, tb_Date.Text, Order_ID.Text, dt, 0, tb_ID.Text))
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
                            frm_FinalAmount.dt = dt;
                            obj.Owner = formBackground;
                            obj.ShowDialog();

                            if (frm_FinalAmount.test == 1)
                                Refresh();

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
                else
                {
                    Form formBackground = new Form();
                    try
                    {
                        using (frm_FinalAmount obj = new frm_FinalAmount(tb_Total.Text, tb_Date.Text, Order_ID.Text, dt, 1, tb_ID.Text))
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
                            frm_FinalAmount.dt = dt;
                            
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
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Feilds !!!");
            }

        }

        private void rb_OldCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_OldCustomer.Checked)
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
            if (tb_ID.Text != "")
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
            cmb_Colour.Items.Clear();
            cmb_GlassType.Items.Clear();
            cmb_Track.Items.Clear();
            cmb_Product.Text = "";
            cmb_Colour.Text = "";
            cmb_GlassType.Text = "";
            cmb_Track.Text = "";
            cmb_MaterialType.Text = "";

            if (cmb_Catagory.Text != "Door")
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    var p = (from a in DB.Products where a.Catagory == "Window" select a.Product_Name).ToList();

                    foreach (var i in p)
                    {
                        cmb_Product.Items.Add(i);
                    }
                }
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
            cmb_Product.Enabled = true;
        }

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Colour.Items.Clear();
            cmb_GlassType.Items.Clear();
            cmb_Track.Items.Clear();
            cmb_Track.Enabled = false;

            cmb_MaterialType.Enabled = true;
            cmb_Colour.Enabled = true;
            cmb_GlassType.Enabled = true;
            cmb_Track.Enabled = true;

            using (CrewEntities DB = new CrewEntities())
            {
                var PID = (from p in DB.Products where p.Product_Name == cmb_Product.Text select p.Product_ID).FirstOrDefault();

                var GlassType = (from g in DB.Product_Material where g.Product_ID == PID && g.Material.Contains("Glass") select g).ToList();
                var Colour = (from c in DB.Material_Colour where c.Group_ID == 1 select c.Colour).ToList();
                var Track = (from T in DB.Products where T.Product_ID == PID select T.Track).FirstOrDefault();

                foreach (var i in Colour)
                {
                    cmb_Colour.Items.Add(i);
                }

                if (Track == "YES")
                {
                    cmb_Track.Enabled = true;
                    cmb_Track.Items.Add("1");
                    cmb_Track.Items.Add("2");
                    cmb_Track.Items.Add("3");
                    cmb_Track.Items.Add("4");
                }
                else
                {
                    cmb_Track.Enabled = false;
                    cmb_Track.Text = "";
                }

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
        private bool CheckFilled()
        {
            if (cmb_Product.Text != "" && tb_Height.Text != "" && tb_Width.Text != "" && tb_Quantity.Text != "" && tb_Price.Text != "")
            {
                return true;
            }
            return false;
        }
        public void CreateColums()
        {
            dt.Columns.Add(new DataColumn("Catagory", typeof(string)));
            dt.Columns.Add(new DataColumn("Product", typeof(string)));
            dt.Columns.Add(new DataColumn("Material Type", typeof(string)));
            dt.Columns.Add(new DataColumn("Colour", typeof(string)));
            dt.Columns.Add(new DataColumn("Glass Type", typeof(string)));
            dt.Columns.Add(new DataColumn("Track", typeof(int)));
            dt.Columns.Add(new DataColumn("Height", typeof(float)));
            dt.Columns.Add(new DataColumn("Width", typeof(float)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
            dt.Columns.Add(new DataColumn("Price", typeof(int)));
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (CheckFilled())
            {
                if (tb_Price.Text != "" && tb_Quantity.Text != "")
                {
                    if (btn_Next.Text == "Next")
                        Total += (((Convert.ToInt32(tb_Height.Text) * 2 + Convert.ToInt32(tb_Width.Text) * 2) * Convert.ToInt32(tb_Price.Text)) * Convert.ToInt32(tb_Quantity.Text));
                       // Total += (Convert.ToInt32(tb_Price.Text) * Convert.ToInt32(tb_Quantity.Text));
                    else
                    {
                        Decimal a = Convert.ToDecimal(tb_Price.Text);
                        Decimal b = Convert.ToDecimal(tb_Quantity.Text);
                        Decimal t1 = Convert.ToDecimal(tb_Total.Text);

                        Total = (t1 + (a * b));
                    }
                    DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                    Edit.Name = "Edit";
                    Edit.Text = "Edit";
                    Edit.UseColumnTextForButtonValue = true;
                    int columnIndex = 0;
                    if (dgv_OrderedItems.Columns["Edit"] == null)
                    {
                        dgv_OrderedItems.Columns.Insert(columnIndex, Edit);
                    }
                    //dgv_StockItems.Rows.Insert(columnIndex, Edit);

                    tb_Total.Text = Total.ToString();

                    int? Width = (int.TryParse(tb_Width.Text, out var s) ? (int?)s : null);
                    int? Height = (int.TryParse(tb_Height.Text, out var h) ? (int?)h : null);
                    int? Track = (int.TryParse(cmb_Track.Text, out var t) ? (int?)t : null);

                    dt.Rows.Add(cmb_Catagory.Text, cmb_Product.Text, cmb_MaterialType.Text, cmb_Colour.Text, cmb_GlassType.Text, Track, Height, Width, Convert.ToInt32(tb_Quantity.Text), Convert.ToInt32(tb_Price.Text));

                    dgv_OrderedItems.DataSource = dt;

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "Remove";
                    btn.Text = "Remove";
                    btn.UseColumnTextForButtonValue = true;
                    columnIndex = 0;
                    if (dgv_OrderedItems.Columns["Remove"] == null)
                    {
                        dgv_OrderedItems.Columns.Insert(columnIndex, btn);
                    }
                    //dgv_OrderedItems.Rows.Insert(columnIndex, btn);

                }
                else
                {
                    MessageBox.Show("First Fill The Required Fields !!!");
                }
            }
            else
            {
                MessageBox.Show("First Fill The Required Fields !!!");
            }
        }

        private void dgv_OrderedItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (e.ColumnIndex == 1 && e.RowIndex > 0)
            {
                cmb_Catagory.Text = dt.Rows[i][0].ToString();
                cmb_Product.Text = dt.Rows[i][1].ToString();
                cmb_MaterialType.Text = dt.Rows[i][2].ToString();
                cmb_Colour.Text = dt.Rows[i][3].ToString();
                cmb_GlassType.Text = dt.Rows[i][4].ToString();
                cmb_Track.Text = dt.Rows[i][5].ToString();
                tb_Height.Text = dt.Rows[i][6].ToString();
                tb_Width.Text = dt.Rows[i][7].ToString();
                tb_Quantity.Text = dt.Rows[i][8].ToString();
                tb_Price.Text = dt.Rows[i][9].ToString();

            }

            if (e.RowIndex >= 0)
            {
                DataRow dr = dt.Rows[e.RowIndex];

                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) - (((Convert.ToInt32(dt.Rows[i][7]) * 2 + Convert.ToInt32(dt.Rows[i][6]) * 2) * Convert.ToInt32(dt.Rows[i][9])) * Convert.ToInt32(dt.Rows[i][8]))).ToString();

                Total = Convert.ToInt32(tb_Total.Text);
           
                dr.Delete();

                dgv_OrderedItems.DataSource = dt;
            }      
        }
        public override void Refresh()
        {
            if(lbl_Header.Text == "Accept Order")
            {
                tb_Name.Clear();
                tb_MobileNo.Clear();
                tb_Address.Clear();
            }

            cmb_Catagory.Text = "";
            cmb_Product.Text = "";
            cmb_MaterialType.Text = "";
            cmb_Colour.Text = "";
            cmb_GlassType.Text = "";
            cmb_Track.Text = "";

            cmb_Product.Items.Clear();
            cmb_Colour.Items.Clear();
            cmb_GlassType.Items.Clear();
            cmb_Track.Items.Clear();

            cmb_Product.Enabled = false;
            cmb_MaterialType.Enabled = false;
            cmb_Colour.Enabled = false;
            cmb_GlassType.Enabled = false;
            cmb_Track.Enabled = false;

            tb_Height.Clear();
            tb_Width.Clear();
            tb_Quantity.Clear();
            tb_Price.Clear();

            dt.Rows.Clear();
            tb_Total.Clear();
            Total = 0;
            //dgv_Remove.Rows.Clear();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_ViewProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Will Be Available Soon ...", "Thank You For Your Patience");
        }
    }
}
