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
    public partial class frm_AcceptOrder : Form
    {
        public frm_AcceptOrder()
        {
            InitializeComponent();
        }
        public frm_AcceptOrder(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Order";
            panel_NewOldCustomer.Enabled = false;
            groupBox1.Enabled = false;
            btn_Refresh.Text = "Reset";
            btn_UpdatePaymentDetails.Visible = true;
        }
        private void frm_AcceptOrder_Load(object sender, EventArgs e)
        {
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            rb_NewCustomer.Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            Form formBackground = new Form();
            try
            {
                using (frm_FinalAmount obj = new frm_FinalAmount())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    obj.Owner = formBackground;
                    obj.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void rb_OldCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_OldCustomer.Checked)
            {
                btn_Search.Visible = true;
                tb_Date.Enabled = false;
                tb_Name.Enabled = false;
                tb_Address.Enabled = false;
                tb_MobileNo.Enabled = false;
                
            }
            else
            {
                btn_Search.Visible = false;
                tb_Date.Enabled = true;
                tb_Name.Enabled = true;
                tb_Address.Enabled = true;
                tb_MobileNo.Enabled = true;
            }
        }
    }
}
