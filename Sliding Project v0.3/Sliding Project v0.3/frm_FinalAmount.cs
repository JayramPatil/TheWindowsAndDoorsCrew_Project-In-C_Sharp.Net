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
    public partial class frm_FinalAmount : Form
    {
        static int flag = 1;
        public static DataTable dt;
        public static int test = 0;
        string OrderDate;
        string OrderID;
        int custID;
        string amount;
        int Total1;
        public frm_FinalAmount(string Total, string Date, string Order_ID, DataTable Data, int i, string cid)
        {
            InitializeComponent();
            Total1 = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100 + 1000);
            tb_Total.Text = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100 + 1000).ToString();
            tb_DDate.Text = Convert.ToDateTime(Date).AddDays(8).ToString("dd-MM-yyyy");
            OrderDate = Date;
            OrderID = Order_ID;
            custID = Convert.ToInt32(cid);
            dt = Data;
            amount = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100).ToString();
            cmb_Installation.SelectedIndex = 0;
            cmb_Discount.SelectedIndex = 0;

            if(i == 1)
            {
                btn_Confirm.Text = "Update";
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Installation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Installation.Text == "YES" && flag == 0)
            {
                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) + 1000).ToString();
                flag = 1;
            }
            else if(cmb_Installation.Text == "NO" && flag == 1)
            {
                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) - 1000).ToString();
                flag = 0;
            }
        }

        private void cmb_Discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = (flag == 1) ? 1000 : 0;
            tb_Total.Text = (Convert.ToInt32(amount) - Convert.ToInt32(amount) * Convert.ToInt32(cmb_Discount.Text.Remove(cmb_Discount.Text.Length-1)) / 100 + i).ToString();
        }

        private void tb_Total_TextChanged(object sender, EventArgs e)
        {
            tb_Advance.Text = (Convert.ToInt32(tb_Total.Text) * 30 / 100).ToString();

            tb_Remaining.Text = (Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(tb_Advance.Text)).ToString();

        }

        private void tb_Advance_TextChanged(object sender, EventArgs e)
        {
            string i = "0";
            if(tb_Advance.Text != "")
            {
                i = tb_Advance.Text;
            }
            
            tb_Remaining.Text = (Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(i)).ToString();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            using (CrewEntities DB = new CrewEntities())
            {

                if (btn_Confirm.Text == "CONFIRM")
                {
                    
                    DateTime date = Convert.ToDateTime(OrderDate);
                    decimal Installation = (cmb_Installation.Text == "YES") ? 1000 : 0;
                    double gst = ((Convert.ToInt32(Total1) + Convert.ToInt32(Total1) * 12 / 100 + 1000));
                    double discount = (Convert.ToInt32(amount) * Convert.ToInt32(cmb_Discount.Text.Remove(cmb_Discount.Text.Length - 1)) / 100);
                    DateTime dDate = Convert.ToDateTime(tb_DDate.Text);
                    decimal total = Convert.ToInt32(tb_Total.Text);
                    decimal remaining = Convert.ToInt32(tb_Remaining.Text);
                    decimal paid = Convert.ToInt32(tb_Advance.Text);

                    DB.Orders.Add(new Order { Customer_ID = custID, User_ID = 2, Order_Date = date, Installation_Charge = Installation, GST = gst, Discount =  discount, Total = total, Paid_Amount = paid, Remaining_Amount = remaining, Delivery_Date = dDate, Status = "Incomplete"});
                    DB.SaveChanges();

                    InsertItems();

                    MessageBox.Show("Order Placed Successfully. Thank You : )");

                    test = 1;

                    this.Close();
                }
                else
                {
                    var Order = DB.Orders.Find(Convert.ToInt32(OrderID));

                    if (Order != null)
                    {
                        Order.Order_Date = Convert.ToDateTime(OrderDate);
                        Order.Installation_Charge = (cmb_Installation.Text == "YES") ? 1000 : 0;
                        Order.GST = ((Convert.ToInt32(Total1) + Convert.ToInt32(Total1) * 12 / 100 + 1000));
                        Order.Discount = (Convert.ToInt32(amount) * Convert.ToInt32(cmb_Discount.Text.Remove(cmb_Discount.Text.Length - 1)) / 100);
                        Order.Total = Convert.ToInt32(tb_Total.Text);
                        Order.Paid_Amount = Convert.ToInt32(tb_Advance.Text);
                        Order.Remaining_Amount = Convert.ToInt32(tb_Remaining.Text);
                        Order.Delivery_Date = Convert.ToDateTime(tb_DDate.Text);


                        //var stock = (from ss in DB.Stock_Ordered_Items where ss.Order_ID == Order.Order_ID select ss).ToList();

                        //foreach (var i in stock)
                        //{
                        //    var S = (from s1 in DB.Stocks where s1.Material_Name == i.Material_Name && s1.Type == i.Type && s1.Colour == i.Colour && s1.Size == i.Size && s1.Track == i.Track select s1).FirstOrDefault();

                        //    if (S != null)
                        //    {
                        //        S.Available_Stock -= i.Quantity;
                        //    }
                        //}

                        DB.Ordered_Items.RemoveRange(DB.Ordered_Items.Where(dm => dm.Order_ID == Order.Order_ID));
                        DB.SaveChanges();

                        InsertItems();

                        test = 0;

                        this.Close();
                    }
                }
                


            }
        }

        private void InsertItems()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                foreach (DataRow row in dt.Rows)
                {
                    //int? Size = (int.TryParse(row.Cells[5].Value.ToString(), out var s) ? (int?)s : null);
                    int? Track = (int.TryParse(row[5].ToString(), out var t) ? (int?)t : null);

                    DB.Ordered_Items.Add(new Ordered_Items { Order_ID = Convert.ToInt32(OrderID),Catagory = row[0].ToString(),Product_Name = row[1].ToString(), Material_Type = row[2].ToString(), Glass_Type = row[4].ToString(), Colour = row[3].ToString(), Track = Track, Height = Convert.ToInt32(row[6]), Width = Convert.ToInt32(row[7]), Quantity = Convert.ToInt32(row[8])});
                    DB.SaveChanges();

                    //string Material_Name = row.Cells[1].Value.ToString();
                    //string Type = row.Cells[2].Value.ToString();
                    //string Colour = row.Cells[3].Value.ToString();
                    //int PP = Convert.ToInt32(row.Cells[7].Value);

                    //var Stock = (from s1 in DB.Stocks where s1.Material_Name == Material_Name && s1.Type == Type && s1.Colour == Colour && s1.Size == Size && s1.Track == Track select s1).FirstOrDefault();

                    //if (Stock != null)
                    //{
                    //    Stock.Available_Stock = (Convert.ToInt32(Stock.Available_Stock) + Convert.ToInt32(row.Cells[6].Value));

                    //    if (Convert.ToInt32(Stock.Purchase_Price) <= Convert.ToInt32(row.Cells[7].Value))
                    //    {
                    //        Stock.Purchase_Price = PP;
                    //    }
                    //}
                    //else
                    //{
                    //    int As = Convert.ToInt32(row.Cells[6].Value);

                    //    DB.Stocks.Add(new Stock { Material_Name = Material_Name, Type = Type, Colour = Colour, Track = Track, Size = Size, Available_Stock = As, Purchase_Price = PP });
                    //}
                    //DB.SaveChanges();
                }
                DB.Customer_Transaction.Add(new Customer_Transaction { Order_ID = Convert.ToInt32(OrderID), User_ID = 2, Date = DateTime.Now, Paid= Convert.ToDecimal(tb_Advance.Text) });
                DB.SaveChanges();
            }
        }
    }
}
