using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Transactions;
using System.Collections;

namespace DBproject2._1
{
    public partial class CheckoutView : Form
    {
        public SqlConnection DbConnection { get; set; }

        //entity containing info during entire checkout process
        private CheckoutInfo checkoutInfo;

        public CheckoutView()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            checkoutInfo = new CheckoutInfo();

            gridSelections.DataSource = checkoutInfo.SelectedItems;
            gridReview.DataSource = checkoutInfo.SelectedItems;

            gridSelections.RowsAdded += SelectionCountChanged;
            gridSelections.RowsRemoved += SelectionCountChanged;

            TransitionToMemberLookup();
        }
        /// <summary>
        /// Event handler controlling the enablement of the Remove and
        /// Continue buttons within the group controlling item selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectionCountChanged(object sender, EventArgs args)
        {
            //disable removals for empty lists
            btnRemoveSelected.Enabled = gridSelections.Rows.Count > 0;
            //ensures user selected at least one item before continuing
            btnContinueSelections.Enabled = gridSelections.Rows.Count > 0;
        }

        private void btnClearLookup_Click(object sender, EventArgs e)
        {
            txtMemberId.Text = "";
            txtPassword.Text = "";

            txtMemberId.Focus();
        }

        private void btnMemberLookup_Click(object sender, EventArgs e)
        {
            ClearMemberSearchErrorMessages();

            if (ValidateLoginInfo())
            {
                MemberDetails matchedAccount = SearchForMember();

                if (matchedAccount == null)
                {
                    errorMemberId.SetError(txtMemberId, Properties.Resources.MEMBER_NOT_FOUND);
                }
                else
                {
                    checkoutInfo.Member = matchedAccount;
                    ResetBookSelection();

                    TransitionToBookInput();
                }
            }
        }

        private bool ValidateLoginInfo()
        {
            bool valid = true;

            if(!int.TryParse(txtMemberId.Text, out _))
            {
                errorMemberId.SetError(txtMemberId, Properties.Resources.MEMBER_ID_REQUIRED_NUMERIC);
                valid = false;
            }

            if(txtPassword.Text.Length == 0)
            {
                errorPassword.SetError(txtPassword, "value required");
                valid = false;
            }

            return valid;
        }

