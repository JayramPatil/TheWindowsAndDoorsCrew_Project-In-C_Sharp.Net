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
    public partial class frm_FinalAmount : Form
    {
        static int flag = 1;
        string amount;
        public frm_FinalAmount(string Total, string Date)
        {
            InitializeComponent();
            tb_Total.Text = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100 + 1000).ToString();
            tb_DDate.Text = Date;
            amount = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100).ToString();
            cmb_Installation.SelectedIndex = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Installation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Installation.Text == "YES" && flag == 0)
            {
                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) + 1000).ToString();
                flag = 1;
            }
            else if(cmb_Installation.Text == "NO" && flag == 1)
            {
                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) - 1000).ToString();
                flag = 0;
            }
        }

        private void cmb_Discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = (flag == 1) ? 1000 : 0;
            tb_Total.Text = (Convert.ToInt32(amount) - Convert.ToInt32(amount) * Convert.ToInt32(cmb_Discount.Text.Remove(cmb_Discount.Text.Length-1)) / 100 + i).ToString();
        }

        private void tb_Total_TextChanged(object sender, EventArgs e)
        {
            tb_Advance.Text = (Convert.ToInt32(tb_Total.Text) * 30 / 100).ToString();

            tb_Remaining.Text = (Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(tb_Advance.Text)).ToString();

        }

        private void tb_Advance_TextChanged(object sender, EventArgs e)
        {
            string i = "0";
            if(tb_Advance.Text != "")
            {
                i = tb_Advance.Text;
            }
            
            tb_Remaining.Text = (Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(i)).ToString();
        }
    }
}
