using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace HTQL
{
    public partial class Menu : Form
    {
        int cntItem = 0;
        string path = Application.StartupPath + @"\Images\";
        private int[] flowers = new int[4];
        public int[] getFlower()
        {
            return flowers;
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void statBtClick(string id)
        {
            var find = this.Controls.Find(("lbStatusId" + id.ToString()), true).FirstOrDefault();
            find.Text = Convert.ToString(Convert.ToInt32(find.Text) + 1);
        }

        private void btAddId_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string id = bt.Name.ToString().Remove(0, bt.Name.ToString().Length - 1);
            var find = this.Controls.Find("lbStatusId" + id.ToString(), true).FirstOrDefault();
            find.Text = Convert.ToString(Convert.ToInt32(find.Text) + 1);
            flowers[Convert.ToInt32(id)-1]++;
            cntItem++;
            checkTotal();
        }

        private void btSubId_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string id = bt.Name.ToString().Remove(0, bt.Name.ToString().Length - 1);
            var find = this.Controls.Find(("lbStatusId" + id.ToString()), true).FirstOrDefault();
            find.Text = Convert.ToString(Convert.ToInt32(find.Text) - 1);
            flowers[Convert.ToInt32(id)-1]--;
            cntItem--;
            checkTotal();
        }

        private void checkStat(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            string id = lb.Name.ToString().Remove(0, lb.Name.ToString().Length - 1);
            var find = this.Controls.Find(("btSubId") + id.ToString(), true).FirstOrDefault();
            if (Convert.ToInt32(lb.Text) <= 0)
                find.Visible = false;
            else
                find.Visible = true;
        }

        private void checkTotal()
        {
            if (cntItem <= 0)
            {
                itemCountLb.Text = "Giỏ hàng trống";
                orderBt.Image = Image.FromFile(path + "order.png");
                orderBt.Enabled = false;
            }
            else
            {
                itemCountLb.Text = "Đã chọn " + cntItem.ToString() + " sản phẩm";
                orderBt.Image = Image.FromFile(path + "orderON.png");
                orderBt.Enabled = true;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            orderBt.Image = Image.FromFile(path + "order.png");
        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(flowers);
            hd.Show();
        }

        private void adminLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Management mng = new Management();
            mng.Show();
        }
    }
}
