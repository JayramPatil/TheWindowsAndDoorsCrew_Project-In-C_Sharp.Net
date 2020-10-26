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
        public frm_ManageOrders()
        {
            InitializeComponent();
        }
        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_UpdateOreder_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AcceptOrder(2));
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Cancel This Order ?", "WARNING",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void btn_AcceptMoney_Click(object sender, EventArgs e)
        {

        }
    }
}
