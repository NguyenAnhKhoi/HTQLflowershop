using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQL
{
    public partial class HoaDon : Form
    {
        int[] flowery = new int[4];
        public HoaDon(int[] flows)
        {
            flowery = flows;
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
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            flo1.Text = flowery[0].ToString();
            flo2.Text = flowery[1].ToString();
            flo3.Text = flowery[2].ToString();
            flo4.Text = flowery[3].ToString();
        }
    }
}
