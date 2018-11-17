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
    public partial class Login : Form
    {
        LoginBUS lgb;
        public Login()
        {
            InitializeComponent();
            lgb = new LoginBUS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account acc = new Account(userTxt.Text, passTxt.Text);
            bool access = lgb.Login(acc);
            if (access == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (String.IsNullOrEmpty(userTxt.Text) || String.IsNullOrEmpty(passTxt.Text))
                MessageBox.Show("Can nhap day du username va password!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("username hoac password khong chinh xac!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }

        private void openManagement()
        {
            Management mng = new Management();
            mng.Show();
        }

        /*private bool loginProc(string userName, string password)
        {
            string cnstring = @"Server = 8ZKOCVAMSQYRGRY\SQLEXPRESS; Database = FlowerShop; Integrated Security = true;";
            SqlConnection connect = new SqlConnection(cnstring);
            string cmdstring = "SELECT COUNT(*) FROM Employee WHERE TaiKhoan = '" + userName + "' AND MatKhau = '" + password + "'";
            SqlCommand cmd = new SqlCommand(cmdstring, connect);
            cmd.CommandType = CommandType.Text;
            connect.Open();

            try
            {
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                connect.Close();
            }
        }*/
    }
}
