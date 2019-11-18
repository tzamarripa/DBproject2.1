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
    public partial class EditInventoryView : Form
    {
        public SqlConnection DbConnection { get; internal set; }
        public BookSearchResult Item { get; set; }

        private LibrarianAccount Librarian { get; set; }

        private DataTable authorTable;

        public EditInventoryView()
        {
            InitializeComponent();
        }

        private void EditInventoryView_Load(object sender, EventArgs e)
        {
            authorTable = new DataTable();
            authorTable.Columns.Add("Firstname");
            authorTable.Columns.Add("Middle Initial");
            authorTable.Columns.Add("Lastname");

            foreach(var author in Item.Authors)
            {
                authorTable.Rows.Add(author.Firstname, author.MiddleInitial, author.Lastname);
            }

            gridAuthors.DataSource = authorTable;

            Librarian = GetAssociatedLibrarian();

            PopulateFields();

            SetInitialBookInputFocus();
        }

        private void SetInitialBookInputFocus()
        {
            txtTitle.Focus();
        }

        private void PopulateFields()
        {
            txtTitle.Text = Item.Title;
            txtIsbn.Text = Item.ISBN;
            datePublishDate.Value = DateTime.Parse(Item.PublishDate);

            txtBarcode.Text = Item.Barcode;
            txtQuantity.Text = Item.Quantity.ToString();
        }

        private LibrarianAccount GetAssociatedLibrarian()
        {
            using (var cmd = DbConnection.CreateCommand())
            {
                cmd.CommandText = "select l.Fname, l.Lname " +
                                    "from LIBRARIAN l " +
                                    "join BOOK b on b.EnteredBy = l.ID " +
                                    "where b.ISBN = @isbn";
                cmd.Parameters.AddWithValue("isbn", Item.ISBN);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new LibrarianAccount()
                        {
                            Firstname = reader.GetString(0),
                            Lastname = reader.GetString(1)
                        };
                    }
                }
            }

            return null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (ConfirmReset())
            {
                PopulateFields();

                ClearErrors();

                SetInitialBookInputFocus();
            }
        }

        private void ClearErrors()
        {
            errorTitle.Clear();
            errorIsbn.Clear();
            errorPublishedDate.Clear();

            errorBarcode.Clear();
            errorQuantity.Clear();
        }

        private bool ConfirmReset()
        {
            var result = MessageBox.Show("Are you sure you want to reset all inputs?", "Confirm reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearErrors();

            if (ValidateInput())
            {
                SaveData();
                
                MessageBox.Show("Inventory item updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Close();
            }
        }

        private void SaveData()
        {
            using (var trans = DbConnection.BeginTransaction())
            {
                using (var cmd = DbConnection.CreateCommand())
                {
                    cmd.Transaction = trans;

                    UpdateBook(cmd);
                    cmd.Parameters.Clear();
                    UpdateInventory(cmd);

                    trans.Commit();
                }
            }
        }

        private void UpdateBook(SqlCommand cmd)
        {
            cmd.CommandText = "update BOOK set Title = @Title, Isbn = @Isbn, PublishDate = @PublishDate where Isbn = @OriginalIsbn";

            cmd.Parameters.AddWithValue("Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("Isbn", txtIsbn.Text);
            cmd.Parameters.AddWithValue("PublishDate", datePublishDate.Value.Date);
            cmd.Parameters.AddWithValue("OriginalIsbn", Item.ISBN);

            cmd.ExecuteNonQuery();
        }

        private void UpdateInventory(SqlCommand cmd)
        {
            cmd.CommandText = "";

            cmd.CommandText = "update INVENTORY set Barcode = @Barcode, Quantity = @Quantity where Barcode = @OriginalBarcode";

            cmd.Parameters.AddWithValue("Barcode", txtBarcode.Text);
            cmd.Parameters.AddWithValue("Quantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("OriginalBarcode", Item.Barcode);

            cmd.ExecuteNonQuery();
        }

        private bool ValidateInput()
        {
            bool valid = true;

            /* BOOK section */
            if (txtTitle.TextLength == 0)
            {
                errorTitle.SetError(txtTitle, "value required");
                valid = false;
            }

            if (txtIsbn.TextLength != 10)
            {
                errorIsbn.SetError(txtIsbn, "10 characters required");
                valid = false;
            }
            else if (!txtIsbn.Text.Equals(Item.ISBN) && IsbnExists(txtIsbn.Text))
            {
                errorIsbn.SetError(txtIsbn, "already exists");
                valid = false;
            }

            if (datePublishDate.Value.Date > DateTime.Now.Date)
            {
                errorPublishedDate.SetError(datePublishDate, "cannot be future date");
                valid = false;
            }

            /* INVENTORY section */
            if (txtBarcode.TextLength == 0)
            {
                errorBarcode.SetError(txtBarcode, "value required");
                valid = false;
            }
            else if (!txtBarcode.Text.Equals(Item.Barcode) && BarcodeExists(txtBarcode.Text))
            {
                errorBarcode.SetError(txtBarcode, "already exists");
                valid = false;
            }

            if (txtQuantity.TextLength == 0)
            {
                errorQuantity.SetError(txtQuantity, "value required");
                valid = false;
            }
            else
            {
                int quantity = 0;

                if (!int.TryParse(txtQuantity.Text, out quantity))
                {
                    errorQuantity.SetError(txtQuantity, "numeric values only");
                    valid = false;
                }
                else if (quantity <= 0)
                {
                    errorQuantity.SetError(txtQuantity, "must be positive");
                    valid = false;
                }
                else
                {
                    int currentCheckouts = GetCurrentCheckoutCount();

                    if (quantity < currentCheckouts)
                    {
                        string message = string.Format("{0} is/are currently checked out", currentCheckouts);
                        errorQuantity.SetError(txtQuantity, message);
                        valid = false;
                    }
                }
            }

            return valid;
        }

        private int GetCurrentCheckoutCount()
        {
            using (var cmd = DbConnection.CreateCommand())
            {
                cmd.CommandText = "select count(*) from CHECKOUT_ITEM where ReturnedDate is null and InventoryID = @InventoryID";
                cmd.Parameters.AddWithValue("InventoryID", Item.Barcode);

                return (int)cmd.ExecuteScalar();
            }
        }

        private bool BarcodeExists(string barcode)
        {
            using (var cmd = DbConnection.CreateCommand())
            {
                cmd.CommandText = "select count(*) from INVENTORY where Barcode = @barcode";
                cmd.Parameters.AddWithValue("barcode", barcode);

                return ((int)cmd.ExecuteScalar()) > 0;
            }
        }

        private bool IsbnExists(string isbn)
        {
            using (var cmd = DbConnection.CreateCommand())
            {
                cmd.CommandText = "select count(*) from BOOK where ISBN = @isbn";
                cmd.Parameters.AddWithValue("isbn", isbn);

                return ((int)cmd.ExecuteScalar()) > 0;
            }
        }
    }
}
