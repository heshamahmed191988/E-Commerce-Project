using Autofac;
using Autofac.Core;
using E_Commerce.Application.Mapping;
using E_Commerce.Application.Service;
using E_Commerce.Context.Migrations;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore;
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
            var pro = _ProductService.GetAll().ToList();
            foreach (var item in cartItems)
            {
                item.Product = pro.FirstOrDefault(i => i.Id == item.productID);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cartItems.Select(i => new
            {
                productName = i.Product.ProductName,
                quantity = i.Quantity
            }
            ).ToList();
            return cartItems;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
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
            var cartItems = load().ToList();
            if (cartItems != null && cartItems.Any())
            {
                var order = new OrderDTO() {
                    NoOfProducts = productsNo,
                    TotalPrice = totalPrice, 
                    Status = "processing", 
                    OrderDate = currentDate,
                    UserID = UserId };

                _orderService.AddOrder(order);

                int num = _orderService .GetAll().AsEnumerable().OrderByDescending(i => AutoMapping.MapOrder(i).Id).FirstOrDefault()?.Id ?? 0; ;

                if (num != 0)
                {

                    foreach (var item in cartItems)
                    {
                        var product = _ProductService.GetProduct(item.productID);
                        if (product != null)
                        {
                            OrderItemDTO orderitems = new OrderItemDTO()
                            {
                                productId = product.Id,
                                OrderId = num
                            };
                            _orderItemService.AddOrderItems(orderitems);
                            _cartDetailsService.RemoveProductFromCart(item);
                            //MessageBox.Show("items Added");
                        }
                        else
                        {
                           // MessageBox.Show($"Product with ID {item.productID} not found.");
                        }
                    } 
                    MessageBox.Show("Order Added");


                }
                else
                {
                    MessageBox.Show("Failed to retrieve Order ID.");
                }

            }
            else
            {
                MessageBox.Show("No items in the cart.");
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                label5.Text = row.Cells["productName"].Value.ToString();
                ChangeQuantity.Text = row.Cells["Quantity"].Value.ToString();

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
            string name = label5.Text;
            var product = _ProductService.SearchProduct(name).AsNoTracking().FirstOrDefault();
            if (product.Id != 0)
            {
                var cartitemDelete = _cartDetailsService.GetCartItems().AsNoTracking().ToList().Where(i => i.productID == product.Id).FirstOrDefault();
                MessageBox.Show("are you sure to delete this item");
                _cartDetailsService.RemoveProductFromCart(cartitemDelete);
                var x = load();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            string name = label5.Text;
            var product = _ProductService.SearchProduct(name).FirstOrDefault();
            if (product != null)
            {
                string newQuantityValue = ChangeQuantity.Text;
                if (newQuantityValue != "")
                {
                    var cartitemUpdate = _cartDetailsService.GetCartItems().AsNoTracking().ToList().Where(i => i.productID == product.Id).FirstOrDefault();
                    if (cartitemUpdate != null && int.Parse(newQuantityValue) != cartitemUpdate.Quantity)
                    {
                        //CartDetailsDTO updatedCartitem= new CartDetailsDTO() { Id = cartitemUpdate.Id, Quantity = int.Parse(newQuantityValue),productID=cartitemUpdate.productID,cartID=cartitemUpdate.cartID };
                    
                        cartitemUpdate.Quantity = int.Parse(newQuantityValue);
                        _cartDetailsService.UpdateCart(cartitemUpdate);
                        MessageBox.Show("updated");
                        var x = load();
                    }


                }
            }
        }

        private void PTorders_Click(object sender, EventArgs e)
        {
            Showorderitem showorder = new Showorderitem(UserId);
            showorder.Show();
        }
    }
}
