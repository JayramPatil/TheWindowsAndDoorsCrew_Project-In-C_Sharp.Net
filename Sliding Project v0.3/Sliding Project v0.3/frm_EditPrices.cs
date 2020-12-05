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
    public partial class frm_EditPrices : Form
    {
        public frm_EditPrices()
        {
            InitializeComponent();

            

        }
        private void FillDGV()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                dgv_EditPrices.DataSource = (from p in DB.Products
                                             select new
                                             {
                                                 p.Product_ID,
                                                 p.Product_Name,
                                                 p.Catagory,
                                                 p.Price,
                                                 p.Time_To_Build,
                                                 p.Description,
                                                 p.Track
                                             }).ToList();

                var c = (from i in DB.Catagories select i.Name).ToList();

                foreach (var z in c)
                {
                    cmb_Catagory.Items.Add(z);
                }
            }
        }
        private void frm_EditPrices_Load(object sender, EventArgs e)
        {
            FillDGV();
        }
        private void Refresh()
        {
            //cmb_Catagory.Text = "";
            cmb_Name.Text = "";
            tb_Name.Text = "";
            tb_MCost.Text = "";
            tb_Selling.Text = "";
            tb_NewPrice.Text = "";
        }

        private void cmb_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            using(CrewEntities DB = new CrewEntities())
            {
                var c = (from i in DB.Products where i.Catagory == cmb_Catagory.Text select i.Product_Name).ToList();
                cmb_Name.Items.Clear();

                foreach (var z in c)
                {
                    cmb_Name.Items.Add(z);
                }
            }
        }

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CrewEntities DB = new CrewEntities())
            {
                var c = (from i in DB.Products where i.Product_Name == cmb_Name.Text select i).FirstOrDefault();

                if (c != null)
                {
                    tb_Name.Text = c.Product_Name;
                    tb_Selling.Text = c.Price.ToString();
                    tb_MCost.Text = "-";
                }
                else
                {
                    MessageBox.Show("Invalid Name");
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Catagory.SelectedIndex = -1;
            Refresh();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(tb_NewPrice.Text != "")
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    var c = (from i in DB.Products where i.Product_Name == cmb_Name.Text select i).FirstOrDefault();

                    if (c != null)
                    {
                        c.Price = Convert.ToDecimal(tb_NewPrice.Text);
                        DB.SaveChanges();
                    }
                }
                FillDGV();
                cmb_Catagory.SelectedIndex = -1;
                Refresh();
            }
            else
            {
                MessageBox.Show("Invalid Amount");
            }
        }
        private void dgv_EditPrices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgv_EditPrices.Rows[e.RowIndex].Cells[0].Value);

            using (CrewEntities DB = new CrewEntities())
            {
                var c = (from i in DB.Products where i.Product_ID == ID select i).FirstOrDefault();
                
                tb_Name.Text = c.Product_Name;
                tb_Selling.Text = c.Price.ToString();
                cmb_Catagory.Text = c.Catagory;
                cmb_Name.Text = c.Product_Name;
                tb_MCost.Text = "-";
            }
        }
    }
}
