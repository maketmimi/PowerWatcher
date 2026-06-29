using PowerWatcher.GUI;
using System;
using System.Windows.Forms;

namespace PowerWatcher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO should be improved
            FrmMain MainForm = new FrmMain();
            
            if (args.Length == 1 && args[0].ToLower() == "-hidden")
            {
                Application.Run();
            }
            else
            {
                Application.Run(MainForm);
            }
        }
    }
}
