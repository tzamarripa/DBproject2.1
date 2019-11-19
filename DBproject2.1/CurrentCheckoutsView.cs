using System;
using System.Collections;
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
    public partial class CurrentCheckoutsView : Form
    {
        public MemberDetails MemberDetails { get; set; }
        public SqlConnection DbConnection { get; set; }

        private List<CheckoutItem> checkoutList;

        private readonly string DATE_COLUMN_FORMAT = "dd/MM/yyyy";

        private DataTable checkoutTable;
        
        public CurrentCheckoutsView()
        {
            InitializeComponent();
        }

        private void CurrentCheckoutsView_Load(object sender, EventArgs e)
        {
            checkoutList = new List<CheckoutItem>();

            checkoutTable = new DataTable();

            checkoutTable.Columns.Add("Checkout Date");
            checkoutTable.Columns.Add("Title");
            checkoutTable.Columns.Add("Author(s)");
            checkoutTable.Columns.Add("ISBN");
            checkoutTable.Columns.Add("Due Date");
            checkoutTable.Columns.Add("Renewals");

            gridCheckouts.DataSource = checkoutTable;

            gridCheckouts.SelectionChanged += GridCheckouts_SelectionChanged;

            RefreshFromDB();
        }

        private void RefreshFromDB()
        {
            checkoutList.Clear();
            checkoutTable.Rows.Clear();

            LoadFromDB();
            LoadDataTable();
        }

        private void GridCheckouts_SelectionChanged(object sender, EventArgs e)
        {
            //can be null when the list is cleared
            if(gridCheckouts.CurrentRow == null) {
                btnRenew.Enabled = false;
            } else
            {
                int rowIndex = gridCheckouts.CurrentRow.Index;

                btnRenew.Enabled = (rowIndex >= 0 && CanBeRenewed(rowIndex));
            }
        }

        private bool CanBeRenewed(int rowIndex)
        {
            return checkoutList[rowIndex].RenewalCount < Properties.Settings.Default.CHECKOUT_RENEWAL_LIMIT;
        }

        private void LoadDataTable()
        {
            foreach(var c in checkoutList)
            {
                checkoutTable.Rows.Add(
                    c.CheckedoutDate,
                    c.Title,
                    c.Authors.GetNames(),
                    c.ISBN,
                    c.DueDate,
                    c.RenewalCount
                );
            }
        }

        private void LoadFromDB()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select ci.InventoryID, c.CheckoutID, c.CheckoutDate, b.Title, b.ISBN, ci.DueDate, ci.RenewalCount, " +
                                "a.Fname, a.Minit, a.Lname " +
                                "from CHECKOUT c " +
                                "join CHECKOUT_ITEM ci on ci.CheckoutID = c.CheckoutID " +
                                "join INVENTORY i on i.Barcode = ci.InventoryID " +
                                "join BOOK b on b.ISBN = i.BookID " +
                                "join BOOK_AUTHOR ba on ba.BookID = b.ISBN " +
                                "join AUTHOR a on a.ID = ba.AuthorID " +
                                "where c.MemberID = @memberId " +
                                "and ReturnedDate is null " +
                                "order by c.CheckoutDate desc, Title desc";
            cmd.Parameters.AddWithValue("memberId", MemberDetails.MemberId);

            Hashtable recordHash = new Hashtable();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var InventoryID = reader.GetString(0);
                    var CheckoutID = reader.GetInt32(1);

                    var key = string.Format("{0}:{1}", InventoryID, CheckoutID);

                    var item = (CheckoutItem)recordHash[key];

                    if(item == null)
                    {
                        item = new CheckoutItem()
                        {
                            InventoryID = InventoryID,
                            CheckoutID = CheckoutID,
                            CheckedoutDate = reader.GetDateTime(2).ToString(DATE_COLUMN_FORMAT),
                            Title = reader.GetString(3),
                            ISBN = reader.GetString(4),
                            DueDate = reader.GetDateTime(5).ToString(DATE_COLUMN_FORMAT),
                            RenewalCount = reader.GetInt32(6)
                        };

                        recordHash[key] = item;
                    }

                    item.Authors.Add(new Author()
                    {
                        Firstname = reader.GetString(7),
                        MiddleInitial = (reader.IsDBNull(8) ? null : reader.GetString(8)),
                        Lastname = reader.GetString(9)
                    });
                }
            }

            foreach(var record in recordHash.Values)
            {
                checkoutList.Add((CheckoutItem)record);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            var item = checkoutList[gridCheckouts.CurrentRow.Index];

            var newDueDate = CalculateNewDueDate(item);
            string message = string.Format("Renew \"{0}\" with new due date {1:MMM dd, yyyy}?", item.Title, newDueDate);
            var result = MessageBox.Show(message, "Renewal confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                if(RenewItem(item, newDueDate))
                {
                    message = string.Format("Renewal complete. \"{0}\" is now due {1:MMM dd, yyyy}.", item.Title, newDueDate);
                    MessageBox.Show(message, "Renewed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshFromDB();
                } else
                {
                    MessageBox.Show("Unable to renew, please try again.", "Unable to renew", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DateTime CalculateNewDueDate(CheckoutItem item)
        {
            DateTime parsedDueDate = DateTime.ParseExact(item.DueDate, DATE_COLUMN_FORMAT, null);
            return parsedDueDate.AddDays(Properties.Settings.Default.DEFAULT_RENEWAL_DAYS);
        }

        private bool RenewItem(CheckoutItem item, DateTime newDueDate)
        {
            var cmd = DbConnection.CreateCommand();

            //be very specific on the match to ensure it wasn't updated ahead of us
            cmd.CommandText = "update CHECKOUT_ITEM set RenewalCount = @NewRenewalCount, DueDate = @NewDueDate, RenewedDate = @RenewedDate " +
                                "where CheckoutID = @CheckoutID and InventoryID = @InventoryID and RenewalCount = @RenewalCount and ReturnedDate is null";
            
            cmd.Parameters.AddWithValue("NewRenewalCount", item.RenewalCount + 1);
            cmd.Parameters.AddWithValue("NewDueDate", newDueDate);
            cmd.Parameters.AddWithValue("RenewedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("CheckoutID", item.CheckoutID);
            cmd.Parameters.AddWithValue("InventoryID", item.InventoryID);
            cmd.Parameters.AddWithValue("RenewalCount", item.RenewalCount);

            int recordsUpdated = cmd.ExecuteNonQuery();

            return recordsUpdated == 1;
        }

        class CheckoutItem
        {
            internal int CheckoutID { get; set; }
            internal string InventoryID { get; set; }
            internal string CheckedoutDate { get; set; }
            internal string Title { get; set; }
            internal List<Author> Authors { get; set; }
            internal string ISBN { get; set; }
            internal string DueDate { get; set; }
            internal int RenewalCount { get; set; }

            public CheckoutItem()
            {
                Authors = new List<Author>(2);
            }
        }
    }
}
