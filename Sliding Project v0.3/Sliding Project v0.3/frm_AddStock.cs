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
    public partial class frm_AddStock : Form
    {
        public frm_AddStock()
        {
            InitializeComponent();
        }
        public frm_AddStock(int i)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Stock";
            btn_Search.Visible = true;
            //groupBox1.Enabled = false;
            btn_Save.Text = "Update";
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (frm_AddMaterial obj = new frm_AddMaterial())
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
    }
}
