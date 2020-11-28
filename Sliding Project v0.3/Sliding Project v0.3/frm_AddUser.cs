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
        public frm_AddUser()
        {
            InitializeComponent();
        }
        public frm_AddUser(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update User Details";
            btn_Add.Text = "Update";
            btn_Search.Visible = true;
        }

        private void frm_AddUser_Load(object sender, EventArgs e)
        {
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using(CrewEntities DB = new CrewEntities())
            {
                DateTime dt = Convert.ToDateTime(tb_Date.Text);
                DB.Users.Add(new User { Created_Date = dt, Username = tb_Username.Text, Password = tb_Password.Text, Treat_As = cmb_TreatAs.Text, Security_Key = tb_SequrityKey.Text });
                DB.SaveChanges();
            }
        }
    }
}
