using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
    public partial class AddInventoryView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        private ObservableCollection<Author> authorList;

        private DataTable authorTable;

        public AddInventoryView()
        {
            InitializeComponent();
        }

        public AddInventoryView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void AddInventoryView_Load(object sender, EventArgs e)
        {
            authorList = new ObservableCollection<Author>();
            authorList.CollectionChanged += OnAuthorListChanged;

            authorTable = new DataTable();
            authorTable.Columns.Add("Firstname");
            authorTable.Columns.Add("Middle Initial");
            authorTable.Columns.Add("Lastname");

            gridAuthors.DataSource = authorTable;
            gridAuthors.RowsAdded += OnAuthorCountChanged;
            gridAuthors.RowsRemoved += OnAuthorCountChanged;
            gridAuthors.CellDoubleClick += GridAuthors_CellDoubleClick;

            SetInitialBookInputFocus();
        }

        //on double-click of an author, remove the row
        private void GridAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                authorList.RemoveAt(e.RowIndex);
            }
        }

        private void OnAuthorListChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //for every author added, display it in the grid
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    var result = (Author)item;
                    authorTable.Rows.Add(result.Firstname, result.MiddleInitial, result.Lastname);
                }
            }
            else if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                //removal of a single item is fine as the grid is not multiselect
                authorTable.Rows.RemoveAt(e.OldStartingIndex);
            }
            else if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                //user cleared the list, so clear the grid
                authorTable.Rows.Clear();
            }
        }

        private void SetInitialBookInputFocus()
        {
            txtTitle.Focus();
        }

        private void SetInitialAuthorInputFocus()
        {
            txtAuthorFirstname.Focus();
        }

        private void OnAuthorCountChanged(object sender, EventArgs e)
        {
            btnAddBook.Enabled = gridAuthors.Rows.Count > 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(ConfirmReset())
            {
                ResetAllFields();

                ClearAllErrors();

                SetInitialBookInputFocus();
            }
        }

        private void ResetAllFields()
        {
            //book
            txtTitle.ResetText();
            txtIsbn.ResetText();
            datePublishDate.ResetText();

            //inventory
            txtBarcode.ResetText();
            txtQuantity.ResetText();

            //author
            ResetAuthorInputFields();
            authorList.Clear();
        }

        private void ResetAuthorInputFields()
        {
            txtAuthorFirstname.ResetText();
            txtAuthorMiddleInitial.ResetText();
            txtAuthorLastname.ResetText();
        }

        private bool ConfirmReset()
        {
            var result = MessageBox.Show("Are you sure you want to reset all inputs?", "Confirm reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ClearBookAndInventoryErrors();

            if(ValidateInput())
            {
                SaveData();
                MessageBox.Show("Book added to inventory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetAllFields();
                SetInitialBookInputFocus();
            }
        }

        private void ClearBookAndInventoryErrors()
        {
            errorTitle.SetError(txtTitle, "");
            errorIsbn.SetError(txtIsbn, "");
            errorPublishedDate.SetError(datePublishDate, "");

            errorBarcode.SetError(txtBarcode, "");
            errorQuantity.SetError(txtQuantity, "");
        }

        private void ClearAllErrors()
        {
            ClearBookAndInventoryErrors();
            ClearAuthorErrors();
        }

        private bool ValidateInput()
        {
            bool valid = true;

            /* BOOK section */
            if(txtTitle.TextLength == 0)
            {
                errorTitle.SetError(txtTitle, "value required");
                valid = false;
            }
            
            if (txtIsbn.TextLength != 10)
            {
                errorIsbn.SetError(txtIsbn, "10 characters required");
                valid = false;
            } else if (IsbnExists(txtIsbn.Text))
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
            } else if (BarcodeExists(txtBarcode.Text))
            {
                errorBarcode.SetError(txtBarcode, "already exists");
                valid = false;
            }

            if(txtQuantity.TextLength == 0)
            {
                errorQuantity.SetError(txtQuantity, "value required");
                valid = false;
            } else if(!int.TryParse(txtQuantity.Text, out _))
            {
                errorQuantity.SetError(txtQuantity, "numeric values only");
                valid = false;
            } else if((int.Parse(txtQuantity.Text) <= 0))
            {
                errorQuantity.SetError(txtQuantity, "must be positive");
            }

            return valid;
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

        private bool SaveData()
        {
            bool success = false;

            using (var trans = DbConnection.BeginTransaction())
            {
                using (var cmd = DbConnection.CreateCommand())
                {
                    cmd.Transaction = trans;

                    //insert into BOOK
                    InsertBook(cmd);
                    cmd.Parameters.Clear();
                    
                    //insert into AUTHOR
                    List<int> authorIds = InsertAuthors(cmd);
                    cmd.Parameters.Clear();
                    
                    //insert into BOOK_AUTHOR
                    InsertBookAuthorRefs(cmd, authorIds);
                    cmd.Parameters.Clear();
                    
                    //insert into INVENTORY
                    InsertInventory(cmd);

                    trans.Commit();
                    success = true;
                }
            }

            return success;
        }

        private void InsertBook(SqlCommand cmd)
        {
            cmd.CommandText = "insert into BOOK (Isbn, Title, PublishDate, EnteredBy) values (@isbn, @title, @publishdate, @enteredby)";
            
            cmd.Parameters.AddWithValue("isbn", txtIsbn.Text);
            cmd.Parameters.AddWithValue("title", txtTitle.Text);
            cmd.Parameters.AddWithValue("publishdate", datePublishDate.Value.Date);
            cmd.Parameters.AddWithValue("enteredby", Account.ID);

            cmd.ExecuteNonQuery();
        }

        private List<int> InsertAuthors(SqlCommand cmd)
        {
            cmd.CommandText = "insert into AUTHOR (Fname, Minit, Lname) output inserted.ID values (@firstname, @middle, @lastname)";

            List<int> authorIds = new List<int>(authorList.Count);

            foreach (var author in authorList)
            {
                cmd.Parameters.AddWithValue("firstname", author.Firstname);

                if(author.MiddleInitial.Length == 0)
                {
                    cmd.Parameters.AddWithValue("middle", DBNull.Value);
                } else
                {
                    cmd.Parameters.AddWithValue("middle", author.MiddleInitial);
                }
                
                cmd.Parameters.AddWithValue("lastname", author.Lastname);

                //extract the auto-generated ID
                authorIds.Add((int)cmd.ExecuteScalar());

                cmd.Parameters.Clear();
            }

            return authorIds;
        }

        private void InsertBookAuthorRefs(SqlCommand cmd, List<int> authorIds)
        {
            cmd.CommandText = "insert into BOOK_AUTHOR (BookId, AuthorId) values (@BookId, @AuthorId)";
            
            foreach(var authorId in authorIds)
            {
                cmd.Parameters.AddWithValue("BookId", txtIsbn.Text);
                cmd.Parameters.AddWithValue("AuthorId", authorId);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
            }
        }

        private void InsertInventory(SqlCommand cmd)
        {
            cmd.CommandText = "insert into INVENTORY (Barcode, BookID, Quantity) values (@barcode, @bookid, @quantity)";
            
            cmd.Parameters.AddWithValue("barcode", txtBarcode.Text);
            cmd.Parameters.AddWithValue("bookid", txtIsbn.Text);
            cmd.Parameters.AddWithValue("quantity", txtQuantity.Text);

            cmd.ExecuteNonQuery();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            ClearAuthorErrors();

            if (ValidateAuthorInput())
            {
                AddAuthorToList();
                ResetAuthorInputFields();
                SetInitialAuthorInputFocus();
            }
        }

        private void ClearAuthorErrors()
        {
            errorFirstname.SetError(txtAuthorFirstname, "");
            errorMiddleInitial.SetError(txtAuthorMiddleInitial, "");
            errorLastname.SetError(txtAuthorLastname, "");
        }

        private bool ValidateAuthorInput()
        {
            bool valid = true;

            if(txtAuthorFirstname.TextLength == 0)
            {
                errorFirstname.SetError(txtAuthorFirstname, "value required");
                valid = false;
            }

            //middle initial is optional

            if (txtAuthorLastname.TextLength == 0)
            {
                errorLastname.SetError(txtAuthorLastname, "value required");
                valid = false;
            }

            return valid;
        }

        private void AddAuthorToList()
        {
            authorList.Add(new Author()
            {
                Firstname = txtAuthorFirstname.Text,
                MiddleInitial = txtAuthorMiddleInitial.Text,
                Lastname = txtAuthorLastname.Text
            });
        }
    }
}
