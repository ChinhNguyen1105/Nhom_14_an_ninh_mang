using System;
using System.Windows.Forms;

namespace RSA_Signature_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Thay thế ApplicationConfiguration bằng các cấu hình WinForms tiêu chuẩn
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy trực tiếp Form1
            Application.Run(new Form1());
        }
    }
}