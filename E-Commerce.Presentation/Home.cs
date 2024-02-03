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
    public partial class Home : Form
    {
        private Image[] sliderImages = { Properties.Resources.Slide1, Properties.Resources.Slide2, Properties.Resources.Slide3, Properties.Resources.Slide4 };
        private int currentIndex = 0;
        public Home()
        {
            InitializeComponent();
            InitializeSlider();
        }
        private void InitializeSlider()
        {
            // Set the initial images
            pictureBox1.Image = sliderImages[currentIndex];


            // Set the interval for the timer (in milliseconds)
            /*timer1.Interval = 2000; */// Change images every 2 seconds
                                        // Attach event handler for timer tick
            timer1.Tick += timer1_Tick;
            // Start the timer
            timer1.Start();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move to the next image
            currentIndex = (currentIndex + 1) % sliderImages.Length;

            // Display the next image
            pictureBox1.Image = sliderImages[currentIndex];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
