using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace GroceryStore
{
    public static class Global
    {
        public static string stringConectare = @"Data Source = DESKTOP-9A6B646; Initial Catalog = grocery; Integrated Security = SSPI";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static SqlCommandBuilder cb;

        public static string CurrentId;
        public static string CurrentUsername;
        public static string CurrentMobile;
        public static string CurrentFullName; 
        public static int nr=0;

        public static double totalValue=0;
        public static List<int> orders = new List<int>();
    }
    
    
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
            Application.Run(new login());
        }
    }
}
