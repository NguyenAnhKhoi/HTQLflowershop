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
    public partial class Management : Form
    {
        int pri = 0;

        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            DialogResult doorlock = log.ShowDialog();
            if (doorlock == DialogResult.OK)
            {
                this.Enabled = true;
                pri = log.getAllow();
                label2.Text = pri.ToString();
            }
            else if (doorlock == DialogResult.Ignore)
                this.Close();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            ManEmployee manEm = new ManEmployee();
            manEm.ShowDialog();
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            ManProduct manPro = new ManProduct(pri);
            manPro.ShowDialog();
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            ManSupplier manSup = new ManSupplier();
            manSup.ShowDialog();
        }

        private void btOrderDetails_Click(object sender, EventArgs e)
        {
            ManOrderDetail manOrdDet = new ManOrderDetail(pri);
            manOrdDet.ShowDialog();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            ManOrders manOrd = new ManOrders(pri);
            manOrd.ShowDialog();
        }
    }
}
