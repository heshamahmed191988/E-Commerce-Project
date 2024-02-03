using Autofac;
using E_Commerce.Application.Service;
using E_Commerce.Context;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using Forms_ProjectVC_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Commerce.Presentation
{
    public partial class Orders_View : Form
    {
        static IOrderService _orderService;
        static IOrderItemService _orderItemService;
        public Orders_View()
        {
            var container = AutoFact.Inject();
            _orderService = container.Resolve<IOrderService>();
            _orderItemService = container.Resolve<IOrderItemService>();
            InitializeComponent();
        }

        private void Orders_View_Load(object sender, EventArgs e)
        {
            var Ord = _orderService.GetAll().ToList();
            var OrderIds = Ord.Select(Order => Order.Id).ToList();
            var result = Ord
    .Select(Order => new
    {
        Order.OrderDate,
        Order.Status,
        Order.TotalPrice,
    }).ToList();
            OrderdataGridView.DataSource = result;

        }


        private void OrderdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = OrderdataGridView.Rows[e.RowIndex];


                if (row.Cells["OrderDate"].Value != null &&
                    row.Cells["Id"].Value != null &&
                    row.Cells["Status"].Value != null &&
                    row.Cells["TotalPrice"].Value != null)
                {
                    // Populate textboxes with data from the selected row
                    ODate.Text = row.Cells["OrderDate"].Value.ToString();
                    NProduct.Text = row.Cells["Id"].Value.ToString();
                    OStates.Text = row.Cells["Status"].Value.ToString();
                    OTotalPrice.Text = row.Cells["TotalPrice"].Value.ToString();
                }
                else
                {
                    // Handle the case where some cells are null
                    MessageBox.Show("Selected row has missing or null values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void BOUpdate_Click(object sender, EventArgs e)
        {

            if (int.TryParse(NProduct.Text, out int id))
            {
                OrderDTO orderDTO = _orderService.GetAll().FirstOrDefault(i => i.Id == id);

                if (orderDTO != null)
                {
                    string status = OStates.Text;

                    if (!string.IsNullOrWhiteSpace(status))
                    {
                        orderDTO.Status = status;
                        _orderService.UpdateOrder(orderDTO);
                        Orders_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Status cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Order with the specified ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show an error message if NProduct.Text is not a valid integer
                MessageBox.Show("Invalid Order ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void ODate_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stack stack = new Stack();
            stack.Show();
        }
    }
}
