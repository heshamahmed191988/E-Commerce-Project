using E_Commerce.Application.Contract;
using E_Commerce.Application.Service;
using E_Commerce.Context;
using E_Commerce.DTOS.DTOS;
using E_Commerce.Infrustructure.Repository;
using E_Commerce_Project.Models;
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
    public partial class Admin_Category_Product : Form
    {

        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        //public Admin_Category_Product()
        //{
        //    InitializeComponent();
        //    LoadCategories();
        //}
        public Admin_Category_Product(ICategoryService categoryService, IProductService productService)
        {
            InitializeComponent();
            _categoryService = new CategoryService(new CategoryRepository(new E_CommerceContext()));
           // _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            LoadCategories();
        }


        private void LoadCategories()
        {
            try
            {
                if (_categoryService != null)
                {
                    var categories = _categoryService.GetAll();

                    if (categories != null)
                    {
                        dataGridView2.DataSource = categories.ToList();
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

                    CategoryDTO newCategory = new CategoryDTO
                    {
                        CategoryName = name,
                        Description = description,
                        image = "123",
                        Products = (IQueryable<ProductDTO>)Enumerable.Empty<Product>().ToList()
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
            if (dataGridView2.CurrentRow != null)
            {
                CategoryDTO selectedCategory = dataGridView2.CurrentRow.DataBoundItem as CategoryDTO;

                if (selectedCategory != null)
                {
                    string updatedName = CatogeryNameBox.Text;
                    string updatedDescription = CatogeryDescriptionBox.Text;

                    selectedCategory.CategoryName = updatedName;
                    selectedCategory.Description = updatedDescription;

                    _categoryService.UpdateCategory(selectedCategory);
                    LoadCategories();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to update.");
            }
        }

        private void DeleteCtegorey_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                CategoryDTO selectedCategory = dataGridView2.CurrentRow.DataBoundItem as CategoryDTO;

                if (selectedCategory != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        _categoryService.RemoveCategory(selectedCategory);
                        LoadCategories();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }
    }



}
