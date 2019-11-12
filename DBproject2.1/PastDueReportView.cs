using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject2._1
{
    public partial class PastDueReportView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        public PastDueReportView()
        {
            InitializeComponent();
        }

        public PastDueReportView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void PastDueReportView_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = DbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM CHECKOUT_ITEM WHERE DueDate<@today";
            cmd.Parameters.AddWithValue("@today", DateTime.Now);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tempTable = new DataTable();
            tempTable.Load(reader);

            dataGridView1.DataSource = tempTable;
        }
    }
}
