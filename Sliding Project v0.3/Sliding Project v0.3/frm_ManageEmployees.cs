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
    public partial class frm_ManageEmployees : Form
    {
        int Emp = 0;
        public frm_ManageEmployees()
        {
            InitializeComponent();
            Load_DGV();
        }
        public void Load_DGV()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                //dgv_ManageEmployee.DataSource = (from e in DB.Employee_Details select e).ToList();

                dgv_ManageEmployee.DataSource = (from e in DB.Employee_Details
                                                 join es in DB.Employee_Salary on e.Employee_ID equals es.Employee_ID
                                                 select new
                                                 {
                                                     e.Employee_ID,
                                                     e.Name,
                                                     e.Mobile_No,
                                                     e.Joining_Date,
                                                     e.DOB,
                                                     e.Gender,
                                                     e.Account_No,
                                                     e.Qualification,
                                                     e.Experience,
                                                     es.Post,
                                                     es.Salary
                                                 }).ToList();
            }
        }

        public void OpenForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddEmployee());
        }

        private void btn_UpdateEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_AddEmployee(Emp));
        }

        private void btn_RemoveEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Remove This Employee ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void dgv_ManageEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Emp = Convert.ToInt32(dgv_ManageEmployee.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
