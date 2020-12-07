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
    public partial class frm_AddStock : Form
    {
        Decimal Total = 0;

        DataTable dt = new DataTable();
        public frm_AddStock()
        {
            InitializeComponent();
            ID();
            CreateColums();
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        public frm_AddStock(int i)
        {
            InitializeComponent();
            CreateColums();
            lbl_Header.Text = "Update Stock";
            btn_Search.Visible = true;
            //groupBox1.Enabled = false;
            btn_Save.Text = "Update";

            if(i != 0)
                Search(i);

        }
        public void ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int? id = DB.Stock_Order.Max(i => (int?)i.Order_ID);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "1000";
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (frm_AddMaterial obj = new frm_AddMaterial())
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

        public void CreateColums()
        {
            DataColumn c1 = new DataColumn("Material Name", typeof(string));
            DataColumn c2 = new DataColumn("Type", typeof(string),null);
            DataColumn c3 = new DataColumn("Colour", typeof(string),null);
            DataColumn c4 = new DataColumn("Track", typeof(int),null);
            DataColumn c5 = new DataColumn("Size", typeof(int),null);
            DataColumn c6 = new DataColumn("Quantity", typeof(int));
            DataColumn c7 = new DataColumn("Price", typeof(int));

            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);
            dt.Columns.Add(c4);
            dt.Columns.Add(c5);
            dt.Columns.Add(c6);
            dt.Columns.Add(c7);
        }
        private void frm_AddStock_Load(object sender, EventArgs e)
        {
            using(CrewEntities DB = new CrewEntities())
            {
                var dis = (from d in DB.Distributors select d.Name).ToList();

                foreach (var d in dis)
                {
                    cmb_Distributor.Items.Add(d);
                }
            }
        }

        private void cmb_Distributor_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CrewEntities DB = new CrewEntities())
            {
                cmb_Material.Text = "";
                cmb_Material.Items.Clear();

                var Dist_ID = (from i in DB.Distributors where i.Name == cmb_Distributor.Text select i.Distributor_ID).FirstOrDefault();

                var dis = (from d in DB.Distributor_Material where d.Distributor_ID == Dist_ID select d.Material_Name).ToList();

                foreach (var d in dis)
                {
                    cmb_Material.Items.Add(d);
                }
            }
        }

        private void ClearGB2()
        {
            cmb_Type.Items.Clear();
            cmb_Type.Text = "";
            cmb_Colour.Items.Clear();
            cmb_Colour.Text = "";
            cmb_Track.Items.Clear();
            cmb_Track.Text = "";
            cmb_Size.Items.Clear();
            cmb_Size.Text = "";

            tb_PPrice.Text = "";
            tb_Quantity.Text = "";
        }
        private void cmb_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGB2();

            using (CrewEntities DB = new CrewEntities())
            {
                int Material_Group = (from mg in DB.Material_Info where mg.Material_Name == cmb_Material.Text select mg.Group_ID).First();

                var Type = (from t in DB.Material_Type where t.Group_ID == Material_Group select t.Type).ToList();

                if(Type.Count != 0)
                {
                    cmb_Type.Enabled = true;
                    foreach (var t in Type)
                    {
                        cmb_Type.Items.Add(t);
                    }
                }
                else
                {
                    cmb_Type.Enabled = false;
                }

                var Colour = (from t in DB.Material_Colour where t.Group_ID == Material_Group select t.Colour).ToList();

                if (Colour.Count != 0)
                {
                    cmb_Colour.Enabled = true;
                    foreach (var t in Colour)
                    {
                        cmb_Colour.Items.Add(t);
                    }
                }
                else
                {
                    cmb_Colour.Enabled = false;
                }

                var Track = (from t in DB.Material_Track where t.Group_ID == Material_Group select t.Track).ToList();

                if (Track.Count != 0)
                {
                    cmb_Track.Enabled = true;
                    foreach (var t in Track)
                    {
                        cmb_Track.Items.Add(t);
                    }
                }
                else
                {
                    cmb_Track.Enabled = false;
                }

                var Size = (from t in DB.Material_Size where t.Group_ID == Material_Group select t.Size).ToList();

                if (Size.Count != 0)
                {
                    cmb_Size.Enabled = true;
                    foreach (var t in Size)
                    {
                        cmb_Size.Items.Add(t);
                    }
                }
                else
                {
                    cmb_Size.Enabled = false;
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(tb_PPrice.Text != "" && tb_Quantity.Text != "")
            {
                if(btn_Save.Text == "Save")
                    Total += (Convert.ToInt32(tb_PPrice.Text) * Convert.ToInt32(tb_Quantity.Text));
                else
                {
                    Decimal a = Convert.ToDecimal(tb_PPrice.Text);
                    Decimal b = Convert.ToDecimal(tb_Quantity.Text);
                    Decimal t1 = Convert.ToDecimal(tb_Total.Text);

                    Total = (t1 + (a*b));
                }
                DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                Edit.Name = "Edit";
                Edit.Text = "Edit";
                Edit.UseColumnTextForButtonValue = true;
                int columnIndex = 0;
                if (dgv_StockItems.Columns["Edit"] == null)
                {
                    dgv_StockItems.Columns.Insert(columnIndex, Edit);
                }
                //dgv_StockItems.Rows.Insert(columnIndex, Edit);

                tb_Total.Text = Total.ToString();

                int? Size = (int.TryParse(cmb_Size.Text, out var s) ? (int?)s : null);
                int? Track = (int.TryParse(cmb_Track.Text, out var t) ? (int?)t : null);

                dt.Rows.Add(cmb_Material.Text, cmb_Type.Text, cmb_Colour.Text, Track, Size, Convert.ToInt32(tb_Quantity.Text), Convert.ToInt32(tb_PPrice.Text));

                dgv_StockItems.DataSource = dt;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Remove";
                btn.Text = "Remove";
                btn.UseColumnTextForButtonValue = true;
                columnIndex = 0;
                if (dgv_Remove.Columns["Remove"] == null)
                {
                    dgv_Remove.Columns.Insert(columnIndex, btn);
                }
                dgv_Remove.Rows.Insert(columnIndex, btn);

             
            }
            else
            {
                MessageBox.Show("First Fill The Required Fields !!!");
            }
        }
        private bool CheckFilled()
        {
            if(tb_ID.Text != "" && cmb_Material.Text != "" && cmb_Distributor.Text != "" && tb_Total.Text != "" && tb_Paid.Text != "" && dgv_StockItems.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private void Refresh()
        {
            tb_Date.Text = "";
            cmb_Distributor.Text = "";
            cmb_Material.Text = "";
            tb_Total.Text = "";
            tb_Paid.Text = "0";
            Total = 0;

            ClearGB2();
            if(btn_Save.Text == "Save")
            {
                ID();
                tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
        }
        private void Search(int ID)
        {
            dgv_Remove.Rows.Clear();
            dt.Rows.Clear();

            using (CrewEntities DB = new CrewEntities())
            {
                var Order = DB.Stock_Order.Find(ID);

                if(Order != null)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "Remove";
                    btn.Text = "Remove";
                    btn.UseColumnTextForButtonValue = true;
                    int columnIndex = 0;

                    tb_Date.Text = Order.Date.ToString("dd-MM-yyyy");
                    cmb_Distributor.Text = Order.Distributor_Name;
                    tb_Total.Text = Order.Total.ToString();
                    tb_Paid.Text = Order.Paid_Amount.ToString();

                    var OI = (from oi in DB.Stock_Ordered_Items where oi.Order_ID == ID select oi).ToList();

                    foreach (var i in OI)
                    {
                        dt.Rows.Add(i.Material_Name, i.Type, i.Colour, i.Track, i.Size, i.Quantity, i.Purchase_Price);

                        if (dgv_Remove.Columns["Remove"] == null)
                        {
                            dgv_Remove.Columns.Insert(columnIndex, btn);
                        }
                        dgv_Remove.Rows.Insert(columnIndex, btn);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Order ID !");
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckFilled())
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    int Rem = Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(tb_Paid.Text);

                    if (btn_Save.Text == "Save")
                    {
                        DB.Stock_Order.Add(new Stock_Order { Date = Convert.ToDateTime(tb_Date.Text), Distributor_Name = cmb_Distributor.Text, Total = Convert.ToDecimal(tb_Total.Text), Paid_Amount = Convert.ToDecimal(tb_Paid.Text), Remaining_Amount = Rem });
                        DB.SaveChanges();

                        InsertItems();
                    }
                    else
                    {
                        var Order = DB.Stock_Order.Find(Convert.ToInt32(tb_ID.Text));

                        if(Order != null)
                        {
                            Order.Distributor_Name = cmb_Distributor.Text;
                            Order.Total = Convert.ToInt32(tb_Total.Text);
                            Order.Paid_Amount = Convert.ToInt32(tb_Paid.Text);
                            Order.Remaining_Amount = Rem;

                            var stock = (from ss in DB.Stock_Ordered_Items where ss.Order_ID == Order.Order_ID select ss).ToList();

                            foreach (var i in stock)
                            {
                                var S = (from s1 in DB.Stocks where s1.Material_Name == i.Material_Name && s1.Type == i.Type && s1.Colour == i.Colour && s1.Size == i.Size && s1.Track == i.Track select s1).FirstOrDefault();

                                if (S != null)
                                {
                                    S.Available_Stock -= i.Quantity;
                                } 
                            }

                            DB.Stock_Ordered_Items.RemoveRange(DB.Stock_Ordered_Items.Where(dm => dm.Order_ID == Order.Order_ID));
                            DB.SaveChanges();

                            InsertItems();
                        }
                    }
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Fields !!!");
            }
        }
        private void InsertItems()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                foreach (DataGridViewRow row in dgv_StockItems.Rows)
                {
                    int? Size = (int.TryParse(row.Cells[4].Value.ToString(), out var s) ? (int?)s : null);
                    int? Track = (int.TryParse(row.Cells[3].Value.ToString(), out var t) ? (int?)t : null);

                    DB.Stock_Ordered_Items.Add(new Stock_Ordered_Items { Order_ID = Convert.ToInt32(tb_ID.Text), Material_Name = row.Cells[0].Value.ToString(), Type = row.Cells[1].Value.ToString(), Colour = row.Cells[2].Value.ToString(), Track = Track, Size = Size, Quantity = Convert.ToInt32(row.Cells[5].Value), Purchase_Price = Convert.ToInt32(row.Cells[6].Value) });
                    DB.SaveChanges();

                    string Material_Name = row.Cells[0].Value.ToString();
                    string Type = row.Cells[1].Value.ToString();
                    string Colour = row.Cells[2].Value.ToString();
                    int PP = Convert.ToInt32(row.Cells[6].Value);

                    var Stock = (from s1 in DB.Stocks where s1.Material_Name == Material_Name && s1.Type == Type && s1.Colour == Colour && s1.Size == Size && s1.Track == Track select s1).FirstOrDefault();

                    if (Stock != null)
                    {
                        Stock.Available_Stock = (Convert.ToInt32(Stock.Available_Stock) + Convert.ToInt32(row.Cells[5].Value));

                        if(Convert.ToInt32(Stock.Purchase_Price) <= Convert.ToInt32(row.Cells[6].Value))
                        {
                            Stock.Purchase_Price = PP;
                        }
                    }
                    else
                    {
                        int As = Convert.ToInt32(row.Cells[5].Value);

                        DB.Stocks.Add(new Stock { Material_Name = Material_Name, Type = Type, Colour = Colour, Track = Track, Size = Size, Available_Stock = As, Purchase_Price = PP });
                    }
                    DB.SaveChanges();
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
            dt.Rows.Clear();
            dgv_Remove.Rows.Clear();
        }
        private void dgv_Remove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = dt.Rows[e.RowIndex];

                tb_Total.Text = (Convert.ToDecimal(tb_Total.Text) - (Convert.ToDecimal(dt.Rows[e.RowIndex][5]) * Convert.ToDecimal(dt.Rows[e.RowIndex][6]))).ToString();

                dr.Delete();

                dgv_Remove.Rows.RemoveAt(e.RowIndex);

                dgv_StockItems.DataSource = dt;
            }
        }

        private void dgv_StockItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            cmb_Material.Text = dt.Rows[i][0].ToString();
            cmb_Type.Text = dt.Rows[i][1].ToString();
            cmb_Colour.Text = dt.Rows[i][2].ToString();
            cmb_Track.Text = dt.Rows[i][3].ToString();
            cmb_Size.Text = dt.Rows[i][4].ToString();
            tb_Quantity.Text = dt.Rows[i][5].ToString();
            tb_PPrice.Text = dt.Rows[i][6].ToString();

            dgv_Remove_CellClick(sender, e);
        }
    }
}
