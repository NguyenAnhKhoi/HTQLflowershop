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
    public partial class ManProduct : Form
    {
        ProductBUS proBUS;
        List<Product> list;
        int privilege = 0;
        public ManProduct(int pri)
        {
            proBUS = new ProductBUS();
            privilege = pri;
            InitializeComponent();
        }

        private void ManProduct_Load(object sender, EventArgs e)
        {
            updateList();
            if (privilege >= 2)
                locking(true);
            else
                locking(false);
        }

        private void updateList()
        {
            list = proBUS.getProduct();
            dgvPro.DataSource = list;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            string id, name, supId;
            float sell;

            id = idTxt.Text;
            name = nameTxt.Text;
            supId = proTxt.Text;
            sell = float.Parse(sellTxt.Text);

            Product item = new Product(id, name, sell, supId);

            try
            {
                int rows = proBUS.add(item);
                updateList();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them san pham \n" + ex.Message, "Loi", MessageBoxButtons.OK);
                throw;
            }
        }

        private void dgvPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgvPro.Columns[col] is DataGridViewButtonColumn && dgvPro.Columns[col].Name == "Delete")
            {
                string str = dgvPro.Rows[e.RowIndex].Cells[1].Value.ToString();
                proBUS.del(str);
                updateList();
            }
        }

        private void locking(bool enabled)
        {
            addBt.Enabled = enabled;
            dgvPro.Enabled = enabled;
        }
    }
}
