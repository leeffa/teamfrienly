using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using System.Threading;
namespace Presentation
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new MainForm());
           // Application.ThreadException += new ThreadExceptionEventHandler(UnhandledExceptionCatcher);

            Application.Run(new MainForm());
        }
     /*   private static void UnhandledExceptionCatcher(object sender, ThreadExceptionEventArgs e)
        {
            string message = "An unhandled exception occurs." + "\n";
            message += "Error description: " + e.Exception.Message + "\n";
            message += "Error detail: " + e.Exception.StackTrace + "\n";
            message += "Please contact ...";

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Writes to log file. 
        }*/

    }
}