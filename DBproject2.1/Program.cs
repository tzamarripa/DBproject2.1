using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBproject2._1
{
    static class Program
    {
        private static SqlConnection dbConn;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(openDb())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.ApplicationExit += Application_ApplicationExit;
                LauncherView form = new LauncherView();
                form.DbConnection = dbConn;
                Application.Run(form);
            }
        }

        private static bool openDb()
        {
            dbConn = new SqlConnection(Properties.Settings.Default.DB_CONNECTION);
            Boolean opened = false;

            try
            {
                dbConn.Open();
                opened = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to connect to database.", "DB error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return opened;
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if(dbConn != null)
            {
                dbConn.Close();
            }
        }
    }
}
