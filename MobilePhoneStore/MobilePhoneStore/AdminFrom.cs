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
    public partial class AdminFrom : Form
    {
        int employeeId;
        string authorityLeve1;
        public AdminFrom(string authorityLeve1,int employeeId)
        {
            InitializeComponent();
            
            this.authorityLeve1 = authorityLeve1;
            this.employeeId = employeeId;
        }
        public AdminFrom(int authorityLeve1, object employeeId)
        {
            InitializeComponent();
        }

        private void btManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee(this.authorityLeve1, this.employeeId);
            this.Hide();
            manageEmployee.Show();
        }

        private void btManageProduct_Click(object sender, EventArgs e)
        { 
            ManageProduct manageProduct = new ManageProduct(this.authorityLeve1 , this.employeeId);
            this.Hide();
            manageProduct.Show();
        }

        private void btManageCustomer_Click_1(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer(this.authorityLeve1, this.employeeId);
            this.Hide();
            manageCustomer.Show();
        }

        private void btManageOrder_Click(object sender, EventArgs e)
        {
            OrderHistory orderHistory = new OrderHistory(this.authorityLeve1, this.employeeId);
            this.Hide();
            orderHistory.Show();
        }

        private void btManageImport_Click(object sender, EventArgs e)
        {

        }

        private void btViewStatistic_Click(object sender, EventArgs e)
        {

        } 
    }
}
