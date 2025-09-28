using System;
using System.Windows.Forms;

namespace WindowsFormsApp_CauThu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy SplashForm trước
            Application.Run(new SplashForm());
        }
    }
}