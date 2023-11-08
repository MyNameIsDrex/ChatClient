using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Properties;

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
                if (SettingsProperty.ReferenceEquals(username, username))
                {
                    username = "user" + r.ToString();
                    Settings.Default.Username = username;
                }
                
                if (SettingsProperty.ReferenceEquals(username, "user"))
                {
                    username = Settings.Default.Username;
                }
                
                
            }

            
        }



    }
}
