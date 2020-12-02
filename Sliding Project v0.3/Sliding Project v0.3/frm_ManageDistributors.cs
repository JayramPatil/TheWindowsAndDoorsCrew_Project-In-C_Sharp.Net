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
    public partial class frm_ManageDistributors : Form
    {
        int ID = 0;
        public frm_ManageDistributors()
        {
            InitializeComponent();
            using (CrewEntities DB = new CrewEntities())
            {
                dgv_ManageDistributor.DataSource = (from d in DB.Distributors select d).ToList();
            }
        }
        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddDistributor(ID));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddDistributor());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Delete This Distributor ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void dgv_ManageDistributor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgv_ManageDistributor.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
