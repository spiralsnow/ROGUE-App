using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;

namespace ROGUE_App
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
            Application.Run(new Form1());

            
        }
    }
}