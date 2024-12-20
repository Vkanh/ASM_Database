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
    public partial class ManageEmployee : Form
    {
        int employeeId;
        string userPosition;
        int userId;
        string employeePosition;

        public ManageEmployee(string userPosition,  int userId)
        {
            this.employeeId = 0;
            this.userId = userId;
            InitializeComponent();
            this.userPosition = userPosition;
            InitializeCombobox();

        }
        public ManageEmployee()
        {
            InitializeComponent();

        }
       
        
        private bool ValidateData(string employeeCode,
                                  string employeeName,
                                  string employeePosition, 
                                  string authorityLeve1, 
                                  string username, 
                                  string password)
        {
            bool isValid = true;
            if (employeeCode == null || employeeCode == string.Empty)
            {
                MessageBox.Show(
                    "Employee Code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbEmployeeCode.Focus();
                isValid = false;
            }
            else if (employeeName == null || employeeName == string.Empty)
            {
                MessageBox.Show(
                    "Employee Name cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbEmployeeName.Focus();
                isValid = false;
            }
            else if (employeePosition == null || employeePosition == string.Empty)
            {
                MessageBox.Show(
                    "Employee Position cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbEmployeePosition.Focus();
                isValid = false;
            }
            else if (authorityLeve1 == null || authorityLeve1 == string.Empty)
            {
                MessageBox.Show(
                    "Employee Code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cbbAuthorityLeve1.Focus();
                isValid = false;
            }
            if (username == null || username == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbUsername.Focus();
                isValid = false;
            }
            if (password == null || password == string.Empty)
            {
                MessageBox.Show(
                    "Password cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbPassword.Focus();
                isValid = false;
            }
            return isValid;
        }

        private void ChangeButtonStatus(bool buttonStatus)
        {
            btUpdate.Enabled = buttonStatus;
            btDelete.Enabled = buttonStatus;
            btClear.Enabled = buttonStatus;
            btAdd.Enabled = !buttonStatus;
        }
        private void FlushEmployeeId()
        {
            this.employeeId = 0;
            ChangeButtonStatus(false);
        }
        private void LoadEmployeeData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT * FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgEmployee.DataSource = table;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushEmployeeId();
            tbEmployeeCode.Text = string.Empty;
            tbEmployeeName.Text = string.Empty;
            tbEmployeePosition.Text = string.Empty;
            cbbAuthorityLeve1.SelectedIndex = 0;
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbEmployeeName.Focus();
        }
        public void InitializeCombobox()
        {
            cbbAuthorityLeve1.Items.Add("Admin");
            cbbAuthorityLeve1.Items.Add("Warehosue Manager");
            cbbAuthorityLeve1.Items.Add("Sale");
            cbbAuthorityLeve1.SelectedIndex = 0;
        }
        private bool CheckUserExistence(int employeeId)
        {
            bool isExit = false;
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Employee WHERE EmployeeID = @employeeId ";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("employeeId", employeeId);
                SqlDataReader reader = command.ExecuteReader();
                isExit = reader.HasRows;
                connection.Close();
            }
            return isExit;
        }
        private void AddUser(string employeeCode,
                     string employeeName,
                     string employeePosition,
                     string authorityLeve1,
                     string username,
                     string password)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            
            if (connection != null)
            {
                connection.Open();
                string sql = @"INSERT INTO Employee 
                               (EmployeeCode, EmployeeName, Position, AuthorityLeve1, Username, Password, PasswordChanged) 
                               VALUES (@employeeCode, @employeeName, @employeePosition, @authorityLeve1, @username, @password, 0)";
                SqlCommand command = new SqlCommand(sql, connection);

                // Add parameters with explicit names
                command.Parameters.AddWithValue("@employeeCode", employeeCode);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@employeePosition", employeePosition);
                command.Parameters.AddWithValue("@authorityLeve1", authorityLeve1);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                // Execute query
                int result = command.ExecuteNonQuery();

                // Success or failure message
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully added new user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to add new user. Please check the input data.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }   
        }

        
        private void UpdateUser(int employeeId,
                                string employeeCode,
                                string employeeName,
                                string employeePosition,
                                string authorityLeve1,
                                string username,
                                string password)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "UPDATE Employee SET EmployeeCode = @employeeCode," +
                             "EmployeeName = @employeeName," +
                             "Position = @employeePosition," +
                             "AuthorityLeve1 = @authorityLeve1," +
                             "Username = @username," +
                             "Password = @password " +
                             "WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeCode", employeeCode);
                command.Parameters.AddWithValue("employeeName", employeeName);
                command.Parameters.AddWithValue("employeePosition", employeePosition);
                command.Parameters.AddWithValue("authorityLeve1", authorityLeve1);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);
                command.Parameters.AddWithValue("employeeId", employeeId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot update user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void DeleteUser(int employeeId)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "DELETE Employee WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeId", employeeId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully delete user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot delete user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }


        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadEmployeeData();
            }
            else
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    if (connection != null)
                    {
                        connection.Open();
                        string query = @"SELECT * FROM Employee 
                                 WHERE EmployeeCode LIKE @search 
                                 OR EmployeeName LIKE @search 
                                 OR Position LIKE @search 
                                 OR AuthorityLeve1 LIKE @search 
                                 OR Username LIKE @search 
                                 OR Password LIKE @search";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                        // Add parameter safely
                        SqlParameter param = new SqlParameter("@search", SqlDbType.NVarChar);
                        param.Value = "%" + search + "%";
                        adapter.SelectCommand.Parameters.Add(param);

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dtgEmployee.DataSource = table;
                    }
                }
            }
        }


        private void ManagerEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            ChangeButtonStatus(false);
            
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            string employeeCode = tbEmployeeCode.Text;
            string employeeName = tbEmployeeName.Text;
            string employeePosition = tbEmployeePosition.Text;
            string authorityLeve1 = cbbAuthorityLeve1.SelectedItem.ToString();
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            bool isValid = ValidateData(employeeCode,
                                        employeeName,
                                        employeePosition,
                                        authorityLeve1,
                                        username,
                                        password);
            if (isValid)
            {
                AddUser(employeeCode, employeeName, employeePosition, authorityLeve1, username, password);
            }
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {   
            string employeeCode = tbEmployeeCode.Text;
            string employeeName = tbEmployeeName.Text;
            string employeePosition = tbEmployeePosition.Text;
            string authorityLeve1 = cbbAuthorityLeve1.SelectedItem.ToString();
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            bool isValid = ValidateData(employeeCode,
                                        employeeName,
                                        employeePosition,
                                        authorityLeve1,
                                        username,
                                        password);
            if (isValid)
            {
                UpdateUser(employeeId, employeeCode, employeeName, employeePosition, authorityLeve1, username, password);
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        "Do you Want to delete this user",
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteUser(employeeId);
            }
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            AdminFrom adminFrom = new AdminFrom(employeePosition, employeeId);
            this.Hide();
            adminFrom.Show();
           
            
        }

        private void tbSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            string search = tbSearch.Text;
            SearchUser(search);
        }

        private void dtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgEmployee.CurrentCell.RowIndex;
            if (index != -1)
            {
                employeeId = Convert.ToInt32(dtgEmployee.Rows[index].Cells[0].Value);
                ChangeButtonStatus(true);
                tbEmployeeCode.Text = dtgEmployee.Rows[index].Cells[1].Value.ToString();
                tbEmployeeName.Text = dtgEmployee.Rows[index].Cells[2].Value.ToString();
                tbEmployeePosition.Text = dtgEmployee.Rows[index].Cells[3].Value.ToString();
                string authorityLeve1 = dtgEmployee.Rows[index].Cells[4].Value.ToString();
                if (authorityLeve1 == "Admin")
                {
                    cbbAuthorityLeve1.SelectedIndex = 0;
                }
                else if (authorityLeve1 == "Warehouse Manager")
                {
                    cbbAuthorityLeve1.SelectedIndex = 1;
                }
                else if (authorityLeve1 == "Sale")
                {
                    cbbAuthorityLeve1.SelectedIndex = 2;
                }
                tbUsername.Text = dtgEmployee.Rows[index].Cells[5].Value.ToString();
                tbPassword.Text = dtgEmployee.Rows[index].Cells[6].Value.ToString();
            }
        }






        private void tbPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {

        }

        private void gbManageEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void cbbAuthorityLeve1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
