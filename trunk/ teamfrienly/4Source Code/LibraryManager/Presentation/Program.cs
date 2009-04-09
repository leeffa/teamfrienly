using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(UnhandledExceptionCatcher);

            Application.Run(new Form1());
        }
        private static void UnhandledExceptionCatcher(object sender, ThreadExceptionEventArgs e)
        {
            string message = "An unhandled exception occurs." + "\n";
            message += "Error description: " + e.Exception.Message + "\n";
            message += "Error detail: " + e.Exception.StackTrace + "\n";
            message += "Please contact ...";

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}