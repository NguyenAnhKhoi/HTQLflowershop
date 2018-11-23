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
    public partial class ManSupplier : Form
    {
        SupplierBUS supBUS;
        List<Supplier> list;
        int privilege;
        public ManSupplier(int pri)
        {
            supBUS = new SupplierBUS();
            privilege = pri;
            InitializeComponent();
        }

        public void updateList()
        {
            list = supBUS.GetDetails();
            dgv.DataSource = list;
        }

        private void ManSupplier_Load(object sender, EventArgs e)
        {
            updateList();
            if (privilege >= 2)
                locking(true);
            else
                locking(false);
        }

        private void locking(bool enabled)
        {
            addBt.Enabled = enabled;
            dgv.Enabled = enabled;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            Supplier item = new Supplier(idTxt.Text, nameTxt.Text, int.Parse(PhoneTxt.Text),addrTxt.Text,webTxt.Text);
            try
            {
                int exec = supBUS.add(item);
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
                string str = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                supBUS.del(str);
                updateList();
            }
        }
    }
}
