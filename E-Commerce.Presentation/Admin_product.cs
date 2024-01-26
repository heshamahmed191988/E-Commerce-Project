using E_Commerce.Application.Contract;
using E_Commerce.Application.Service;
using E_Commerce.Context;
using Autofac;
using E_Commerce.DTOS.DTOS;
using E_Commerce.Infrustructure.Repository;
using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
    public partial class Admin_product : Form
    {
       // private readonly ICategoryService _categoryService;

        private readonly IProductService _productService;
      
        public Admin_product()
        {
            var container = AutoFact.Inject();
            
            _productService = container.Resolve<IProductService>();
            InitializeComponent();
            //_categoryService = new CategoryService(new CategoryRepository(new E_CommerceContext()));
           // _productService = new ProductService(new ProductRepository(new E_CommerceContext()));
            // _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            //_productService = productService ?? throw new ArgumentNullException(nameof(productService));
           // LoadCategories();
            LoadProduct();
        }
        private void LoadProduct()
        {
            try
            {
                if (_productService != null)
                {
                    var products = _productService.GetAll();

                    if (products != null)
                    {
                        dataGridView1.DataSource = products.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No categories found.");
                    }
                }
                else
                {
                    MessageBox.Show("_categoryService is null");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                if (_productService != null)
                {
                    string name = ProductNameBox.Text;
                    decimal price = decimal.Parse(ProductPriceBox.Text);
                    int quantity = int.Parse(ProductQuantityBox.Text);
                    int categoryid = int.Parse(CategoryIdBox.Text);

                    ProductDTO newproduct = new ProductDTO
                    {
                        ProductName = name,
                        Price = price,
                        image = "123",
                        Quantity = quantity,
                        categoryID = categoryid,

                    };

                    _productService.AddProduct(newproduct);
                    LoadProduct();

                }
                else
                {
                    MessageBox.Show("_productService");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;

            try
            {
                if (_productService != null)
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                        // Modify the columns based on their names
                        selectedRow.Cells["ProductName"].Value = ProductNameBox.Text;
                        selectedRow.Cells["Price"].Value = decimal.Parse(ProductPriceBox.Text);
                        selectedRow.Cells["Quantity"].Value = int.Parse(ProductQuantityBox.Text);
                        selectedRow.Cells["CategoryId"].Value = int.Parse(CategoryIdBox.Text);

                        // After the modifications are done, update the data in the service
                        int productId = int.Parse(selectedRow.Cells["ProductId"].Value.ToString()); // Assuming you have a column named "ProductId"
                        ProductDTO updatedProduct = new ProductDTO
                        {
                            Id = productId,
                            ProductName = ProductNameBox.Text,
                            Price = decimal.Parse(ProductPriceBox.Text),
                            image = "123", // Modify as needed
                            Quantity = int.Parse(ProductQuantityBox.Text),
                            categoryID = int.Parse(CategoryIdBox.Text)
                        };

                        _productService.UpdateProduct(updatedProduct);

                        // Clear the TextBoxes after updating the row
                        ProductNameBox.Text = "";
                        ProductPriceBox.Text = "";
                        ProductQuantityBox.Text = "";
                        CategoryIdBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to edit.");
                    }
                }
                else
                {
                    MessageBox.Show("_productService is null.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed
                //MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (var context = new E_CommerceContext())
                            {
                                // Retrieve the existing product entity from the database
                                E_Commerce_Project.Models.Product existingProductEntity = context.Products.Find(productId);

                                if (existingProductEntity != null)
                                {
                                    // Remove the entity from the context and mark it as deleted
                                    context.Products.Remove(existingProductEntity);

                                    // Save changes to the database
                                    context.SaveChanges();

                                    // Reload products after deletion
                                    LoadProduct();

                                    MessageBox.Show("Product deleted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Product not found.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
