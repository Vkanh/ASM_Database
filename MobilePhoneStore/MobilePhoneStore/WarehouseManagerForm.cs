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
    public partial class WarehouseManagerForm : Form
    {
        int employeeId;
        string authorityLeve1;
        public WarehouseManagerForm(string authorityLeve1, int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLeve1 = authorityLeve1;
        }
        public WarehouseManagerForm(int authorityLeve1, object employeeId)
        {
            InitializeComponent();
        }

        private void btManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(this.authorityLeve1, this.employeeId);
            this.Hide();
            manageProduct.Show();
        }
    }
}
