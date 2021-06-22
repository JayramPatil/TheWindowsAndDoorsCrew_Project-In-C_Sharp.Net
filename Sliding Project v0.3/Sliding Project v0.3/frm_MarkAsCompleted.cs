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
    public partial class frm_ManageOrders : Form
    {
        int ord = 0;
        public frm_ManageOrders()
        {
            InitializeComponent();
            using (CrewEntities DB = new CrewEntities())
            {
                dgv_ManageOrders.DataSource = DB.Orders.Select(d => new { d.Order_ID, d.Order_Date, d.Delivery_Date, d.Total, d.Paid_Amount, d.Remaining_Amount}).ToList();
            }
        }
        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_UpdateOreder_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AcceptOrder(ord));
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Cancel This Order ?", "WARNING",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void btn_AcceptMoney_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ManageOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ord = Convert.ToInt32(dgv_ManageOrders.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
