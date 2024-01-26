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

        private Image[] images = { Properties.Resources.Slide1, Properties.Resources.Slide2, Properties.Resources.Slide3, Properties.Resources.Slide4 };

        // Index to keep track of the current image
        private int currentIndex = 0;
        public Admin_Home()
        {
            InitializeComponent();


            // Set the initial image
            slider.Image = images[currentIndex];
            // Set the interval for the timer (in milliseconds)
            timer1.Interval = 4000; // Change images every 2 seconds
            // Start the timer
            timer1.Start();
            // Attach event handler for timer tick
            timer1.Tick += timer1_Tick;




        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Categorys categorys = new Categorys();
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
            currentIndex++;
            // If we reached the end of the array, start from the beginning
            if (currentIndex >= images.Length)
            {
                currentIndex = 0;
            }
            // Display the next image
            slider.Image = images[currentIndex];
        }

        private void slider_Click(object sender, EventArgs e)
        {

        }

        private void BTlogin_Click(object sender, EventArgs e)
        {

        }
    }

}
