using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneStore
{
    public partial class SaleForm : Form
    {
        int employeeId;
        string authorityLeve1;
        public SaleForm(string authorityLeve1, int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLeve1 = authorityLeve1;
        }
        public SaleForm(int authorityLeve1, object employeeId)
        {
            InitializeComponent();
        }

        private void btManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer(authorityLeve1, employeeId);
            this.Hide();
            manageCustomer.Show();
        }

        private void btManageOrder_Click(object sender, EventArgs e)
        {
            OrderHistory orderHistory = new OrderHistory(this.authorityLeve1, this.employeeId);
            this.Hide();
            orderHistory.Show();
        }
    }
}
