using System;
using System.Collections;
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
    public partial class MemberView : Form
    {
        public SqlConnection DbConnection { get; set; }
        
        //details held when a member logs in
        private MemberDetails memberDetails;

        //results of a book search
        private ObservableCollection<SearchResult> searchResults;
        //reads changes to the book search to display them to the user
        private DataTable searchResultsDataTable;

        public MemberView()
        {
            InitializeComponent();
        }

        private void MemberView_Load(object sender, EventArgs e)
        {
            searchResults = new ObservableCollection<SearchResult>();
            searchResults.CollectionChanged += OnSearchResultsListChanged;

            searchResultsDataTable = new DataTable();
            //field to display within the grid
            searchResultsDataTable.Columns.Add("Title");
            searchResultsDataTable.Columns.Add("Author");
            searchResultsDataTable.Columns.Add("PublishDate");
            searchResultsDataTable.Columns.Add("ISBN");

            gridSearchResults.DataSource = searchResultsDataTable;

            gridSearchResults.CellDoubleClick += GridSearchResults_CellDoubleClick;
        }

        private void OnSearchResultsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //for every book added, display it in the grid
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    var result = (SearchResult)item;
                    searchResultsDataTable.Rows.Add(result.Title, result.Author, result.PublishDate, result.ISBN);
                }
            } else if (e.Action == NotifyCollectionChangedAction.Reset)
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
            if(e.RowIndex >= 0)
            {
                PopulateDetailsSection(searchResults[e.RowIndex]);
            }
        }
        /// <summary>
        /// For the specified book, populate the Details section and ensure it is visible.
        /// </summary>
        /// <param name="item"></param>
        private void PopulateDetailsSection(SearchResult item)
        {
            int checkedOutCount = GetCheckoutCountForItem(item);
            UpdateDetailsText(item, checkedOutCount);

            groupSelectionDetails.Show();
        }
        /// <summary>
        /// Query the DB to determine how many of the specified book are currently checked out.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private int GetCheckoutCountForItem(SearchResult item)
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select count(*) from checkout_item where InventoryID = @barcode and ReturnedDate is null";
            cmd.Parameters.AddWithValue("barcode", item.Barcode);

            return (int)cmd.ExecuteScalar();

        }
        /// <summary>
        /// Populate the text fields within the Details section.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="checkedOutCount"></param>
        private void UpdateDetailsText(SearchResult item, int checkedOutCount)
        {
            txtDetailsTitle.Text = item.Title;
            txtDetailsAuthor.Text = item.Author;
            txtDetailsIsbn.Text = item.ISBN;
            txtDetailsPublishDate.Text = item.PublishDate;
            txtDetailsAvailable.Text = (item.Quantity - checkedOutCount).ToString();
            txtDetailsQuantity.Text = item.Quantity.ToString();
        }

        private void MemberView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// User clicked the Clear button, so clear all items related to search.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSearchInputs();
            ClearSearchOutputs();
            HideSearchGroups();
        }

        private void HideSearchGroups()
        {
            groupSearchResults.Hide();
            groupSelectionDetails.Hide();
        }

        private void ClearSearchOutputs()
        {
            lblSearchError.Text = "";
            searchResults.Clear();
        }

        private void ClearSearchInputs()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
        }
        /// <summary>
        /// User clicked the Search button, so query the DB for matching books.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearSearchOutputs();

            SearchRequest req = new SearchRequest { Title = txtTitle.Text.Trim(), Author = txtAuthor.Text.Trim() };

            if(IsEmptySearch(req))
            {
                NotifySearchError("Title or Author is required");
            } else if(IsSearchTooShort(req))
            {
                string message = string.Format("At least {0} characters are required", Properties.Settings.Default.MEMBER_MIN_BOOK_SEARCH_CHARS);
                NotifySearchError(message);
            }
            else
            {
                SearchForBooks(req);

                UpdateSearchResultsCountHeader();

                groupSearchResults.Show();
                groupSelectionDetails.Hide();
            }
        }

        private void UpdateSearchResultsCountHeader()
        {
            groupSearchResults.Text = string.Format("Search Results: {0}", searchResults.Count);
        }

        private bool IsSearchTooShort(SearchRequest req)
        {
            int minChars = Properties.Settings.Default.MEMBER_MIN_BOOK_SEARCH_CHARS;
            return (req.Title.Length < minChars && req.Author.Length < 3);
        }
        /// <summary>
        /// Query the DB for books matching the specified terms. Caller is expected to pre-validate that at least one term is populated.
        /// </summary>
        /// <param name="req"></param>
        private void SearchForBooks(SearchRequest req)
        {
            var cmd = DbConnection.CreateCommand();

            cmd.CommandText = "select title, author_fname, author_lname, PublishDate, ISBN, i.Barcode, i.Quantity " +
                                "from book join inventory i on i.BookID = ISBN where 1 = 1 ";

            if(req.Title.Length > 0)
            {
                cmd.CommandText += " and upper(Title) like @title ";
                cmd.Parameters.AddWithValue("title", "%" + req.Title.ToUpper() + "%");
            }

            if(req.Author.Length > 0)
            {
                cmd.CommandText += " and(upper(Author_Fname) like @author or upper(Author_Lname) like @author)";
                cmd.Parameters.AddWithValue("author", "%" + req.Author.ToUpper() + "%");
            }

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var item = new SearchResult()
                    {
                        Title = reader.GetString(0),
                        AuthorFirstname = reader.GetString(1),
                        AuthorLastname = reader.GetString(2),
                        PublishDate = reader.GetDateTime(3).ToString("MMM dd, yyyy"),
                        ISBN = reader.GetString(4),
                        Barcode = reader.GetString(5),
                        Quantity = reader.GetInt32(6)
                    };
                    //this will fire the collection changed event
                    searchResults.Add(item);
                }
            }
        }

        private void NotifySearchError(string message)
        {
            lblSearchError.Text = message;
        }
        /// <summary>
        /// Checks if the user left the search inputs empty.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        private bool IsEmptySearch(SearchRequest req)
        {
            return string.IsNullOrEmpty(req.Title) && string.IsNullOrEmpty(req.Author);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            memberDetails = null;
            groupButtonsNoLogin.Show();
            groupButtonLoggedIn.Hide();
            groupMemberInfo.Hide();
        }
        private void btnCheckoutHistory_Click(object sender, EventArgs e)
        {
            using (var form = new CheckoutHistoryView())
            {
                form.MemberDetails = memberDetails;
                form.DbConnection = DbConnection;
                form.ShowDialog(this);
            }
        }

        private void btnCurrentCheckouts_Click(object sender, EventArgs e)
        {
            using (var form = new CurrentCheckoutsView())
            {
                form.MemberDetails = memberDetails;
                form.DbConnection = DbConnection;
                form.ShowDialog(this);
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
        /// <summary>
        /// Represents a book that matched the user's search term(s).
        /// </summary>
        class SearchResult
        {
            internal string Title { get; set; }
            internal string AuthorFirstname { get; set; }
            internal string AuthorLastname { get; set; }
            internal string Author { get => string.Format("{0}, {1}", AuthorLastname, AuthorFirstname); }
            internal string PublishDate { get; set; }
            internal string ISBN { get; set; }
            internal string Barcode { get; set; }
            internal int Quantity { get; set; }
        }
    }
}
