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
    public partial class ManOrderDetail : Form
    {
        DetailsBUS detBUS;
        List<Details> list;
        int privilege = 0;
        public ManOrderDetail(int pri)
        {
            detBUS = new DetailsBUS();
            privilege = pri;
            InitializeComponent();
        }

        public void updateList()
        {
            list = detBUS.GetDetails();
            dgv.DataSource = list;
        }

        private void ManOrderDetail_Load(object sender, EventArgs e)
        {
            updateList();
            if (privilege >= 2)
                locking(true);
            else
                locking(false);
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            string name = Encoding.Unicode.GetString(Encoding.ASCII.GetBytes(proNameTxt.Text));
            float totalcost = float.Parse(priceTxt.Text) * float.Parse(amountTxt.Text);
            Details item = new Details(maHDTxt.Text, proIdTxt.Text, name, float.Parse(priceTxt.Text), int.Parse(amountTxt.Text), totalcost);
            try
            {
                int exec = detBUS.add(item);
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
                string str = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                detBUS.del(str);
                updateList();
            }
        }

        private void locking(bool enabled)
        {
            addBt.Enabled = enabled;
            dgv.Enabled = enabled;
        }
    }
}
