using System;
using System.Windows.Forms;

namespace IceInk
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("´úÂëÉú³ÉÆ÷¡£¡£¡£¡£");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CodeGenerator());
        }
    }
}
