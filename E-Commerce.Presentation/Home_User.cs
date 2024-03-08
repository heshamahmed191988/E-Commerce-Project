﻿using Autofac;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using Forms_ProjectVC_;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Commerce.Presentation
{
    public partial class Home_User : Form
    {
        static IProductService _ProductService;
        static ICategoryService _categoryService;
        static ICartService _cartService;
        static ICartDetailsService _cartDetailsService;
        private int cartId;
        private int userId;
        public Home_User(int cartId, int userId)
        {
            var container = AutoFact.Inject();
            _ProductService = container.Resolve<IProductService>();
            _cartService = container.Resolve<ICartService>();
            _cartDetailsService = container.Resolve<ICartDetailsService>();
            _categoryService = container.Resolve<ICategoryService>();
            InitializeComponent();
            productQuantity.Items.Insert(0, "1");
            productQuantity.Items.Add("2");
            productQuantity.Items.Add("3");
            productQuantity.Items.Add("4");
            productQuantity.Items.Add("5");
            productQuantity.Items.Add("6");
            productQuantity.Items.Add("7");
            productQuantity.Items.Add("8");
            productQuantity.Items.Add("9");
            productQuantity.Items.Add("10");
            // comboBox1.Items.Add("false");
            productQuantity.SelectedIndex = 0;
            this.cartId = cartId;
            this.userId = userId;
        }

        private void Home_User_Load(object sender, EventArgs e)
        {
            var Pro = _ProductService.GetAll().ToList();
            var categoryIds = Pro.Select(product => product.categoryID).ToList();
            var categories = _categoryService.GetAll().ToList();

            foreach (var product in Pro)
            {
                product.category = categories.FirstOrDefault(category => category.Id == product.categoryID);
            }

            var result = Pro
    .Select(product => new
    {
        product.ProductName,
        product.Price,
        product.image,
        CategoryName = product.category.CategoryName,
        State = product.Quantity <= 5 ? "Out of Stock" : "Available"
    })
    .ToList();
            ProductdataGridView.DataSource = result;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ProductdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductdataGridView.Rows[e.RowIndex];
                Pro_Name.Text = row.Cells["ProductName"].Value.ToString();
                Pro_Price.Text = row.Cells["Price"].Value.ToString();
            }


        }
        private void ProductdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Name_Click(object sender, EventArgs e)
        {

        }

        private void Product_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var pro = _ProductService.SearchProduct(textBox1.Text).FirstOrDefault();
            if (pro != null)
            {
                Pro_Name.Text = pro.ProductName;
                Pro_Price.Text = pro.Price.ToString();
                label2.Text = "";

            }
            else
            {
                label2.Text = "Not Found";
                //label2.Text = "";
            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        private void Add_Card_Click(object sender, EventArgs e)
        {
            var cartAllItems = _cartDetailsService.getAll(cartId).ToList();
            var pro = _ProductService.SearchProduct(Pro_Name.Text).FirstOrDefault();
            int quantity = int.Parse(productQuantity.Text);
            var currentItem = cartAllItems.Where(i => i.productID == pro.Id).FirstOrDefault();
            if (currentItem != null)
            {
                currentItem.Quantity += quantity;
                _cartDetailsService.UpdateCart(currentItem);
                MessageBox.Show("Quantity Increase");
            }
            else
            {
                // MessageBox.Show("stop");
                if (pro != null && cartId != 0 && quantity != 0)
                {
                    var cartItem = new CartDetailsDTO() { cartID = cartId, productID = pro.Id, Quantity = quantity };
                    _cartDetailsService.AddCartItems(cartItem);
                    MessageBox.Show("Product Added");
                }
                else
                    MessageBox.Show("You can't add this Product to your cart");

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserCart userCart = new UserCart(cartId, userId);
            userCart.Show();
            this.Hide();
        }

        private void PTproduct_Click(object sender, EventArgs e)
        {
            Home_User home_User = new Home_User(cartId, userId);
            home_User.Show();
            this.Hide();

        }

        private void PTorders_Click(object sender, EventArgs e)
        {
            Showorderitem orderItems = new Showorderitem(userId);
            orderItems.Show();
          
        }

        private void PTcart_Click(object sender, EventArgs e)
        {
            UserCart userCart = new UserCart(cartId, userId);
            userCart.Show();
            this.Hide();
        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void PTlogout_Click(object sender, EventArgs e)
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

        private void Filter_by_Name_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
