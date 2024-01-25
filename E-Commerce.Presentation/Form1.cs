using Autofac;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
using E_Commerce.Presentation;
using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace Forms_ProjectVC_
{
    public partial class Form1 : Form
    {
        static IUserService _userService;
        static ICartService _cartService;
      //  public event Action<int> NewsHappened;
       
        public Form1()
        {
            InitializeComponent();
            var container = AutoFact.Inject();
            _userService = container.Resolve<IUserService>();
            _cartService = container.Resolve<ICartService>();
        }
        static UserDTO Authentication(string username, string password)
        {
            var u1 = _userService.GetUser(username, password);
            return u1;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = userName.Text;
            string password = pass.Text;

            var user = Authentication(username, password);

            if (user != null)
            {
                if (user.type == 1)
                {
                    MessageBox.Show("Admin");
                    this.Hide();
                    ///////////////////admin
                }
                else
                {
                    int id = user.Id;
                   // NewsHappened.Invoke(id);
                    var cart = _cartService.GetAll().ToList().Where(i => i.UserId == id).FirstOrDefault();
                    var cartid = cart.Id;
                    MessageBox.Show($"{cartid}");
                    Home_User userProducts = new Home_User(cartid);
                    this.Hide();
                    userProducts.Show();

                }
            }
            else
            {
                MessageBox.Show("TRy Again");
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
        }
    }
}
