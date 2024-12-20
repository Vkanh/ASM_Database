using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneStore
{
    internal class DatabaseConnection
    {
        private static string connectionString = "Data Source=LAPTOP-1MBKQE1D\\SQLEXPRESS;"+
                                                    "Initial Catalog=MobilePhoneStore;" +
                                                    "Integrated Security=True;" ;
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error while connecting to the database",
                    "Warring",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            return connection;
        }
    }
}
