using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneStore
{
    public partial class ManageProduct : Form
    {
        private int productId;
        private string authorityLeve1;
        private int userId;
        private int employeeId;

        public ManageProduct( string authorityLeve1, int userId)
        {
            this.authorityLeve1 = authorityLeve1;
            this.userId = userId;
            productId = 0;
            InitializeComponent();
            LoadCategoryCombobox();
        }


        private void LoadCategoryCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null )
            {
                connection.Open();
                string query = "SELECT CategoryID, CategoryName FROM Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
            }
        }
        private bool ValidateData(String productCode, 
            String productName,
            String productPrice,
            String productQuantity)
        {
            double temp;
            int temp2;
            if (String.IsNullOrEmpty(productName)) { return false; }
            if (String.IsNullOrEmpty(productPrice)) {  return false; }
            if (!double.TryParse(productPrice, out temp)) { return false; }
            if (String.IsNullOrEmpty(productQuantity)) {  return false; }
            return int .TryParse(productQuantity, out temp2);
        }
      
        
        private void LoadProductData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT * FROM Product";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgProduct.DataSource = dataTable;
                connection.Close();
            }
        }

        private void ClearData()
        {
            FlushProductId();
            tbProductCode.Text = string.Empty;
            tbProductName.Text = string.Empty;
            tbProductPrice.Text = string.Empty;
            tbProductQuantity.Text = string.Empty;
            tbSearch.Text = string.Empty;
        }
        
        private void ChangeButtonStatus(bool buttonStatus)
        {
            btDelete.Enabled = buttonStatus;
            btClear.Enabled = buttonStatus;
            btAdd.Enabled = !buttonStatus;
        }

        private void FlushProductId()
        {
            this.productId = 0;
            ChangeButtonStatus(false);
        }

       



        private void AddProduct()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = tbProductCode.Text;
                string productName = tbProductName.Text;
                string price = tbProductPrice.Text;
                string quantity = tbProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                if(ValidateData(productCode, productName, price, quantity))
                {
                    string sql = "INSERT INTO Product (ProductCode, ProductName, Price, InventoryQuantity, CategoryID) " +
                                 "VALUES (@productCode, @productName, @productPrice, @productQuantity, @categoryId)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("productCode", productCode);
                    command.Parameters.AddWithValue("productName", productName);
                    command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("categoryId", categoryId);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully and new product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot add new Product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
                
            }
        }

        private void UpdateProduct()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    string productCode = tbProductCode.Text;
                    string productName = tbProductName.Text;
                    string price = tbProductPrice.Text;
                    string quantity = tbProductQuantity.Text;
                    int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                    string sql = "UPDATE Product SET ProductCode = @productCode," +
                                 "ProductName = @productName," +
                                 "Price = @productPrice," +
                                 "InventoryQuantity = @productQuantity," +
                                 "CategoryID = @categoryId " +
                                 "WHERE ProductID = @productId";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("productCode", productCode);
                    command.Parameters.AddWithValue("productName", productName);
                    command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("categoryId", categoryId);
                    command.Parameters.AddWithValue("productId", this.productId);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully update product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot update product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Cannot update product" ,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void DeleteProduct()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the product",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (!IsProductInOrder(this.productId))
                {
                   
                    SqlConnection connection = DatabaseConnection.GetConnection();
                    if (connection != null)
                    {
                        connection.Open();
                        string sql = "DELETE FROM Product WHERE ProductID = @productId";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@productId", this.productId);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Successfully deleted product",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearData();
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Cannot delete product",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Product is in another order\nCannot delete",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

    

        private bool IsProductInOrder(int productId)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string sql = "SELECT COUNT (*) FROM OrderDetail WHERE ProductID = @productId";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("productId", productId);
                    int result = (int)command.ExecuteScalar();
                    connection.Close();
                    return result > 0;
                }
               return false;
        }

        private void SearchProduct(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadProductData();
            }
            else
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string sql = "SELECT p.ProductID, p.ProductCode, p.ProductName, p.Price, " +
                                 "p.InventoryQuantity, c.CategoryName " +
                                 "FROM Product p " +
                                 "INNER JOIN Category c " +
                                 "ON p.CategoryID = c.CategoryID " +
                                 "WHERE p.ProductCode LIKE @search " +
                                 "OR p.ProductName LIKE @search " +
                                 "OR c.CategoryName LIKE @search";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgProduct.DataSource = table;
                    connection.Close();
                }
            }
        }


        private void ManageProduct_Load(object sender, EventArgs e)
        {
            LoadProductData();
            
            ChangeButtonStatus(false);
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
         //   UploadFile("Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", "path_to_save");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btBack_Click(object sender, EventArgs e)
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
        

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgProduct.CurrentCell.RowIndex;
            if (index != -1 && !dtgProduct.Rows[index].IsNewRow)
            {
                productId = Convert.ToInt32(dtgProduct.Rows[index].Cells[0].Value);
                ChangeButtonStatus(true);
                tbProductCode.Text = dtgProduct.Rows[index].Cells[1].Value.ToString();
                tbProductName.Text = dtgProduct.Rows[index].Cells[2].Value.ToString();
                tbProductPrice.Text = dtgProduct.Rows[index].Cells[3].Value.ToString();
                tbProductQuantity.Text = dtgProduct.Rows[index].Cells[4].Value.ToString();
                string categoryName = dtgProduct.Rows[index].Cells[5].Value.ToString();
                for (int i = 0; i < dtgProduct.Rows.Count; i++)
                {
                    if (cbCategory.SelectedText == categoryName)
                    {
                        cbCategory.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = tbSearch.Text;
            SearchProduct(search);
        }
        
        




        private void dtgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        
    }
}
