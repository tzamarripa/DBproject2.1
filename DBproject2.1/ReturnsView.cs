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
    public partial class ReturnsView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        public ReturnsView()
        {
            InitializeComponent();
        }

        public ReturnsView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void ReturnsView_Load(object sender, EventArgs e)
        {
            SetFocusToBarcodeInput();
        }

        private void SetFocusToBarcodeInput()
        {
            txtBarcode.Focus();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ClearErrorErrors();

            if (ValidateInput())
            {
                var matchingCheckouts = GetCurrentCheckoutsByBarcode();

                if(matchingCheckouts.Count == 0)
                {
                    MessageBox.Show("No checkouts contain that barcode", "No matches", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    //select the barcode text and give it focus
                    txtBarcode.Select(0, txtBarcode.TextLength);
                    txtBarcode.Focus();
                } else
                {
                    //if more than one, give to oldest checkout
                    var matchingCheckout = matchingCheckouts[0];

                    DateTime receptionTime = DateTime.Now;
                    
                    if(ReceiveItem(matchingCheckout, receptionTime))
                    {
                        LogReceive(matchingCheckout, receptionTime);
                        ClearInputs();
                        SetFocusToBarcodeInput();
                    } else
                    {
                        MessageBox.Show("Failed to update database, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LogReceive(CheckoutMatch item, DateTime receptionTime)
        {
            var message = string.Format("[{0:dd/MM/yyyy hh:mm:ss}] Received barcode '{1}' for member #{2}, initial check out was {3:dd/MM/yyyy}.\n", receptionTime, item.InventoryId, item.MemberId, item.CheckoutDate);
            richLog.AppendText(message);
            //ensure the latest message is viewable
            richLog.ScrollToCaret();
        }

        private bool ReceiveItem(CheckoutMatch item, DateTime returnTime)
        {
            int rowsAffected = 0;

            using (var cmd = DbConnection.CreateCommand())
            {
                cmd.CommandText = "update CHECKOUT_ITEM " +
                                    "set ReturnedDate = @ReturnDate " +
                                    "where CheckoutID = @CheckoutID " +
                                    "and InventoryID = @InventoryID " +
                                    "and ReturnedDate is null";

                cmd.Parameters.AddWithValue("ReturnDate", returnTime);
                cmd.Parameters.AddWithValue("CheckoutID", item.CheckoutId);
                cmd.Parameters.AddWithValue("InventoryID", item.InventoryId);

                rowsAffected = cmd.ExecuteNonQuery();
            }

            return 1 == rowsAffected;
        }

        private List<CheckoutMatch> GetCurrentCheckoutsByBarcode()
        {
            List<CheckoutMatch> results = new List<CheckoutMatch>();

            using (var cmd = DbConnection.CreateCommand())
            {
                cmd.CommandText = "select c.CheckoutDate, c.MemberID, ci.CheckoutID, ci.InventoryID " +
                                    "from checkout c " +
                                    "join checkout_item ci on ci.CheckoutID = c.CheckoutID " +
                                    "where ReturnedDate is null " +
                                    "and ci.InventoryID = @barcode " +
                                    "order by c.CheckoutDate asc, c.MemberID asc";

                cmd.Parameters.AddWithValue("barcode", txtBarcode.Text);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new CheckoutMatch()
                        {
                            CheckoutDate = reader.GetDateTime(0),
                            MemberId = reader.GetInt32(1),
                            CheckoutId = reader.GetInt32(2),
                            InventoryId = reader.GetString(3)
                        });
                    }
                }
            }

            return results;
        }

        private bool ValidateInput()
        {
            bool valid = true;

            if(txtBarcode.TextLength == 0)
            {
                errorBarcode.SetError(txtBarcode, "value required");
                valid = false;
            }

            return valid;
        }

        private void ClearInputs()
        {
            txtBarcode.ResetText();
        }

        private void ClearErrorErrors()
        {
            errorBarcode.Clear();
        }

        private class CheckoutMatch
        {
            public DateTime CheckoutDate { get; internal set; }
            public int MemberId { get; internal set; }
            public int CheckoutId { get; internal set; }
            public string InventoryId { get; internal set; }
        }
    }
}
