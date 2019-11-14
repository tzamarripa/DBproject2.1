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
            LoadFromDB();
        }

        private void LoadFromDB()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select b.Title, ci.DueDate as 'Due Date', ci.RenewalCount as 'Renewal Count', " +
                                "ci.RenewedDate as 'Renewed Date', m.MemberID as 'Member ID', m.Fname + ' ' + m.Lname as 'Member Name' " +
                                "from CHECKOUT c " +
                                "join checkout_item ci on ci.CheckoutID = c.CheckoutID " +
                                "join INVENTORY i on i.Barcode = ci.InventoryID " +
                                "join MEMBER m on m.MemberID = c.MemberID " +
                                "join BOOK b on b.ISBN = i.BookID " +
                                "where ci.ReturnedDate is null " +
                                "and ci.DueDate < @today " +
                                "order by ci.DueDate, m.MemberID, ci.RenewalCount";
            cmd.Parameters.AddWithValue("@today", DateTime.Now.Date);

            var dataTable = new DataTable();

            using (var reader = cmd.ExecuteReader())
            {
                dataTable.Load(reader);
            }

            gridResults.DataSource = dataTable;
        }
    }
}
