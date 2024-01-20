using Autofac;
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
    public partial class Registration : Form
    {
        static IUserService _userService;
        public Registration()
        {
            var container = AutoFact.Inject();
            _userService = container.Resolve<IUserService>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string email = Email.Text;
            string phone=Phone.Text;
            string password = pass.Text;

        }
    }
}
