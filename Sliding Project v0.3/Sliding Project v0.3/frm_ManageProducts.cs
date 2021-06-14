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
    public partial class frm_ManageProducts : Form
    {
        int PID = 0;
        public frm_ManageProducts()
        {
            InitializeComponent();
        }
        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddProduct(PID));
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Delete This Product ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Change This Products Availability ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        private void dgv_ManageProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PID = Convert.ToInt32(dgv_ManageProduct.Rows[e.RowIndex].Cells[0].Value);
        }

        private void frm_ManageProducts_Load(object sender, EventArgs e)
        {
            using (CrewEntities DB = new CrewEntities())
            {
                dgv_ManageProduct.DataSource = (from p in DB.Products select new { p.Product_ID, p.Product_Name, p.Catagory, p.Price, p.Time_To_Build, p.Description, p.Track }).ToList();
            }
        }
    }
}
