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
    public partial class frm_AddUser : Form
    {
        int Cons = 0;
        public frm_AddUser()
        {
            InitializeComponent();
            ID();
        }
        public frm_AddUser(int i)
        {
            InitializeComponent();
            Cons = i;
            lbl_Header.Text = "Update User Details";
            btn_Add.Text = "Update";
            btn_Search.Visible = true;

            using (CrewEntities DB = new CrewEntities())
            {
                var User = DB.Users.Find(Cons);

                if (User != null)
                {
                    tb_ID.Text = Cons.ToString();
                    tb_Date.Text = User.Created_Date.ToString();
                    tb_Username.Text = User.Username;
                    tb_Password.Text = User.Password;
                    tb_ConfirmPassword.Text = User.Password;
                    tb_SequrityKey.Text = User.Security_Key;
                    cmb_TreatAs.Text = User.Treat_As;
                }

            }
        }
        public bool CheckFilled()
        {
            if(tb_ID.Text != "" && tb_Date.Text != "" && tb_Username.Text != "" && tb_Password.Text != "" && tb_ConfirmPassword.Text != "" && tb_SequrityKey.Text != "" && cmb_TreatAs.Text != "")
            {
                return true;
            }
            return false;
        }
        public void Refresh()
        {
            foreach (Control con in this.Controls)
            {
                foreach (Control con1 in con.Controls)
                {
                    foreach (Control con2 in con1.Controls)
                    {
                        if (con2.GetType() == typeof(TextBox))
                            con2.Text = "";
                    }
                }
            }
            cmb_TreatAs.SelectedIndex = -1;
            if (btn_Add.Text == "Add")
            {
                ID();
                tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }

        }
        public void ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int? id = DB.Users.Max(i => (int?)i.User_ID);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "1";
            }
        }
        private void frm_AddUser_Load(object sender, EventArgs e)
        {
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(CheckFilled())
            {
                using (CrewEntities DB = new CrewEntities())
                {
                    if (btn_Add.Text == "Add")
                    {
                        DateTime dt = Convert.ToDateTime(tb_Date.Text);
                        DB.Users.Add(new User { Created_Date = dt, Username = tb_Username.Text, Password = tb_Password.Text, Treat_As = cmb_TreatAs.Text, Security_Key = tb_SequrityKey.Text });
                        DB.SaveChanges();
                    }
                    else
                    {
                        var User = DB.Users.Find(Convert.ToInt32(tb_ID.Text));

                        if (User != null)
                        {
                            tb_ID.Text = Cons.ToString();
                            User.Created_Date = Convert.ToDateTime(tb_Date.Text);
                            User.Username = tb_Username.Text;
                            User.Password = tb_Password.Text;
                            User.Security_Key = tb_SequrityKey.Text;
                            User.Treat_As = cmb_TreatAs.Text;
                            DB.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Invalid User ID");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Feilds !!!");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int i = Convert.ToInt32(tb_ID.Text);
                var User = DB.Users.Find(i);

                if (User != null)
                {
                    tb_Date.Text = User.Created_Date.ToString("dd/MM/yyyy");
                    tb_Username.Text = User.Username;
                    tb_Password.Text = User.Password;
                    tb_ConfirmPassword.Text = User.Password;
                    tb_SequrityKey.Text = User.Security_Key;
                    cmb_TreatAs.Text = User.Treat_As;
                }
                else
                {
                    MessageBox.Show("Invalid User ID");
                }
            }
        }
    }
}
