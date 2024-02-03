using Autofac;
using E_Commerce.Application.Mapping;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
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

            dataGridView1.DataSource = Order.Select(i => new
            {
                i.OrderDate,
                i.NoOfProducts,
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
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
