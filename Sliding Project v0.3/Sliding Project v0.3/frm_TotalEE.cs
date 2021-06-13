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
    public partial class frm_TotalEE : Form
    {
        public frm_TotalEE()
        {
            InitializeComponent();

            using(CrewEntities DB = new CrewEntities())
            {
                tb_Earning.Text = (Convert.ToInt32(DB.Orders.Sum(d => d.Total))).ToString();

                tb_Expenditure.Text = (Convert.ToInt32(DB.Stock_Order.Sum(d => d.Total))).ToString();

                tb_Profit.Text = (Convert.ToInt32(tb_Earning.Text) - Convert.ToInt32(tb_Expenditure.Text)).ToString();
            }
        }
    }
}
