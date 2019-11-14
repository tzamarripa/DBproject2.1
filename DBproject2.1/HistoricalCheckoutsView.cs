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
    public partial class HistoricalCheckoutsView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        private DataTable searchResultsTable;

        public HistoricalCheckoutsView()
        {
            InitializeComponent();
        }

        public HistoricalCheckoutsView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void HistoricalCheckoutsView_Load(object sender, EventArgs e)
        {
            searchResultsTable = new DataTable();

            gridSearchResults.DataSource = searchResultsTable;

            //default date range is last two weeks
            dateEnd.Value = DateTime.Now.Date;
            dateStart.Value = DateTime.Now.AddDays(-14).Date;
        }

        private void ClearSearchErrors()
        {
            errorStart.SetError(dateStart, "");
            errorEnd.SetError(dateEnd, "");
        }

        private bool ValidateInput()
        {
            bool invalid = false;

            if(dateStart.Value > dateEnd.Value)
            {
                errorEnd.SetError(dateEnd, "must be after start date");
                invalid = true;
            }

            return invalid;
        }

        private void SearchByDates(DateTime start, DateTime end)
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select b.Title, c.CheckoutDate as 'Checkout Date', ci.DueDate as 'Due Date', ci.RenewalCount as 'Renewal Count', " +
                                "ci.RenewedDate as 'Renewed Date', m.MemberID, m.Fname + ' ' + m.Lname as 'Member Name' " +
                                "from CHECKOUT c " +
                                "join checkout_item ci on ci.CheckoutID = c.CheckoutID " +
                                "join INVENTORY i on i.Barcode = ci.InventoryID " +
                                "join MEMBER m on m.MemberID = c.MemberID " +
                                "join BOOK b on b.ISBN = i.BookID " +
                                "where c.CheckoutDate <= @EndDate " +
                                "and c.CheckoutDate >= @StartDate " +
                                "order by c.CheckoutDate, ci.DueDate, m.MemberID";
            cmd.Parameters.AddWithValue("@StartDate", start.Date);
            cmd.Parameters.AddWithValue("@EndDate", end.Date);

            using (var reader = cmd.ExecuteReader())
            {
                searchResultsTable.Load(reader);
            }
        }

        private void PostSearchAction()
        {
            //update count label
            int recordCount = searchResultsTable.Rows.Count;
            groupSearchResults.Text = string.Format("Search results: {0}", recordCount);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearSearchErrors();

            searchResultsTable.Rows.Clear();

            //validate input
            if (!ValidateInput())
            {
                SearchByDates(dateStart.Value, dateEnd.Value);

                PostSearchAction();
            }
        }
    }
}
