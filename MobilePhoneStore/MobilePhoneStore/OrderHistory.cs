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
    public partial class OrderHistory : Form
    {
        private int employeeId;
        private string authorityLeve1;

        public OrderHistory(string authorityLeve1, int employeeId)
        {
            InitializeComponent();
            RedirectPage();
        }
        private void LoadOrderHistory()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT o.OrderDate, " +
                    "e.EmployeeName, " +
                    "c.CustomerName," +
                    "FROM Orders o," +
                    "INNER JOIN Employee e ON o.EmployeeID = e.EmployeeID" +
                    "INNER JOIN Customer c ON o.CustomerID = c.CustomerID" +
                    "WHERE o.EmployeeID = @employeeId" +
                    "GROUP BY o.OrderDate, e.EmployeeName, e.EmployeeCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("employeeId", employeeId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgOrderHistory.DataSource = dataTable;
            }
        }

        private void RedirectPage()
        {
            switch (authorityLeve1)
            {

                case "Admin":
                    {
                        AdminFrom adminFrom = new AdminFrom(authorityLeve1, employeeId);
                        this.Hide();
                        adminFrom.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(authorityLeve1, employeeId);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(authorityLeve1, employeeId);
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

        private void CustomerHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void btBack_Click_1(object sender, EventArgs e)
        {
            RedirectPage();
        }
    }
}
