using Autofac;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
using Forms_ProjectVC_;
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
        static ICartService _cartService;
        static ICartDetailsService _cartDetailsService;
        private void UserIdHandler(object sender, int userId)
        {
            var pro = _ProductService.SearchProduct(Pro_Name.Text).FirstOrDefault();
            var cart = _cartService.GetCart(userId);
            if (pro != null && cart != null)
            {
                _cartDetailsService.AddCartItems(pro, cart);
            }
            else
              MessageBox.Show("You can't add this Product to your cart");
            
            // return userId;
        }
        public Home_User()
        {
            var container = AutoFact.Inject();
            _ProductService = container.Resolve<IProductService>();
            _cartService = container.Resolve<ICartService>();
            _cartDetailsService= container.Resolve<ICartDetailsService>();
            InitializeComponent();
        }
        private void Home_User_Load(object sender, EventArgs e)
        {
            var Pro = _ProductService.GetAll().ToList();
            ProductdataGridView.DataSource = Pro;
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
            DataGridViewRow row = ProductdataGridView.Rows[e.RowIndex];
            Pro_Name.Text = row.Cells["ProductName"].Value.ToString();
            Pro_Price.Text = row.Cells["Price"].Value.ToString();


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
           /* string text1 = textBox2.Text;
            
            if (text1 != null)
            {
                var pro = _ProductService.SearchProductByPrice(decimal.Parse(textBox2.Text)).FirstOrDefault();
              
                if(pro != null) { 
                    Pro_Name.Text = pro.ProductName;
                    Pro_Price.Text = pro.Price.ToString();
                }
            }
            else
            {
                label2.Text = "Not Found";
                label2.Text = "";
            }*/
         

        }

        private void Add_Card_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.userIdEvent += UserIdHandler;
            form1.userIdEvent += UserIdHandler;
            form1.userIdEvent += UserIdHandler;
        }
    }
}
