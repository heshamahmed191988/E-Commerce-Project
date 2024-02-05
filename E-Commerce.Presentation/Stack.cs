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
    public partial class Stack : Form
    {
        static IProductService _productService;
        public Stack()
        {
            var container = AutoFact.Inject();
            _productService = container.Resolve<IProductService>();
            InitializeComponent();
           // LoadProduct();

        }
        private void LoadProduct()
        {
               // var products = _productService.GetAll().ToList().Where(i => i.Quantity < 5).ToList();
                var Pro = _productService.GetAll().ToList(); 
             if (Pro.Any()) { 
                var stackItems = Pro.Where(i=>i.Quantity<5).Select(i => new
                {
                    i.Id,
                    i.ProductName, i.Quantity,i.Price,
                    i.categoryID,
                    i.image
                }).ToList();
                dataGridView1.DataSource = null ;
                dataGridView1.DataSource = stackItems;
                }
                
                else { MessageBox.Show("No products found."); }
         }
        private void Stack_Load(object sender, EventArgs e)
        {
            LoadProduct();

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

