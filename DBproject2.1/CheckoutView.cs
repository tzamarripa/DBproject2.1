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

namespace DBproject2._1
{
    public partial class Checkout : Form
    {
        public SqlConnection DbConnection { get; set; }

        //entity containing info during entire checkout process
        private CheckoutInfo checkoutInfo;

        public Checkout()
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

        private void btnMemberLookup_Click(object sender, EventArgs e)
        {
            ClearMemberSearchErrorMessages();

            String memberId = txtMemberId.Text;

            if(!IsNumeric(memberId))
            {
                NotifyNonNumericMemberId();
            } else
            {
                MemberInfo memberInfo = FindMemberById(memberId);

                if(memberInfo == null)
                {
                    NotifyMemberNotFound();
                } else
                {
                    checkoutInfo.Member = memberInfo;
                    ResetBookSelection();

                    TransitionToBookInput();
                }
            }
        }

        private MemberInfo FindMemberById(string memberId)
        {
            SqlCommand cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select MemberID, Fname, Lname from MEMBER where MemberID = @id";
            cmd.Parameters.AddWithValue("id", memberId);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new MemberInfo(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2));
                } else { return null; }
            }
        }

        private void ClearMemberSearchErrorMessages()
        {
            lblMemberIdError.Text = "";
        }

        private bool IsNumeric(string s)
        {
            return int.TryParse(s, out _);
        }

        private void NotifyNonNumericMemberId()
        {
            lblMemberIdError.Text = Properties.Resources.MEMBER_ID_REQUIRED_NUMERIC;
            lblMemberIdError.Show();
        }

        private void NotifyMemberNotFound()
        {
            lblMemberIdError.Text = Properties.Resources.MEMBER_NOT_FOUND;
            lblMemberIdError.Show();
        }

        private void ClearMemberLookup()
        {
            txtMemberId.Text = "";
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
            groupReview.Hide();
            groupChooseBooks.Hide();
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
            cmd.CommandText = "select ISBN, Title, Author_Fname, Author_Lname from BOOK join INVENTORY on ISBN = BookID where barcode = @barcode";
            cmd.Parameters.AddWithValue("barcode", barcode);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    CheckoutItem item = new CheckoutItem
                    {
                        ISBN = reader.GetString(0),
                        Title = reader.GetString(1),
                        AuthorName = string.Format("{1}, {0}", reader.GetString(2), reader.GetString(3)),
                        Barcode = barcode
                    };

                    return item;
                }
                else
                {
                    return null;
                }
            }
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
            internal string AuthorName { get; set; }
            internal string Barcode { get; set; }
        }

        class MemberInfo
        {
            internal string MemberId { get; }
            internal string Firstname { get; }
            internal string Lastname { get; }

            public MemberInfo() { }

            public MemberInfo(string memberId, string firstname, string lastname)
            {
                MemberId = memberId;
                Firstname = firstname;
                Lastname = lastname;
            }
        }

        class CheckoutInfo
        {
            internal MemberInfo Member { get; set; }

            internal List<CheckoutItem> Selections { get; }
            internal DataTable SelectedItems { get; }
            internal DateTime DueDate { get; set; }

            public CheckoutInfo()
            {
                Selections = new List<CheckoutItem>();
                
                SelectedItems = new DataTable("Selected Items");
                
                SelectedItems.Columns.Add("Title");
                SelectedItems.Columns.Add("Author");
                SelectedItems.Columns.Add("ISBN");
                SelectedItems.Columns.Add("Barcode");

                Reset();
            }

            internal void AddItem(CheckoutItem item)
            {
                Selections.Add(item);
                SelectedItems.Rows.Add(item.Title, item.AuthorName, item.ISBN, item.Barcode);
            }

            internal void RemoveItem(int index)
            {
                Selections.RemoveAt(index);
                SelectedItems.Rows.RemoveAt(index);
            }

            internal void Reset()
            {
                Member = new MemberInfo();
                DueDate = DateTime.Now;

                Selections.Clear();
                SelectedItems.Rows.Clear();
            }
        }
    }
}
