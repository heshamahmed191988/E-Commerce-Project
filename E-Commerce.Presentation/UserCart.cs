using Autofac;
using Autofac.Core;
using E_Commerce.Application.Service;
using E_Commerce.Context.Migrations;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
        static IOrderService _orderService;
        static IOrderItemService _orderItemService;
        private int cartId;
        private int UserId;
        int totalPrice = 0;
        int productsNo = 0;
        public UserCart(int cartId, int UserId)
        {
            var container = AutoFact.Inject();
            _cartService = container.Resolve<ICartService>();
            _cartDetailsService = container.Resolve<ICartDetailsService>();
            _ProductService = container.Resolve<IProductService>();
            _orderService = container.Resolve<IOrderService>();
            _orderItemService = container.Resolve<IOrderItemService>();

            InitializeComponent();
            this.cartId = cartId;
            this.UserId = UserId;
        }

        private List<CartDetailsDTO> load()
        {
            var cartItems = _cartDetailsService.GetCartItems().ToList().Where(i => i.cartID == cartId).ToList();
            dataGridView1.DataSource = cartItems;
            return cartItems;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
            // var cart = _cartService.GetCart(cartId).Id;

            var cartItems = load();

            foreach (var item in cartItems)
            {
                var product = _ProductService.GetProduct(item.productID);
                totalPrice += (int)(item.Quantity * product.Price);
                productsNo += item.Quantity;
            }
            price.Text = totalPrice.ToString();
            prodNo.Text = productsNo.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            OrderDTO order = new OrderDTO() { NoOfProducts = productsNo, TotalPrice = totalPrice, Status = "processing", OrderDate = currentDate, UserID = UserId };
            _orderService.AddOrder(order);
            MessageBox.Show($"{order.Id}");
            var cartItems = load();

            foreach (var item in cartItems)
            {
                var product = _ProductService.GetProduct(item.productID).Id;
                OrderItemDTO orderitems = new OrderItemDTO() { productId = product, OrderId = order.Id };
                _orderItemService.AddOrderItems(orderitems);
            }
            MessageBox.Show("Order Added");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                label5.Text = row.Cells["Id"].Value.ToString();
                ChangeQuantity.Text = row.Cells["Quantity"].Value.ToString();
                // ChangeQuantity.Text = oldQuantityValue;
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void updateQuantity_Click(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(label5.Text);
            if (ID != 0)
            {
             var cartitemDelete = _cartDetailsService.GetCartItems().ToList().Where(i => i.Id == ID).FirstOrDefault();
            MessageBox.Show("are you sure to delete this item");
            _cartDetailsService.RemoveProductFromCart(cartitemDelete);
            load();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(label5.Text);

            if (ID != 0)
            {
                string newQuantityValue = ChangeQuantity.Text;
                if (newQuantityValue != "")
                {
                    var cartitemUpdate = _cartDetailsService.GetCartItems().ToList().Where(i => i.Id == ID).FirstOrDefault();
                    cartitemUpdate.Quantity = int.Parse(newQuantityValue);
                    _cartDetailsService.UpdateCart(cartitemUpdate);
                    MessageBox.Show("updated");
                    load();

                }
            }
        }
    }
}
