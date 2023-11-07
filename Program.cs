using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication
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
            Application.Run(new ChatClient());
        }

        public class Username
        {
            public static Username name = new Username();

            public static Random rnd = new Random();
            public static int r = rnd.Next();   
            public static string username;
            
            public static void generate_username()
            {
                username = "user" + r.ToString();

            }
        }

        public class Message
        {
            public static void recieve_message(String name)
            {

            }

            
        }





    }
}
