using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobilePhoneStore
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }
        public void InitializeCombobox()
        {
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Warehouse Manager");
            cbRole.Items.Add("Sale");
            cbRole.SelectionLength = 0;
        }
        private bool ValidateData(string username, string password, string role)
        {
            bool isValid = true;
            if (username == null || username == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be Black",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                tbUsername.Focus();
            }
            else if (password == null || password == string.Empty)
            {
                MessageBox.Show(
                    "Password cannot be black",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                tbPassword.Focus();
            }
            else if (role == null || role == string.Empty)
            {
                MessageBox.Show(
                    "No role selected",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                cbRole.Focus();
            }
            return isValid;
        }
       
        private void RedirectPage (string selectedRole, int employeeId)
        {
            if (selectedRole != null)
            {
                if (selectedRole == "Admin")
                {
                    AdminFrom adminFrom = new AdminFrom(selectedRole, employeeId);
                    this.Hide();
                    adminFrom.Show();
                }
                else if ((selectedRole =="Warehouse Manager"))
                {
                    WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(selectedRole, employeeId);
                    this.Hide();
                    warehouseManagerForm.Show();
                }
                else if( selectedRole == "Sale")
                {
                    SaleForm saleForm= new SaleForm(selectedRole, employeeId);
                    this.Hide();
                    saleForm.Show();
                }
            }
        }
        private void ClearData()
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            cbRole.SelectedIndex = 0;
            cbRole.Focus();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            var role  = cbRole.SelectedItem.ToString(); 
            bool isValid = ValidateData(username, password, role);
            if (isValid)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    string query = "SELECT EmployeeId, PasswordChanged FROM Employee WHERE Username = @username" +
                                   " AND Password = @password AND AuthorityLeve1 = @role";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("username",username);
                    command.Parameters.AddWithValue("password",password);
                    command.Parameters.AddWithValue("role", role);
                    SqlDataReader reader = command.ExecuteReader();
                    int employeeId= 0;
                    while (reader.Read())
                    {
                        employeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId"));
                    }
                    if (employeeId > 0)
                    {
                        MessageBox.Show(
                            "Login success",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        RedirectPage(role, employeeId);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid Login credential",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        ClearData();
                    }
                    connection.Close();
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
