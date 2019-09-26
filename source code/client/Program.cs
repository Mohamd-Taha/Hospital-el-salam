using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    static class Program
    {
        public static string User_Name;
        public static DateTime last_log_in;
        public static string user_name;
        public static int user_id;
        public static string user_type;
        public static string user_password;
        public static double copy_of_last_salary;
    //    public static double copy_of_last_salary;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.frm_login());
        }
    }
}
