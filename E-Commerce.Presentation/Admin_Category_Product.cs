﻿using E_Commerce.Application.Contract;
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

namespace E_Commerce.Presentation
{
    public partial class Admin_Category_Product : Form
    {

        ICategoryService _categoryService;
        private readonly IProductService _productService;

        //public Admin_Category_Product()
        //{
        //    InitializeComponent();
        //    LoadCategories();
        //}
        public Admin_Category_Product()
        {
            var container = AutoFact.Inject();
            _categoryService = container.Resolve<ICategoryService>();
            _productService = container.Resolve<IProductService>();
            InitializeComponent();
            LoadCategories();
        }
        /*   public Admin_Category_Product(ICategoryService categoryService)
           { 
               var container = AutoFact.Inject();
               _categoryService = container.Resolve<ICategoryService>();
               _productService = container.Resolve<IProductService>();
               InitializeComponent();
               // _categoryService = new CategoryService(new CategoryRepository(new E_CommerceContext()));
               //_productService = new ProductService(new ProductRepository(new E_CommerceContext()));
               // _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
               //_productService = productService ?? throw new ArgumentNullException(nameof(productService));
               LoadCategories();

           }*/


        private void LoadCategories()
        {
            try
            {
                if (_categoryService != null)
                {
                    var categories = _categoryService.GetAll().ToList();

                    if (categories != null)
                    {
                        dataGridView2.DataSource = categories.Select(e => new { e.Id, e.CategoryName, e.Description, e.image }).ToList();
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



        private void AddCtegorey_Click(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = true;
            try
            {
                if (_categoryService != null)
                {
                    string name = CatogeryNameBox.Text;
                    string description = CatogeryDescriptionBox.Text;
                    string Image = Imagebox.Text;
                    CategoryDTO newCategory = new CategoryDTO
                    {
                        CategoryName = name,
                        Description = description,
                        image = Image,
                        // Products = (IQueryable<ProductDTO>)Enumerable.Empty<Product>().AsQueryable(),
                    };

                    _categoryService.AddCategory(newCategory);
                    LoadCategories();

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








        private void EditCtegorey_Click(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = true;

            try
            {
                if (_categoryService != null)
                {
                    if (dataGridView2.SelectedRows.Count > 0)
                    {
                        // Get the selected category from the DataGridView
                        DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                        int categoryId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                        // Retrieve the existing category entity from the database
                        E_Commerce_Project.Models.Category existingCategoryEntity;

                        using (var context = new E_CommerceContext())
                        {
                            existingCategoryEntity = context.Categories.Find(categoryId);
                        }

                        if (existingCategoryEntity != null)
                        {
                            // Update the properties of the existing category entity
                            existingCategoryEntity.CategoryName = CatogeryNameBox.Text;
                            existingCategoryEntity.Description = CatogeryDescriptionBox.Text;
                            existingCategoryEntity.image = Imagebox.Text;

                            // You may want to update other properties as needed

                            // Save changes to the database
                            using (var context = new E_CommerceContext())
                            {
                                context.Entry(existingCategoryEntity).State = EntityState.Modified;
                                context.SaveChanges();
                            }

                            // Update the corresponding row in the DataGridView
                            selectedRow.Cells["CategoryName"].Value = existingCategoryEntity.CategoryName;
                            selectedRow.Cells["Description"].Value = existingCategoryEntity.Description;
                            selectedRow.Cells["Image"].Value = existingCategoryEntity.image;
                            // Update other cells as needed

                            MessageBox.Show("Category updated successfully.");
                            LoadCategories();
                        }
                        else
                        {
                            MessageBox.Show("Category not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No rows selected.");
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


        private CategoryDTO ConvertToDTO(E_Commerce_Project.Models.Category entity)
        {
            // Implement the conversion logic based on your entity and DTO structure
            // For simplicity, assuming a CategoryDTO constructor that accepts an entity
            return new CategoryDTO
            {
                // Assign properties based on your entity structure
                CategoryName = entity.CategoryName,
                Description = entity.Description,
                // Other properties...
            };
        }


        private void DeleteCtegorey_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                int categoryId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (_categoryService != null)
                        {
                            using (var context = new E_CommerceContext())
                            {
                                // Retrieve the existing category entity from the database
                                E_Commerce_Project.Models.Category existingCategoryEntity = context.Categories.Find(categoryId);

                                if (existingCategoryEntity != null)
                                {
                                    // Ensure the entity is being tracked by the context
                                    context.Entry(existingCategoryEntity).State = EntityState.Detached;

                                    // Attach the entity to the context and mark it as deleted
                                    context.Categories.Attach(existingCategoryEntity);
                                    context.Categories.Remove(existingCategoryEntity);

                                    // Save changes to the database
                                    context.SaveChanges();

                                    // Reload categories after deletion
                                    LoadCategories();

                                    MessageBox.Show("Category deleted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Category not found.");
                                }
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
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }



        }

        private void PTproduct_Click(object sender, EventArgs e)
        {
            Admin_product admin_Product = new Admin_product();
            admin_Product.Show();
            this.Hide();
        }

        private void PTorders_Click(object sender, EventArgs e)
        {
            Orders_View orders_View = new Orders_View();
            orders_View.Show();
            this.Hide();
        }

        private void PTcategory_Click(object sender, EventArgs e)
        {
            Admin_Category_Product admin_Category_Product = new Admin_Category_Product();
            admin_Category_Product.Show();
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
