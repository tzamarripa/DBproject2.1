using System;
using System.Collections;
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
    public partial class ManageInventoryView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        //results of a search
        private ObservableCollection<BookSearchResult> searchResults;
        //reads changes to the book search to display them to the user
        private DataTable searchResultsDataTable;

        public ManageInventoryView()
        {
            InitializeComponent();
        }

        public ManageInventoryView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void ManageInventoryView_Load(object sender, EventArgs e)
        {
            searchResults = new ObservableCollection<BookSearchResult>();
            searchResults.CollectionChanged += OnSearchResultsListChanged;

            searchResultsDataTable = new DataTable();
            //field to display within the grid
            searchResultsDataTable.Columns.Add("Title");
            searchResultsDataTable.Columns.Add("Author");
            searchResultsDataTable.Columns.Add("Publish Date");
            searchResultsDataTable.Columns.Add("ISBN");

            gridSearchResults.DataSource = searchResultsDataTable;

            gridSearchResults.CellDoubleClick += GridSearchResults_CellDoubleClick;
        }

        private void OnSearchResultsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //for every book added, display it in the grid
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    var result = (BookSearchResult)item;
                    searchResultsDataTable.Rows.Add(result.Title, result.Authors.GetNames(), result.PublishDate, result.ISBN);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                //user cleared the search results, so clear the grid
                searchResultsDataTable.Rows.Clear();
            }

            UpdateSearchResultsCountHeader();
        }
        /// <summary>
        /// Listener for when a user double-clicks a cell within the search result grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DisplayEditView(searchResults[e.RowIndex]);
            }
        }
        /// <summary>
        /// For the specified book, populate the Details section and ensure it is visible.
        /// </summary>
        /// <param name="item"></param>
        private void DisplayEditView(BookSearchResult item)
        {
            using (var form = new EditInventoryView())
            {
                form.DbConnection = DbConnection;
                form.Item = item;
                form.ShowDialog();
            }
        }

        private void UpdateSearchResultsCountHeader()
        {
            groupSearchResults.Text = string.Format("Search Results: {0}", searchResults.Count);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSearchInputs();
            ClearSearchOutputs();
        }
        private void ClearSearchInputs()
        {
            txtTitle.ResetText();
            txtAuthor.ResetText();
        }
        private void ClearSearchOutputs()
        {
            errorTitle.Clear();
            errorAuthor.Clear();

            searchResults.Clear();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearSearchOutputs();

            SearchRequest req = new SearchRequest { Title = txtTitle.Text.Trim(), Author = txtAuthor.Text.Trim() };

            if (ValidateSearch(req))
            {
                SearchForBooks(req);

                UpdateSearchResultsCountHeader();
            }
        }

        /// <summary>
        /// Query the DB for books matching the specified terms. Caller is expected to pre-validate that at least one term is populated.
        /// </summary>
        /// <param name="req"></param>
        private void SearchForBooks(SearchRequest req)
        {
            var cmd = DbConnection.CreateCommand();

            cmd.CommandText = "select b.ISBN, b.title, b.PublishDate, i.Barcode, i.Quantity, a.Fname, a.Minit, a.Lname " +
                                "from book b " +
                                "join inventory i on i.BookID = b.ISBN " +
                                "join book_author ba on ba.BookID = i.BookID " +
                                "join author a on a.id = ba.AuthorID " +
                                "where b.ISBN in ( " +
                                "    select distinct(b.ISBN) " +
                                "    from book b " +
                                "    join book_author ba on ba.BookID = i.BookID " +
                                "    join author a on a.id = ba.AuthorID " +
                                "    where 1 = 1 ";

            if (req.Title.Length > 0)
            {
                cmd.CommandText += " and upper(b.Title) like @title ";
                cmd.Parameters.AddWithValue("title", "%" + req.Title.ToUpper() + "%");
            }

            if (req.Author.Length > 0)
            {
                cmd.CommandText += " and(upper(a.Fname) like @author or upper(a.Lname) like @author)";
                cmd.Parameters.AddWithValue("author", "%" + req.Author.ToUpper() + "%");
            }

            //close the IN clause, set ordering
            cmd.CommandText += ") order by b.Title";

            Hashtable resultsHash = new Hashtable();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //this PK will be our hash key
                    var ISBN = reader.GetString(0);

                    var item = (BookSearchResult)resultsHash[ISBN];

                    if (item == null)
                    {
                        item = new BookSearchResult()
                        {
                            ISBN = ISBN,
                            Title = reader.GetString(1),
                            PublishDate = reader.GetDateTime(2).ToString("MMM dd, yyyy"),
                            Barcode = reader.GetString(3),
                            Quantity = reader.GetInt32(4),
                        };

                        resultsHash[ISBN] = item;
                    }

                    item.Authors.Add(new Author()
                    {
                        Firstname = reader.GetString(5),
                        MiddleInitial = (reader.IsDBNull(6) ? null : reader.GetString(6)),
                        Lastname = reader.GetString(7)
                    });
                }
            }

            foreach (var item in resultsHash.Values)
            {
                //this will fire the collection changed event
                searchResults.Add((BookSearchResult)item);
            }
        }

        private bool ValidateSearch(SearchRequest req)
        {
            bool valid = true;

            int minChars = Properties.Settings.Default.MEMBER_MIN_BOOK_SEARCH_CHARS;

            //if empty search
            if (string.IsNullOrEmpty(req.Title) && string.IsNullOrEmpty(req.Author))
            {
                errorTitle.SetError(txtTitle,"Title or Author is required");
                valid = false;
            } else
            {
                if (req.Title.Length > 0 && req.Title.Length < minChars)
                {
                    string message = string.Format("At least {0} characters are required", Properties.Settings.Default.MEMBER_MIN_BOOK_SEARCH_CHARS);
                    errorTitle.SetError(txtTitle, message);
                    valid = false;
                }
                
                if (req.Author.Length > 0 && req.Author.Length < minChars)
                {
                    string message = string.Format("At least {0} characters are required", Properties.Settings.Default.MEMBER_MIN_BOOK_SEARCH_CHARS);
                    errorAuthor.SetError(txtAuthor, message);
                    valid = false;
                }
            }

            return valid;
        }
    }

    /// <summary>
    /// Represents a search request generated by the user.
    /// </summary>
    class SearchRequest
    {
        internal String Title { get; set; }
        internal String Author { get; set; }
    }
}
