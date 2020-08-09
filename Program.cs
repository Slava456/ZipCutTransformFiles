using System;
using System.Windows.Forms;
using ZipCutTransformFiles.Classes;

namespace ZipCutTransformFiles
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormsClass fc = new FormsClass();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(fc.InitMainForm());
        }
    }
}
