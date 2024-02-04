using Autofac;
using E_Commerce.Application.Mapping;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace E_Commerce.Presentation
{
    public partial class Showorderitem : Form
    {
        static IOrderItemService _orderItemService;
        static IOrderService _orderService;
        static IProductService _productService;
        private int UserId;
        public Showorderitem(int UserId)
        {
            var container = AutoFact.Inject();
            _orderItemService = container.Resolve<IOrderItemService>();
            _orderService = container.Resolve<IOrderService>();
            _productService = container.Resolve<IProductService>();
            InitializeComponent();
            this.UserId = UserId;
        }
        private void LoadOrderItems()
        {
            var Order = _orderService.GetAll().ToList().Where(i => i.UserID == UserId).ToList();
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = Order.Select(i => new
            {
                OrderNumber=i.Id,
                i.OrderDate,
                i.NoOfProducts,
                i.TotalPrice,
                i.Status
                
            }
            ).ToList();

        }

        private void Showorderitem_Load(object sender, EventArgs e)
        {
            LoadOrderItems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                OrderId.Text= row.Cells["OrderNumber"].Value.ToString();
                if (OrderId.Text!=null)
                {
                   int orderId = int.Parse(OrderId.Text);
                   var orderItems = _orderItemService.GetAll().ToList().Where(i => i.OrderId == orderId).ToList();
                    var products = _productService.GetAll().ToList();
                    var productIds = orderItems.Select(i => i.productId).ToList();
                    foreach ( var product in orderItems )
                    {
                        product.product = products.FirstOrDefault(i => i.Id == product.productId);
                    }
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = orderItems.Select(i =>new { ProductName=i.product.ProductName,i.Quantity }).ToList();
                }
                
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
