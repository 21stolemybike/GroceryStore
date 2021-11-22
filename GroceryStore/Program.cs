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
