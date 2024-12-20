using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneStore
{
    public partial class ManageCustomer : Form
    {
        private int customerId;
        private int categoryId;
        private int employeeId;
        private string authorityLeve1;
        private int userId;

        public ManageCustomer(string authorityLeve1, int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLeve1 = authorityLeve1;
        }
        public ManageCustomer()
        {
            InitializeComponent();
        }
        private void ChangeButtonStatus(bool butonStatus)
        {
            btUpdate.Enabled = butonStatus;
            btDelete.Enabled = butonStatus;
            btClear.Enabled = butonStatus;
            btAdd.Enabled = !butonStatus;
        }
        private bool ValidateData(string customerCode,
                               string customerName,
                               string customerAddress,
                               string phonenumber)
        {
            bool isValid = true;
            if (customerCode == null || customerCode == string.Empty)
            {
                MessageBox.Show(
                    "Customer Code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbCustomerCode.Focus();
                isValid = false;
            }
            else if (customerName == null || customerName == string.Empty)
            {
                MessageBox.Show(
                    "Customer Name cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbCustomerName.Focus();
                isValid = false;
            }
            else if (customerAddress == null || customerAddress == string.Empty)
            {
                MessageBox.Show(
                    "Customer Address cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbCustomerAddress.Focus();
                isValid = false;
            }
            else if (phonenumber == null || phonenumber == string.Empty)
            {
                MessageBox.Show(
                    "Phonenumber cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbPhonenumber.Focus();
                isValid = false;
            }
            return isValid;
        }
        private void FlushCustomerId()
        {
            this.customerId = 0;
            ChangeButtonStatus(false);
        }
        private void LoadCustomerData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgCustomer.DataSource = table;
                connection.Close();
            }
        }

        private bool CheckUserExistence(int customerId)
        {
            bool isExit = false;
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Customer WHERE CustomerID = @customerId ";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                SqlDataReader reader = command.ExecuteReader();
                isExit = reader.HasRows;
                connection.Close();
            }
            return isExit;
        }

        private void ClearData()
        {
            tbCustomerCode.Text = string.Empty;
            tbCustomerName.Text = string.Empty;
            tbCustomerAddress.Text = string.Empty;
            tbPhonenumber.Text = string.Empty;
            tbSearch.Text = string.Empty;
        }
        private void AddCustomer(string customerCode,
                             string customerName,
                             string customerAddress,
                             string phoneNumber)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "INSERT INTO Customer VALUES (@customerCode, @customerName, @phonenumber, @customerAddress)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode);
                command.Parameters.AddWithValue("customerName", customerName);
                command.Parameters.AddWithValue("phonenumber", phoneNumber);
                command.Parameters.AddWithValue("customerAddress", customerAddress);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully and new customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "An errer occur while adding customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }

        private void updateCustomer(string customerCode,
                             int customerId,
                             string customerName,
                             string customerAddress,
                             string phoneNumber)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "UPDATE Customer SET CustomerCode = @customerCode," +
                             "CustomerName = @customerName," +
                             "Address = @customerAddress," +
                             "Phonenumber = @phonenumber";                     
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode);
                command.Parameters.AddWithValue("customerName", customerName);
                command.Parameters.AddWithValue("phonenumber", phoneNumber);
                command.Parameters.AddWithValue("customerAddress", customerAddress);
                command.Parameters.AddWithValue("customerId", customerId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "An errer occur while updating customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }
        private void DeleteCustomer(int customerId)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string deleteOrderDetailQuery = "DELETE OrderDetail WHERE OrderDetailID IN" +
                    "(SELECT OrderID FROM Orders WHERE CustomerID = @customerId)";
                SqlCommand command = new SqlCommand(deleteOrderDetailQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                command.ExecuteNonQuery();
                string deleteOrderQuery = "DELETE Orders WHERE CustomerID = @customerId";
                command = new SqlCommand(deleteOrderQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                command.ExecuteNonQuery();
                string deleteCustomerQuery = "DELETE Customer WHERE CustomerID = @customerId";
                command = new SqlCommand(deleteCustomerQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                int deleteCustomerResult = command.ExecuteNonQuery();
                if (deleteCustomerResult > 0)
                {
                    MessageBox.Show(
                        "Successfully delete customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "An errer occur while deteting customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }

        private void SearchCustomer(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadCustomerData();
            }
            else
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Customer WHERE CustomerCode LIKE @search OR CustomerName LIKE @search OR Phonenumber LIKE @search OR Address LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgCustomer.DataSource = table;
                    connection.Close();
                }
            }
        }
        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }


        private void tbSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            string search = tbSearch.Text;
            SearchCustomer(search);

        }
      
        private void btAdd_Click_1(object sender, EventArgs e)
        {
            string customerCode = tbCustomerCode.Text;
            string customerName = tbCustomerName.Text;
            string customerAddress = tbCustomerAddress.Text;
            string phoneNumber = tbPhonenumber.Text;
            bool isValid = ValidateData(customerCode, customerName, customerAddress, phoneNumber);
            if (isValid)
            {
                AddCustomer(customerCode, customerName, customerAddress, phoneNumber);
            }
        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            if (customerId > 0)
            {
                bool isUserExist = CheckUserExistence(customerId);
                if (isUserExist)
                {
                    string customerCode = tbCustomerCode.Text;
                    string customerName = tbCustomerName.Text;
                    string customerAddress = tbCustomerAddress.Text;
                    string phoneNumber = tbPhonenumber.Text;
                    bool isValid = ValidateData(customerCode, customerName, customerAddress, phoneNumber);
                    if (isValid)
                    {
                        updateCustomer(customerCode, customerId, customerName, customerAddress, phoneNumber);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No customer found",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (customerId > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Do you want Delete this customer with all related data?",
                    "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bool isUserExist = CheckUserExistence(customerId);
                    if (isUserExist)
                    {
                        DeleteCustomer(customerId);
                    }
                    else
                    {
                        MessageBox.Show(
                            "No customer found",
                            "Error",
                            MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btClear_Click_1(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btBack_Click_1(object sender, EventArgs e)
        {
            switch (authorityLeve1)
            {

                case "Admin":
                    {
                        AdminFrom adminFrom = new AdminFrom(this.authorityLeve1, this.userId);
                        this.Hide();
                        adminFrom.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.authorityLeve1, this.userId);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(this.authorityLeve1, this.userId);
                        this.Hide();
                        saleForm.Show();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void dtgCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)dtgCustomer.Rows[index].Cells[0].Value;
                tbCustomerCode.Text = dtgCustomer.Rows[index].Cells[1].Value.ToString();
                tbCustomerName.Text = dtgCustomer.Rows[index].Cells[2].Value.ToString();
                tbPhonenumber.Text = dtgCustomer.Rows[index].Cells[3].Value.ToString();
                tbCustomerAddress.Text = dtgCustomer.Rows[index].Cells[4].Value.ToString();
                ChangeButtonStatus(true);
            }
        }

        private void dtgCustomer_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)dtgCustomer.Rows[index].Cells[0].Value;
                string customerName = dtgCustomer.Rows[index].Cells[2].Value.ToString();
                Order order = new Order(customerId, employeeId, customerName);
                order.ShowDialog();
            }
        }
    }
}
    

