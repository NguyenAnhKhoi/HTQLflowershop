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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTxt.Text == "admin" && passTxt.Text == "123")
            {
                openManagement();
                this.Close();
            }
            else if (String.IsNullOrEmpty(userTxt.Text) || String.IsNullOrEmpty(passTxt.Text))
                MessageBox.Show("Can nhap day du username va password!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("username hoac password khong chinh xac!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openManagement()
        {
            Management mng = new Management();
            mng.Show();
        }
    }
}
