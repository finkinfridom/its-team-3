using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classbooking
{
    static class Program
    {
        //private static string email;
        //private static string password;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(/*email,password*/));
            //Application.Run(new Aula());
            //Application.Run(new Prenotazione("test"));
        }
    }
}
