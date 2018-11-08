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
            }
            else if (doorlock == DialogResult.Ignore)
                this.Close();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            ManEmployee manEm = new ManEmployee();
            manEm.Show();
            this.Enabled = false;
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            ManProduct manPro = new ManProduct();
            manPro.Show();
            this.Enabled = false;
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            ManSupplier manSup = new ManSupplier();
            manSup.Show();
            this.Enabled = false;
        }

        private void btOrderDetails_Click(object sender, EventArgs e)
        {
            ManOrderDetail manOrdDet = new ManOrderDetail();
            manOrdDet.Show();
            this.Enabled = false;
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            ManOrders manOrd = new ManOrders();
            manOrd.Show();
            this.Enabled = false;
        }
    }
}
