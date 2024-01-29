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
        public Orders_View()
        {
            var container = AutoFact.Inject();
            _orderService = container.Resolve<IOrderService>();
            InitializeComponent();
        }

        private void Orders_View_Load(object sender, EventArgs e)
        {
            var Ord = _orderService.GetAll().ToList();
            OrderdataGridView.DataSource = Ord;
        }

        private void OrderdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = OrderdataGridView.Rows[e.RowIndex];

            // Populate textboxes with data from the selected row
            ODate.Text = row.Cells["OrderDate"].Value.ToString();
            NProduct.Text = row.Cells["Id"].Value.ToString();
            OStates.Text = row.Cells["Status"].Value.ToString();
            OTotalPrice.Text = row.Cells["TotalPrice"].Value.ToString();


        }

        private void BOUpdate_Click(object sender, EventArgs e)
        {

            int id = int.Parse(NProduct.Text);

            OrderDTO orderDTO = _orderService.GetAll().ToList().Where(i => i.Id == id).FirstOrDefault();
            string Status = OStates.Text;
            // OrderDTO orderDTO = _orderService.GetOrder(id);
            orderDTO.Status = Status;
            _orderService.UpdateOrder(orderDTO);
            Orders_View_Load(sender, e);
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
    }
}
