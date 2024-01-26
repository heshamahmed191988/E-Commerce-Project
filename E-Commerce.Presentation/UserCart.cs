using Autofac;
using Autofac.Core;
using E_Commerce.Application.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
    public partial class UserCart : Form
    {
        static ICartService _cartService;
        static ICartDetailsService _cartDetailsService;
        static IProductService _ProductService;
        private int cartId;
        public UserCart(int cartId)
        {
            var container = AutoFact.Inject();
            _cartService = container.Resolve<ICartService>();
            _cartDetailsService = container.Resolve<ICartDetailsService>();
            _ProductService = container.Resolve<IProductService>();
            InitializeComponent();
            this.cartId = cartId;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
           // var cart = _cartService.GetCart(cartId).Id;
            var cartItems = _cartDetailsService.GetCartItems().ToList().Where(i=>i.cartID== cartId).ToList();
            
            dataGridView1.DataSource = cartItems;
            prodNo.Text =cartItems.Count().ToString() ;
            decimal totalPrice=0 ;
            foreach (var item in cartItems)
            {
                var product = _ProductService.GetProduct(item.productID);
                totalPrice += (item.Quantity* product.Price);
            }
            price.Text=totalPrice.ToString();

        }
    }
}
