using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace HTQL
{
    public partial class HoaDon : Form
    {
        int[] flowery = new int[12];
        string[] flowList = new string[12] {"Hoa huong duong", "Hoa gao", "Hoa bong giay", "Hoa bong gon", "Hoa phuong", "Dam but", "Da lan", "Phuong tim", "Bang lang", "Mai vang", "Hoa diep", "Hoa dao hong" };
        ProductBUS proBus;
        PaycheckBUS payBUS;
        DetailsBUS detBUS;
        List<receipt> listPrice;
        List<Product> listPro;
        float totalPrice;
        public HoaDon(int[] flows)
        {
            flowery = flows;
            proBus = new ProductBUS();
            payBUS = new PaycheckBUS();
            detBUS = new DetailsBUS();
            listPrice = proBus.getPrice();
            listPro = proBus.getProduct();
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTxt.Text) || String.IsNullOrEmpty(adrTxt.Text) || String.IsNullOrEmpty(phnNumTxt.Text))
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult confirm = MessageBox.Show("Xác nhận gửi hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                    addRec();
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (flowery[i] > 0)
                {
                    ListViewItem item = new ListViewItem(flowList[i]);
                    float cost = listPrice[i].cost * flowery[i];
                    totalPrice += cost;
                    item.SubItems.Add(flowery[i].ToString());
                    item.SubItems.Add(cost.ToString());

                    listHoaDon.Items.Add(item);

                    totalTxt.Text = "Tổng số tiền: " + totalPrice.ToString();
                }
            }
        }

        private void addRec()
        {
            string cusName = nameTxt.Text;
            string proName, proID;
            int id = int.Parse(listPrice[listPrice.Count() - 1].reID.Remove(0, 2)) + 1;
            int amount;
            float cost = totalPrice;
            float price, toCost;

            Paycheck pay = new Paycheck("HD" + id.ToString(), cusName, cost);

            try
            {
                int rows = payBUS.add(pay);
                for (int i = 0; i < 12; i++)
                {
                    if (flowery[i] > 0)
                    {
                        proID = listPro[i].ProductId;
                        proName = flowList[i];
                        amount = flowery[i];
                        price = listPrice[i].cost;
                        toCost = listPrice[i].cost * flowery[i];
                        Details item = new Details("HD" + id.ToString(),proID,proName,price,amount,cost);
                        int detrows = detBUS.add(item);
                    }

                }
                DialogResult done = MessageBox.Show("Gửi hóa đơn thành công!", "Success", MessageBoxButtons.OK);
                if (done == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.None;
                    this.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
