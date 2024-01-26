using Autofac;
using E_Commerce.Application.Contract;
using E_Commerce.Application.Service;
using E_Commerce.Context;
using E_Commerce.Infrustructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Presentation
{
    internal class AutoFact
    {
        public static Autofac.IContainer Inject()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CartRepository>().As<ICartRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<CartDetailsRepository>().As<ICartDetailsRepository>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<CartService>().As<ICartService>();
            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<CartDetailsService>().As<ICartDetailsService>();
            builder.RegisterType<E_CommerceContext>().As<E_CommerceContext>();

            return builder.Build();
        }
    }
}
