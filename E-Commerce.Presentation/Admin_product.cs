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
using Forms_ProjectVC_;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

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
            LoadProduct();
        }
        private void LoadProduct()
        {
            try
            {
                if (_productService != null)
                {
                    var products = _productService.GetAll().ToList();

                    if (products != null)
                    {
                        dataGridView1.DataSource = products.Select(e => new { e.Id, e.ProductName,e.Quantity, e.Price, e.categoryID, e.image }).ToList();
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
                    string image = ImageBox.Text;

                    ProductDTO newproduct = new ProductDTO
                    {
                        ProductName = name,
                        Price = price,
                        image = image,
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
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Populate textboxes with data from the selected row
            ProductNameBox.Text = row.Cells["ProductName"].Value.ToString();
            ProductPriceBox.Text = row.Cells["Price"].Value.ToString();
            ProductQuantityBox.Text = row.Cells["Quantity"].Value.ToString();
            CategoryIdBox.Text = row.Cells["CategoryId"].Value.ToString();
            ImageBox.Text = row.Cells["Image"].Value.ToString();
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
                        int productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                        ProductDTO product= _productService.GetProduct(productId);

                        if (product != null) 
                        {
                            product.ProductName = ProductNameBox.Text;
                            product.Price = decimal.Parse(ProductPriceBox.Text);
                            product.image = ImageBox.Text; // Modify as needed
                            product.Quantity = int.Parse(ProductQuantityBox.Text);

                            _productService.UpdateProduct(product);
                            selectedRow.Cells["ProductName"].Value = ProductNameBox.Text;
                            selectedRow.Cells["Price"].Value = decimal.Parse(ProductPriceBox.Text);
                            selectedRow.Cells["Quantity"].Value = int.Parse(ProductQuantityBox.Text);
                            selectedRow.Cells["CategoryId"].Value = int.Parse(CategoryIdBox.Text);
                            selectedRow.Cells["Image"].Value = ImageBox.Text;
                            MessageBox.Show("Product updated successfully.");
                            LoadProduct();
                            // Clear the TextBoxes after updating the row
                            ProductNameBox.Text = "";
                            ProductPriceBox.Text = "";
                            ProductQuantityBox.Text = "";
                            CategoryIdBox.Text = "";
                            ImageBox.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Category not found.");
                        }

                        
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
                MessageBox.Show($"An error occurred: {ex.Message}");
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

        private void Admin_product_Load(object sender, EventArgs e)
        {

        }

        private void PTproduct_Click(object sender, EventArgs e)
        {
            Admin_product admin_Product = new Admin_product();
            admin_Product.Show();
            this.Hide();
        }

        private void PTcategory_Click(object sender, EventArgs e)
        {
            Admin_Category_Product admin_Category_Product = new Admin_Category_Product();
            admin_Category_Product.Show();
            this.Hide();
        }

        private void PTorders_Click(object sender, EventArgs e)
        {
            Orders_View orders_View = new Orders_View();
            orders_View.Show();
            this.Hide();
        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void PTregister_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void PTlogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
