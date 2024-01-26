using E_Commerce.Application.Contract;
using E_Commerce.Application.Service;
using System.Reflection;

namespace E_Commerce.Presentation
{
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // System.Windows.Forms.Application.Run(new Admin_Category_Product());
            ICategoryService categoryService = new CategoryService();
            IProductService productService = new ProductService();


            //System.Windows.Forms.Application.Run(new Admin_Category_Product(categoryService));
           // System.Windows.Forms.Application.Run(new Admin_product());
        }
    }
}