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
    public partial class ManEmployee : Form
    {
        EmployeeBUS empBUS;
        List<Employee> list;
        int privil = 0;
        public ManEmployee(int pri)
        {
            empBUS = new EmployeeBUS();
            privil = pri;
            InitializeComponent();
        }

        public void updateList()
        {
            list = empBUS.GetEmployee();
            dgv.DataSource = list;
        }

        private void ManEmployee_Load(object sender, EventArgs e)
        {
            updateList();
            if (privil >= 2)
                locking(true);
            else
                locking(false);
        }

        private void locking(bool enabled)
        {
            addBt.Enabled = enabled;
            dgv.Enabled = enabled;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            Employee item = new Employee(idTxt.Text.Trim(), nameTxt.Text, accTxt.Text, passTxt.Text, int.Parse(priTxt.Text));
            try
            {
                int rows = empBUS.add(item);
                updateList();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgv.Columns[col] is DataGridViewButtonColumn && dgv.Columns[col].Name == "Delete")
            {
                string str = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                empBUS.del(str);
                updateList();
            }
        }
    }
}
