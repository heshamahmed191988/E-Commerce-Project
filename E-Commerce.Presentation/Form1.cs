using Autofac;
using E_Commerce.Application.Service;
using E_Commerce.DTOS.DTOS;
using E_Commerce.Presentation;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace Forms_ProjectVC_
{
    public partial class Form1 : Form
    {
        static IUserService _userService;
        Home_User userProducts = new Home_User();
        public event EventHandler<int> userIdEvent;
        private void invokeIDEvent(int id)
        {
            if (userIdEvent != null)
                userIdEvent(this, id);
        }
        public Form1()
        {
            InitializeComponent();
            var container = AutoFact.Inject();
            _userService = container.Resolve<IUserService>();
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
           
           var user =Authentication(username, password);

           if(  user !=null  )
            {
              if(user.type )
                {
                    
                    MessageBox.Show("Admin");
                    ///////////////////admin
                }
              else
                {
                    int id = user.Id;
                    //int cartid = user.Cart.Id;///////////////////////////////
                    //invokeIDEvent(cartid);
                    MessageBox.Show($"{id}");
                    userProducts.Show();
                    // userProducts.Close();
                }
            }
         else
            {
                MessageBox.Show("TRy Again");
            }
            
          
        }
    }
}
