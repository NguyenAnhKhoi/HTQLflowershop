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
    public partial class ManOrders : Form
    {
        PaycheckBUS payBUS;
        List<Paycheck> pay;
        int privilege;
        public ManOrders(int pri)
        {
            payBUS = new PaycheckBUS();
            privilege = pri;
            InitializeComponent();
        }

        private void ManOrders_Load(object sender, EventArgs e)
        {
            updateList();
            if (privilege >= 2)
                locking(true);
            else
                locking(false);

            // AdjustColumnOrder();
        }

        private void updateList()
        {
            pay = payBUS.getPaycheck();
            dgv.DataSource = pay;
        }

        private void addBt_Click(object sender, EventArgs e)
        {

            string recId, cusName, empId, dateSol;
            float cost;

            recId = recIdTxt.Text.Trim();
            cusName = cusNameTxt.Text;
            dateSol = dateSoldDTP.Value.ToString();
            cost = float.Parse(costTxt.Text);
            empId = empIdTxt.Text;

            Paycheck item = new Paycheck(recId,cusName,cost,dateSol,empId);

            try
            {
                int rows = payBUS.addFull(item);
                updateList();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them san pham \n" + ex.Message, "Loi", MessageBoxButtons.OK);
                throw;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgv.Columns[col] is DataGridViewButtonColumn && dgv.Columns[col].Name == "Delete")
            {
                string str = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                payBUS.del(str);
                updateList();
            }
        }

        private void locking(bool enabled)
        {
            addBt.Enabled = enabled;
            dgv.Enabled = enabled;
        }

        /*  private void AdjustColumnOrder()
 {
     dgv.Columns["Mã HĐ"].DisplayIndex = 0;
     dgv.Columns["Ngày thanh toán"].DisplayIndex = 1;
     dgv.Columns["Tên KH"].DisplayIndex = 2;
     dgv.Columns["thàn"].DisplayIndex = 3;
     dgv.Columns["empId"].DisplayIndex = 4;
     dgv.Columns["Xóa"].DisplayIndex = 5;
 }*/
    }
}
