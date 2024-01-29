using Forms_ProjectVC_;
using System;
using System.Windows.Forms;
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
            System.Windows.Forms.Application.Run(new Registration());
           // Application.Run(new Login());
        }
    }
}