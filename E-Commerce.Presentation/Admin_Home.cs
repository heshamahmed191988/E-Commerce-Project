using E_Commerce.Context.Migrations;
using E_Commerce_Project.Models;
using Forms_ProjectVC_;
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
    public partial class Admin_Home : Form
    {


        private Image[] sliderImages = { Properties.Resources.Slide1, Properties.Resources.Slide2, Properties.Resources.Slide3, Properties.Resources.Slide4 };
        private Image[] productImages = { Properties.Resources.Product1, Properties.Resources.Product2, Properties.Resources.Product3, Properties.Resources.Product4 };
        private Image[] categoryImages = { Properties.Resources.category1, Properties.Resources.category2, Properties.Resources.category3, Properties.Resources.category4 };
        private Image[] orderImages = { Properties.Resources.order1, Properties.Resources.order2, Properties.Resources.order3, Properties.Resources.order4 };

        // Index to keep track of the current image
        private int currentIndex = 0;
        public Admin_Home()
        {
            InitializeComponent();
            InitializeSlider();
        }
        private void InitializeSlider()
        {
            // Set the initial images
            slider.Image = sliderImages[currentIndex];
            ProductImg.Image = productImages[currentIndex];
            CategorysImg.Image = categoryImages[currentIndex];
            OrderImg.Image = orderImages[currentIndex];

            // Set the interval for the timer (in milliseconds)
            /*timer1.Interval = 2000; */// Change images every 2 seconds
                                        // Attach event handler for timer tick
            timer1.Tick += timer1_Tick;
            // Start the timer
            timer1.Start();
        }
        private void Admin_Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Category_Product categorys = new Admin_Category_Product();
            categorys.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OanaCsidebar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move to the next image
           
                currentIndex = (currentIndex + 1) % sliderImages.Length;

                // Display the next image
                slider.Image = sliderImages[currentIndex];
                ProductImg.Image = productImages[currentIndex];
                CategorysImg.Image = categoryImages[currentIndex];
                OrderImg.Image = orderImages[currentIndex];
           
            

        }

        private void slider_Click(object sender, EventArgs e)
        {

        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
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

        private void PTregister_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void GoProducts_Click(object sender, EventArgs e)
        {
            Admin_product admin_Product = new Admin_product();
            admin_Product.Show();
            this.Hide();
        }

        private void GoOrders_Click(object sender, EventArgs e)
        {
            Orders_View orders_View = new Orders_View();
            orders_View.Show();
            this.Hide();
        }

        private void PTlogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void ProductImg_Click(object sender, EventArgs e)
        {

        }

        private void CategorysImg_Click(object sender, EventArgs e)
        {

        }

        private void OrderImg_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