        private MemberDetails SearchForMember()
        {
            SqlCommand cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select MemberID, Fname, Lname, JoinDate from MEMBER where MemberID = @id and PasswordHash = @hash";
            cmd.Parameters.AddWithValue("id", txtMemberId.Text);
            cmd.Parameters.AddWithValue("hash", PasswordHasher.ToHash(txtPassword.Text));

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new MemberDetails()
                    {
                        MemberId = reader.GetInt32(0).ToString(),
                        Firstname = reader.GetString(1),
                        Lastname = reader.GetString(2),
                        JoinDate = reader.GetDateTime(3)
                };
                } else { return null; }
            }
        }

        private void ClearMemberSearchErrorMessages()
        {
            errorMemberId.SetError(txtMemberId, "");
            errorPassword.SetError(txtPassword, "");
        }

        private void ClearMemberLookup()
        {
            txtMemberId.ResetText();
            txtPassword.ResetText();
            ClearMemberSearchErrorMessages();
        }

        private void TransitionToBookInput()
        {
            HideAllGroups();

            groupChooseBooks.Show();
        }

        private void HideAllGroups()
        {
            groupMemberLookup.Hide();
            groupChooseBooks.Hide();
            groupReview.Hide();
        }

        private void ResetBookSelection()
        {
            lblMemberHeader.Text = string.Format(Properties.Resources.CHECKOUT_MEMBER_HEADER, checkoutInfo.Member.Firstname);

            txtBarcode.Text = "";
            lblBarcodeError.Text = "";

            //clear previous selections
            checkoutInfo.SelectedItems.Rows.Clear();
        }
        
        private void btnCancelSelections_Click(object sender, EventArgs e)
        {
            CancellationRequested();
        }

        private void CancellationRequested()
        {
            //confirm
            var result = MessageBox.Show(Properties.Resources.CHECKOUT_CANCEL_CONFIRMATION_TEXT, Properties.Resources.CHECKOUT_CANCEL_CONFIRMATION_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                TransitionToMemberLookup();
            }
        }

        private void TransitionToMemberLookup()
        {
            checkoutInfo.Reset();

            ClearMemberLookup();

            HideAllGroups();

            groupMemberLookup.Show();
        }

        private void btnContinueSelections_Click(object sender, EventArgs e)
        {
            if (gridSelections.Rows.Count == 0)
            {
                MessageBox.Show("You must select at least one item", "Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransitionToReview();
            }
        }

        private void TransitionToReview()
        {
            ClearReview();

            checkoutInfo.DueDate = DateTime.Now.AddDays(Properties.Settings.Default.DEFAULT_CHECKOUT_DAYS);

            lblDueDate.Text = string.Format("To be returned: {0: MMMM dd, yyyy}", checkoutInfo.DueDate);

            HideAllGroups();

            groupReview.Show();
        }

        private void ClearReview()
        {
            //nothing to clear yet
        }

        private void btnAddBarcode_Click(object sender, EventArgs e)
        {
            lblBarcodeError.Hide();

            string barcode = txtBarcode.Text.Trim().ToUpper();

            if(string.IsNullOrEmpty(barcode))
            {
                NotifySelectionError(Properties.Resources.BARCODE_REQUIRED);
            } else if(!IsValidBarcode(barcode))
            {
                NotifySelectionError(Properties.Resources.ALPHANUMERIC_CHARS_ONLY);
            } else
            {
                CheckoutItem item = FindByBarcode(barcode);

                if(item == null)
                {
                    NotifySelectionError("Item not found");
                } else if(IsItemInSelectionList(item))
                {
                    NotifySelectionError("Item already added");
                } else
                {
                    checkoutInfo.AddItem(item);

                    txtBarcode.Text = "";
                }
            }
        }

        private bool IsItemInSelectionList(CheckoutItem item)
        {
            //attempt to match the item's barcode to any others already in the collection
            return checkoutInfo.SelectedItems.AsEnumerable().Where(s => s.Field<string>("Barcode").Equals(item.Barcode)).Any();
        }

        private CheckoutItem FindByBarcode(string barcode)
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select b.ISBN, b.Title, a.ID, a.Fname, a.Minit, a.Lname "+
                                "from BOOK b " +
                                "join INVENTORY i on i.BookID = b.ISBN " +
                                "join BOOK_AUTHOR ba on ba.BookID = b.ISBN " +
                                "join AUTHOR a on a.ID = ba.AuthorID " +
                                "where barcode = @barcode";
            cmd.Parameters.AddWithValue("barcode", barcode);
            Hashtable t = new Hashtable();

            string ISBN = null;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ISBN = reader.GetString(0);

                    var item = (CheckoutItem)t[ISBN];

                    if(item == null)
                    {
                        item = new CheckoutItem
                        {
                            ISBN = ISBN,
                            Title = reader.GetString(1),
                            Barcode = barcode
                        };

                        t.Add(ISBN, item);
                    }

                    item.Authors.Add(new Author()
                    {
                        ID = reader.GetInt32(2),
                        Firstname = reader.GetString(3),
                        MiddleInitial = (reader.IsDBNull(4) ? null : reader.GetString(4)),
                        Lastname = reader.GetString(5)
                    });
                }
            }

            return (ISBN == null ? null : (CheckoutItem)t[ISBN]);
        }

        private void NotifySelectionError(string message)
        {
            lblBarcodeError.Text = message;
            lblBarcodeError.Show();
        }

        private bool IsValidBarcode(string barcode)
        {
            return barcode.All(char.IsLetterOrDigit);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            int index = gridSelections.CurrentRow.Index;

            if(index >= 0)
            {
                checkoutInfo.RemoveItem(index);
            }
        }

        private void btnCancelCheckout_Click(object sender, EventArgs e)
        {
            CancellationRequested();
        }

        private void btnEditSelection_Click(object sender, EventArgs e)
        {
            TransitionToBookInput();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (SaveCheckout())
            {
                TransitionToMemberLookup();
            }
        }

        private bool SaveCheckout()
        {
            bool success = false;

            try
            {
                using (var trans = DbConnection.BeginTransaction())
                {
                    using (var cmd = DbConnection.CreateCommand())
                    {
                        cmd.Transaction = trans;

                        //create checkout entry
                        int checkoutId = InsertCheckout(cmd);
                        //for each item, create checkout_item entry
                        InsertSelectedItems(cmd, checkoutId, checkoutInfo.DueDate);

                        trans.Commit();
                        success = true;
                    }
                }
            } catch(SqlException e)
            {
                MessageBox.Show("Failed to save checkout to DB. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }

        private int InsertCheckout(SqlCommand cmd)
        {
            cmd.CommandText = "insert into CHECKOUT (MemberID, CheckoutDate) output inserted.CheckoutID values (@MemberId, @date)";
            cmd.Parameters.AddWithValue("MemberId", checkoutInfo.Member.MemberId);
            cmd.Parameters.AddWithValue("date", DateTime.Now);

            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        private void InsertSelectedItems(SqlCommand cmd, int checkoutId, DateTime dueDate)
        {
            cmd.CommandText = "insert into checkout_item (CheckoutID, InventoryID, DueDate, RenewalCount) values (@CheckoutID, @InventoryID, @DueDate, 0)";

            foreach (var selection in checkoutInfo.Selections)
            {
                cmd.Parameters.AddWithValue("CheckoutID", checkoutId);
                cmd.Parameters.AddWithValue("InventoryID", selection.Barcode);
                cmd.Parameters.AddWithValue("DueDate", dueDate);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
            }
        }

        class CheckoutItem
        {
            internal string ISBN { get; set; }
            internal string Title { get; set; }
            internal string AuthorNames { get
                {
                    return string.Join(", ", Authors.Select(a => a.FriendlyName));
                }
            }
            internal string Barcode { get; set; }
            internal List<Author> Authors { get; set; }

            public CheckoutItem()
            {
                //default for two authors
                Authors = new List<Author>(2);
            }
        }

        class CheckoutInfo
        {
            internal MemberDetails Member { get; set; }

            internal List<CheckoutItem> Selections { get; }
            internal DataTable SelectedItems { get; }
            internal DateTime DueDate { get; set; }

            public CheckoutInfo()
            {
                Selections = new List<CheckoutItem>();
                
                SelectedItems = new DataTable("Selected Items");
                
                SelectedItems.Columns.Add("Title");
                SelectedItems.Columns.Add("Author(s)");
                SelectedItems.Columns.Add("ISBN");
                SelectedItems.Columns.Add("Barcode");

                Reset();
            }

            internal void AddItem(CheckoutItem item)
            {
                Selections.Add(item);
                SelectedItems.Rows.Add(item.Title, item.AuthorNames, item.ISBN, item.Barcode);
            }

            internal void RemoveItem(int index)
            {
                Selections.RemoveAt(index);
                SelectedItems.Rows.RemoveAt(index);
            }

            internal void Reset()
            {
                Member = new MemberDetails();
                DueDate = DateTime.Now;

                Selections.Clear();
                SelectedItems.Rows.Clear();
            }
        }
    }
}
