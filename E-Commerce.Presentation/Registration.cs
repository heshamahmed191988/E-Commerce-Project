using Autofac;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
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
        public Registration()
        {
            var container = AutoFact.Inject();
            _userService = container.Resolve<IUserService>();
            InitializeComponent();
        }
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
             Status.Text= null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string email = Email.Text;
            string phone=Phone.Text;
            string password = pass.Text;
            string address = Address.Text;
            string type = Status.Text; /////////
            bool result = bool.Parse(type);
            UserDTO u1 = new UserDTO() { UserName = username,Email=email,Phone=phone, Password=password,Address=address,type= result };
            if (!(username.Length > 5) & !email.Contains("@.") & !ValidatePassword(password) &!ValidatePhoneNumber(phone)  )
            {
                MessageBox.Show("your data is Invalid");
                
            }
            else
            {
                _userService.AddUser(u1);
                MessageBox.Show("Thank you for your Registration");
                clearForm();

            }


        }
    }
}
