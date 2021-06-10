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
        MDI_Home md = new MDI_Home();
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

            if (i != 0)
                Search(i);
        }
        public void Search(int ID)
        {
            using(CrewEntities DB = new CrewEntities())
            {
                var Employee = DB.Employee_Details.Find(ID);

                if(Employee != null)
                {
                    var EmpSal = DB.Employee_Salary.Find(ID);

                    if (Employee.Gender == "MALE")
                    {
                        rb_Male.Checked = true;
                    }
                    else
                    {
                        rb_Female.Checked = true;
                    }

                    tb_ID.Text = Employee.Employee_ID.ToString();
                    tb_Date.Text = Employee.Joining_Date.ToString("dd/MM/yyyy");
                    tb_Name.Text = Employee.Name;
                    tb_MobileNo.Text = Employee.Mobile_No;
                    tb_AccountNo.Text = Employee.Account_No;
                    tb_AdhaarNo.Text = Employee.Adhaar_No;
                    cmb_Qualification.Text = Employee.Qualification;
                    cmb_Post.Text = EmpSal.Post;
                    cmb_Experience.Text = Employee.Experience;
                    tb_Salary.Text = EmpSal.Salary.ToString();
                    rtb_Address.Text = Employee.Address;
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID");
                }
            }
        }
        public void Refresh()
        {
            tb_ID.Text = "";
            tb_Date.Text = "";
            tb_Name.Text = "";
            tb_MobileNo.Text = "";
            tb_AccountNo.Text = "";
            tb_AdhaarNo.Text = "";
            cmb_Qualification.Text = "";
            cmb_Post.Text = "";
            cmb_Experience.Text = "";
            tb_Salary.Text = "";
            rtb_Address.Text = "";

            if(btn_Save.Text == "Save")
            {
                ID();
                tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
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
                        int i = Convert.ToInt32(tb_ID.Text);
                        Decimal sal = Convert.ToInt32(tb_Salary.Text);

                        DB.Employee_Details.Add(new Employee_Details { Name = tb_Name.Text, Mobile_No = tb_MobileNo.Text, Joining_Date = dt, DOB = dtp_DOB.Value.Date, Gender = RB, Address = rtb_Address.Text, Adhaar_No = tb_AdhaarNo.Text, Account_No = tb_AccountNo.Text, Qualification = cmb_Qualification.Text, Experience = cmb_Experience.Text});
                        DB.SaveChanges();
                        
                        DB.Employee_Salary.Add(new Employee_Salary { Employee_ID = i, Post = cmb_Post.Text, Salary = sal, Pending_Salary = 0, Last_Paid = dt});
                        DB.SaveChanges();

                        MessageBox.Show("Employee Added Successfully");
                    }
                }
                else
                {
                    using (CrewEntities DB = new CrewEntities())
                    {
                        var Emp = DB.Employee_Details.Find(Convert.ToInt32(tb_ID.Text));

                        if(Emp != null)
                        {
                            var EmpS = DB.Employee_Salary.Find(Convert.ToInt32(tb_ID.Text));

                            string RB = "";
                            if (rb_Male.Checked)
                            {
                                RB = rb_Male.Text;
                            }
                            else
                            {
                                RB = rb_Female.Text;
                            }

                            Emp.Name = tb_Name.Text;
                            Emp.Mobile_No = tb_MobileNo.Text;
                            Emp.DOB = dtp_DOB.Value;
                            Emp.Gender = RB;
                            Emp.Account_No = tb_AccountNo.Text;
                            Emp.Adhaar_No = tb_AdhaarNo.Text;
                            Emp.Qualification = cmb_Qualification.Text;
                            EmpS.Post = cmb_Post.Text;
                            Emp.Experience = cmb_Experience.Text;
                            EmpS.Salary = Convert.ToDecimal(tb_Salary.Text);
                            Emp.Address = rtb_Address.Text;
                        }
                        DB.SaveChanges();

                        MessageBox.Show("Employee Details Updated Successfully");

                        this.Close();
                        md.OpenForm(new frm_ManageEmployees());
                      
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Fields !!!");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(tb_ID.Text));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
