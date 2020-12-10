using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            ID();
            CLB_Content();
        }
        public frm_AddProduct(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Product";
            btn_Add.Text = "Update";
            btn_Search.Visible = true;

            CLB_Content();

            if (i != 0)
                Search(i);
        }

        private void Search(int ID)
        {
            using(CrewEntities DB = new CrewEntities())
            {
                var Prod = DB.Products.Find(ID);

                if(Prod != null)
                {
                    if (Prod.Track == "YES")
                    {
                        rb_Yes.Checked = true;
                    }
                    else
                    {
                        rb_No.Checked = true;
                    }

                    tb_ID.Text = Prod.Product_ID.ToString();
                    tb_Name.Text = Prod.Product_Name;
                    cmb_Catagory.Text = Prod.Catagory;
                    tb_Price.Text = Prod.Price.ToString();
                    cmb_RequiredTimeToBuild.Text = Prod.Time_To_Build.ToString();
                    tb_Description.Text = Prod.Description;

                    MemoryStream ms = new MemoryStream((byte[])Prod.Image);

                    pb_Image.Image = new Bitmap(ms);

                    var Material = (from m in DB.Product_Material where m.Product_ID == ID select m.Material).ToList();

                    foreach (var item in Material)
                    {
                        bool C = true;
                        if (C)
                        {
                            for (int j = 0; j < clb_Window.Items.Count; j++)
                            {
                                if (item == clb_Window.Items[j].ToString())
                                {
                                    clb_Window.SetItemChecked(j, true);
                                    C = false;
                                    break;
                                }
                            }
                        }
                        if (C)
                        {
                            for (int j = 0; j < clb_Glass.Items.Count; j++)
                            {
                                if (item == clb_Glass.Items[j].ToString())
                                {
                                    clb_Glass.SetItemChecked(j, true);
                                    C = false;
                                    break;
                                }
                            }
                        }
                        if (C)
                        {
                            for (int j = 0; j < clb_Other.Items.Count; j++)
                            {
                                if (item == clb_Other.Items[j].ToString())
                                {
                                    clb_Other.SetItemChecked(j, true);
                                    C = false;
                                    break;
                                }
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Product ID");
                }
            }
        }

        private Image ByteArrayToImage(byte[] vs)
        {
            throw new NotImplementedException();
        }

        public void ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int? id = DB.Products.Max(i => (int?)i.Product_ID);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "100";
            }
        }
        private void CLB_Content()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                var Material = (from m in DB.Material_Info where m.Group_ID == 1 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    clb_Window.Items.Add(M);
                }

                Material = (from m in DB.Material_Info where m.Group_ID == 2 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    clb_Glass.Items.Add(M);
                }

                Material = (from m in DB.Material_Info where m.Group_ID == 3 || m.Group_ID == 4 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    clb_Other.Items.Add(M);
                }
            }
        }
        public void InsertCLBitems(int ID)
        {
            using (CrewEntities DB = new CrewEntities())
            {               
                for (int i = 0; i < clb_Window.Items.Count; i++)
                {
                    if (clb_Window.GetItemCheckState(i) == CheckState.Checked)
                    {
                        DB.Product_Material.Add(new Product_Material { Product_ID = ID, Material = clb_Window.Items[i].ToString() });
                    }
                }
                
                for (int i = 0; i < clb_Glass.Items.Count; i++)
                {
                    if (clb_Glass.GetItemCheckState(i) == CheckState.Checked)
                    {
                        DB.Product_Material.Add(new Product_Material { Product_ID = ID, Material = clb_Glass.Items[i].ToString() });
                    }
                }
                
                for (int i = 0; i < clb_Other.Items.Count; i++)
                {
                    if (clb_Other.GetItemCheckState(i) == CheckState.Checked)
                    {
                        DB.Product_Material.Add(new Product_Material { Product_ID = ID, Material = clb_Other.Items[i].ToString() });
                    }
                }               
                DB.SaveChanges();
            }
        }
        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
           // CLB_Content();
        }
        private bool CheckFilled()
        {
            if(tb_ID.Text != "" && tb_Name.Text != "" && cmb_Catagory.Text != "" && tb_Price.Text != "" && cmb_RequiredTimeToBuild.Text != "" && tb_Description.Text != "" && pb_Image.Image != null)
            {
                return true;
            }
            return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(CheckFilled())
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    ImageConverter con = new ImageConverter();
                    byte[] imgArray = (byte[])con.ConvertTo(pb_Image.Image, typeof(byte[]));
                    int ID = Convert.ToInt32(tb_ID.Text);

                    string RB = "NO";

                    if (rb_Yes.Checked)
                        RB = rb_Yes.Text;

                    if (btn_Add.Text == "Add")
                    {
                        
                        DB.Products.Add(new Product { Product_Name = tb_Name.Text, Catagory = cmb_Catagory.Text, Price = Convert.ToInt32(tb_Price.Text), Time_To_Build = Convert.ToInt32(cmb_RequiredTimeToBuild.Text), Image = imgArray, Description = tb_Description.Text, Track = RB });
                        DB.SaveChanges();

                        InsertCLBitems(ID);
                    }
                    else
                    {
                        var prod = DB.Products.Find(ID);

                        if(prod != null)
                        {
                            prod.Product_Name = tb_Name.Text;
                            prod.Catagory = cmb_Catagory.Text;
                            prod.Price = Convert.ToDecimal(tb_Price.Text);
                            prod.Time_To_Build = Convert.ToInt32(cmb_RequiredTimeToBuild.Text);
                            prod.Description = tb_Description.Text;
                            prod.Track = RB;
                            prod.Image = imgArray;

                            DB.SaveChanges();

                            DB.Product_Material.RemoveRange(DB.Product_Material.Where(pm => pm.Product_ID == ID));

                            InsertCLBitems(ID);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Fields !!!");
            }
            
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp)|.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pb_Image.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
            }
        }

        private void Refresh()
        {
            tb_ID.Text = "";
            tb_Name.Text = "";
            cmb_Catagory.Text = "";
            tb_Price.Text = "";
            cmb_RequiredTimeToBuild.Text = "";
            tb_Description.Text = "";
            rb_Yes.Checked = false;
            rb_No.Checked = false;
            pb_Image.Image = null;

            if (btn_Add.Text == "Add")
                ID();
            
            for (int i = 0; i < clb_Glass.Items.Count; i++)
            {
                clb_Glass.SetItemChecked(i, false);
            }
            
            for (int i = 0; i < clb_Other.Items.Count; i++)
            {
                clb_Other.SetItemChecked(i, false);
            }
               
            for (int i = 0; i < clb_Window.Items.Count; i++)
            {
                clb_Window.SetItemChecked(i, false);
            }
            
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(tb_ID.Text));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_WindowsSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_Window.Items.Count; i++)
            {
                clb_Window.SetItemChecked(i, true);
            }
        }

        private void btn_GlassSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_Glass.Items.Count; i++)
            {
                clb_Glass.SetItemChecked(i, true);
            }
        }

        private void btn_OtherSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_Other.Items.Count; i++)
            {
                clb_Other.SetItemChecked(i, true);
            }
        }

        private void cmb_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Catagory.Text == "Door")
            {
                clb_Glass.Enabled = false;
                clb_Other.Enabled = false;
                clb_Window.Enabled = false;

                btn_GlassSelectAll.Enabled = false;
                btn_WindowsSelectAll.Enabled = false;
                btn_OtherSelectAll.Enabled = false;

                for (int i = 0; i < clb_Glass.Items.Count; i++)
                {
                    clb_Glass.SetItemChecked(i, false);
                }

                for (int i = 0; i < clb_Other.Items.Count; i++)
                {
                    clb_Other.SetItemChecked(i, false);
                }

                for (int i = 0; i < clb_Window.Items.Count; i++)
                {
                    clb_Window.SetItemChecked(i, false);
                }
            }
            else
            {
                clb_Glass.Enabled = true;
                clb_Other.Enabled = true;
                clb_Window.Enabled = true;

                btn_GlassSelectAll.Enabled = true;
                btn_WindowsSelectAll.Enabled = true;
                btn_OtherSelectAll.Enabled = true;
            }
        }
    }
}
