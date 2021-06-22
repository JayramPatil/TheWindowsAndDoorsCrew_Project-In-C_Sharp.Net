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
    public partial class frm_ViewStock : Form
    {
        public frm_ViewStock()
        {
            InitializeComponent();

            using (CrewEntities DB = new CrewEntities())
            {
                dgv_ManageOrders.DataSource = (from s in DB.Stock_Order select new { s.Order_ID, s.Distributor_Name, s.Date, s.Paid_Amount, s.Remaining_Amount, s.Total}).ToList();
            }
        }
        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddStock());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddStock(OrderID));
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Delete This Order ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        int OrderID = 0;
        private void dgv_ManageOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderID = Convert.ToInt32(dgv_ManageOrders.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}