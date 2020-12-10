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
    public partial class frm_ViewStockItems : Form
    {
        public frm_ViewStockItems()
        {
            InitializeComponent();

            using (CrewEntities DB = new CrewEntities())
            {
                dgv_ManageStock.DataSource = DB.Stocks.ToList();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddStock frm = new frm_AddStock();

            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
