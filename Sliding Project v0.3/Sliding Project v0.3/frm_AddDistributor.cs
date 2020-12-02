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
    public partial class frm_AddDistributor : Form
    {
        int Dist = 0;
        public frm_AddDistributor()
        {
            InitializeComponent();
            ID();
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        public frm_AddDistributor(int i)
        {
            InitializeComponent();
            Dist = i;
            lbl_Header.Text = "Update Distributor Details";
            btn_Search.Visible = true;
            btn_Add.Text = "Update";

            CLB_Content();

            if(Dist != 0)
                Search(Dist);
        }
        public void Search(int ID)
        {
            rb_SelectDoor.Checked = true;
            rb_SelectWindow.Checked = true;
            rb_SelectOther.Checked = true;
            RadioButton(rb_SelectWindow.Text, clb_Window);
            RadioButton(rb_SelectOther.Text, clb_Other);
            RadioButton(rb_SelectDoor.Text, clb_Door);

            using (CrewEntities DB = new CrewEntities())
            {
                var i = DB.Distributors.Find(ID);

                tb_ID.Text = i.Distributor_ID.ToString();
                tb_Date.Text = i.Added_Date.ToString();
                tb_MobileNo.Text = i.Mobile_No;
                tb_Name.Text = i.Name;
                var Material = (from m in DB.Distributor_Material where m.Distributor_ID == ID select m.Material_Name).ToList();

                foreach (var item in Material)
                {
                    bool C = true;
                    if(C)
                    {
                        for (int j = 0; j < clb_Window.Items.Count; j++)
                        {
                            if (item == clb_Window.Items[j].ToString())
                            {
                                clb_Window.SetItemChecked(j, true);
                                C = false;
                                break;
                            }
                        }
                    }
                    if(C)
                    {
                        for (int j = 0; j < clb_Door.Items.Count; j++)
                        {
                            if (item == clb_Door.Items[j].ToString())
                            {
                                clb_Door.SetItemChecked(j, true);
                                C = false;
                                break;
                            }
                        }
                    }
                    if(C)
                    {
                        for (int j = 0; j < clb_Other.Items.Count; j++)
                        {
                            if (item == clb_Other.Items[j].ToString())
                            {
                                clb_Other.SetItemChecked(j, true);
                                C = false;
                                break;
                            }
                        }
                    }
  
                }
            }
        }
        public void ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                int? id = DB.Distributors.Max(i => (int?)i.Distributor_ID);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "100";
            }
        }
        private void CLB_Content()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                var Material = (from m in DB.Material_Info where m.Group_ID == 1 || m.Group_ID == 2 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    clb_Window.Items.Add(M);
                }

                Material = (from m in DB.Material_Info where m.Group_ID == 3 || m.Group_ID == 4 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    clb_Other.Items.Add(M);
                }
            }
        }
        private void frm_AddDistributor_Load(object sender, EventArgs e)
        {
            if(btn_Add.Text == "Add")
                CLB_Content();
        }
        private void RadioButton(string Name,CheckedListBox CLB)
        {
            if(Name == "All")
            {
                for (int i = 0; i < CLB.Items.Count; i++)
                {
                    CLB.SetItemChecked(i, true);
                }
                CLB.Enabled = false;
            }
            else if(Name == "None")
            {
                for (int i = 0; i < CLB.Items.Count; i++)
                {
                    CLB.SetItemChecked(i, false);
                }
                CLB.Enabled = false;
            }
            else
            {
                for (int i = 0; i < CLB.Items.Count; i++)
                {
                    CLB.SetItemChecked(i, false);
                }
                CLB.Enabled = true;
            }
        }
        private void rb_AllWindow_Click(object sender, EventArgs e)
        {
            RadioButton(rb_AllWindow.Text,clb_Window);
        }

        private void rb_NoneWindow_Click(object sender, EventArgs e)
        {
            RadioButton(rb_NoneWindow.Text, clb_Window);
        }

        private void rb_SelectWindow_Click(object sender, EventArgs e)
        {
            RadioButton(rb_SelectWindow.Text, clb_Window);
        }

        private void rb_AllDoor_Click(object sender, EventArgs e)
        {
            RadioButton(rb_AllDoor.Text, clb_Door);
        }

        private void rb_SelectDoor_Click(object sender, EventArgs e)
        {
            RadioButton(rb_SelectDoor.Text, clb_Door);
        }

        private void rb_NoneDoor_Click(object sender, EventArgs e)
        {
            RadioButton(rb_NoneDoor.Text, clb_Door);
        }

        private void rb_AllOther_Click(object sender, EventArgs e)
        {
            RadioButton(rb_AllOther.Text, clb_Other);
        }

        private void rb_SelectOther_Click(object sender, EventArgs e)
        {
            RadioButton(rb_SelectOther.Text, clb_Other);
        }

        private void rb_NoneOther_Click(object sender, EventArgs e)
        {
            RadioButton(rb_NoneOther.Text, clb_Other);
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            rb_AllDoor.Checked = true;
            rb_AllWindow.Checked = true;
            rb_AllOther.Checked = true;
            RadioButton(rb_AllWindow.Text, clb_Window);
            RadioButton(rb_AllOther.Text, clb_Other);
            RadioButton(rb_AllDoor.Text, clb_Door);
        }
        public bool CheckFilled()
        {
            if(tb_ID.Text != "" && tb_Date.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "")
            {
                return true;
            }
            return false;
        }
        public void InsertCLBitems(int ID)
        {
            using (CrewEntities DB = new CrewEntities())
            {
                if (rb_NoneWindow.Checked != true)
                {
                    for (int i = 0; i < clb_Window.Items.Count; i++)
                    {
                        if (clb_Window.GetItemCheckState(i) == CheckState.Checked)
                        {
                            DB.Distributor_Material.Add(new Distributor_Material { Distributor_ID = ID, Material_Name = clb_Window.Items[i].ToString() });
                        }
                    }
                }
                if (rb_NoneDoor.Checked != true)
                {
                    for (int i = 0; i < clb_Door.Items.Count; i++)
                    {
                        if (clb_Door.GetItemCheckState(i) == CheckState.Checked)
                        {
                            DB.Distributor_Material.Add(new Distributor_Material { Distributor_ID = ID, Material_Name = clb_Door.Items[i].ToString() });
                        }
                    }
                }
                if (rb_NoneOther.Checked != true)
                {
                    for (int i = 0; i < clb_Other.Items.Count; i++)
                    {
                        if (clb_Other.GetItemCheckState(i) == CheckState.Checked)
                        {
                            DB.Distributor_Material.Add(new Distributor_Material { Distributor_ID = ID, Material_Name = clb_Other.Items[i].ToString() });
                        }
                    }
                }
                DB.SaveChanges();
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(CheckFilled())
            {
                if(btn_Add.Text == "Add")
                {
                    using (CrewEntities DB = new CrewEntities())
                    {
                        DateTime dt = Convert.ToDateTime(tb_Date.Text);
                        DB.Distributors.Add(new Distributor { Name = tb_Name.Text, Added_Date = dt, Mobile_No = tb_MobileNo.Text });
                        DB.SaveChanges();
                        InsertCLBitems(Convert.ToInt32(tb_ID.Text)); 
                    }
                }
                else
                {
                    using(CrewEntities DB = new CrewEntities())
                    {
                        int id = Convert.ToInt32(tb_ID.Text);
                        var DistMat = DB.Distributors.Find(id);

                        DistMat.Name = tb_Name.Text;
                        DistMat.Mobile_No = tb_MobileNo.Text;

                        DB.Distributor_Material.RemoveRange(DB.Distributor_Material.Where(dm => dm.Distributor_ID == id));
                        DB.SaveChanges();

                        InsertCLBitems(id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Feilds !!!");
            }
        }

        public void Refresh()
        {
            foreach (Control con in this.Controls)
            {
                foreach (Control con1 in con.Controls)
                {
                    foreach (Control con2 in con1.Controls)
                    {
                        if(con2.GetType() == typeof(TextBox))
                        {
                            con2.Text = "";
                        }
                    }
                }
            }
            rb_NoneDoor.Checked = true;
            rb_NoneWindow.Checked = true;
            rb_NoneOther.Checked = true;
            RadioButton(rb_NoneWindow.Text, clb_Window);
            RadioButton(rb_NoneOther.Text, clb_Other);
            RadioButton(rb_NoneDoor.Text, clb_Door);

            if (btn_Add.Text == "Add")
            {
                ID();
                tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(tb_ID.Text));
        }
    }
}
