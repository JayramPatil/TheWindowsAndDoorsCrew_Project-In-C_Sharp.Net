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
    public partial class frm_ManageCustomers : Form
    {
        public frm_ManageCustomers()
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
            OpenForm(new frm_AddCustomer(1));
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Delete This Customer ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddCustomer());
        }

        private void frm_ManageCustomers_Load(object sender, EventArgs e)
        {
            using(CrewEntities DB = new CrewEntities())
            {
                //dgv_ManageCustomer.AutoGenerateColumns = false;
                dgv_ManageCustomer.DataSource = (from c in DB.Customers select c).ToList();

            }          
        }
    }
}
