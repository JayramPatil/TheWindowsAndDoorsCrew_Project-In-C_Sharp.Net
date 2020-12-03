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
    public partial class frm_AddEmployee : Form
    {
        public frm_AddEmployee()
        {
            InitializeComponent();
            ID();
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        public frm_AddEmployee(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Employee Details";
            btn_Search.Visible = true;
            btn_Save.Text = "Update";
        }
        public void ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int? id = DB.Employee_Details.Max(i => (int?)i.Employee_ID);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "100";
            }
        }
        private bool CheckFilled()
        {
            if(tb_ID.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "" && tb_AccountNo.Text != "" && tb_AdhaarNo.Text != "" && cmb_Qualification.Text != "" && cmb_Post.Text != "" && cmb_Experience.Text != "" && tb_Salary.Text != "" && rtb_Address.Text != "")
            {
                return true;
            }
            return false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(CheckFilled())
            {
                if(btn_Save.Text == "Save")
                {
                    DateTime dt = Convert.ToDateTime(tb_Date.Text);
                    string RB = "";
                    if(rb_Male.Checked)
                    {
                        RB = rb_Male.Text;
                    }
                    else
                    {
                        RB = rb_Female.Text;
                    }

                    using (CrewEntities DB = new CrewEntities())
                    {
                        DB.Employee_Details.Add(new Employee_Details { Name = tb_Name.Text, Mobile_No = tb_MobileNo.Text, Joining_Date = dt, DOB = dtp_DOB.Value.Date, Gender = RB, Address = rtb_Address.Text, Adhaar_No = tb_AdhaarNo.Text, Account_No = tb_AccountNo.Text, Qualification = cmb_Qualification.Text, Experience = cmb_Experience.Text});
                        DB.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Fields !!!");
            }
        }
    }
}
