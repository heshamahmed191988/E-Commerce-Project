using Autofac;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
using Forms_ProjectVC_;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
    public partial class Registration : Form
    {
        static IUserService _userService;
        static ICartService _cartService;
        Form1 login = new Form1();
        public Registration()
        {
            var container = AutoFact.Inject();
            _userService = container.Resolve<IUserService>();
            _cartService = container.Resolve<ICartService>();
            InitializeComponent();
            //comboBox1.Items.Insert(0, "0");
            //comboBox1.Items.Add("1");
            // comboBox1.Items.Add("false");
           // comboBox1.SelectedIndex = 0;
        }
        #region functions
        static bool ContainsSpecialCharacter(string password)
        {
            return Regex.IsMatch(password, "[!@#$%^&*(),.?\":{}|<>]");
        }
        static bool ContainsDigit(string password)
        {
            // Check if the password contains at least one digit
            return Regex.IsMatch(password, "\\d");
        }
        static bool ValidatePassword(string password)
        {
            //pass.Text = "*";
            // Check if the password meets the specified criteria
            return ContainsDigit(password) &&
                  ContainsSpecialCharacter(password);
        }
        static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^01[0-2,5]{1}[0-9]{8}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
        void clearForm()
        {
            // string username = UserName.Text;
            UserName.Text = null;
            Email.Text = null;
            pass.Text = null;
            Phone.Text = null;
            Address.Text = null;
            // comboBox1.Text = null;
            nameMsg.Text = null;
            EmailMsg.Text = null;
            PassMSg.Text = null;
            PhonMSG.Text = null;
            AddressMSG.Text = null;
        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string email = Email.Text;
            string phone = Phone.Text;
            string password = pass.Text;
            string address = Address.Text;
           // string type = comboBox1.Text; /////////
            //int result = int.Parse(type);
            UserDTO u1 = new UserDTO() { UserName = username, Email = email, Phone = phone, Password = password, Address = address, type = 0 };
            

            #region condition edit
            if (username.Length < 5 ||
            !email.Contains("@") || email == null ||
            !ValidatePassword(password) || password == null ||
            !ValidatePhoneNumber(phone) || phone == null ||
            address.Length == 0)
            {
                nameMsg.Text = (username.Length < 5) ? "Name must be more than 5letter" : "";
                EmailMsg.Text = (!email.Contains("@") || email == null) ? "Email must contain @ " : "";
                PassMSg.Text = (!ValidatePassword(password) || password == null) ? "Password must be complex" : "";
                PhonMSG.Text = (!ValidatePhoneNumber(phone) || phone == null) ? "Phone must be 11 number" : "";
                AddressMSG.Text = (address.Length == 0) ? "Enter your Adress,please" : "";

                MessageBox.Show("Please Enter Correct Data");
            }
            else
            {
                UserDTO user = _userService.AddUser(u1);
                var uId = _userService.GetUser(username, password)?.Id; // Added null-conditional operator (?)
                if (uId != null)
                {
                    CartDTO c1 = new CartDTO() { Quantity = 0, Status = "Empty", UserId = uId.Value }; // Assuming UserId is not nullable
                    _cartService.AddCart(c1);
                }
                MessageBox.Show("thank you!");
                clearForm();
            }
            #endregion
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void PhonMSG_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
