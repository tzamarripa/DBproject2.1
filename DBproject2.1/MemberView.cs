﻿using System;
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
    public partial class MemberView : Form
    {
        public SqlConnection DbConnection { get; set; }
        
        //details held when a member logs in
        private MemberDetails memberDetails;

        //results of a book search
        private ObservableCollection<BookSearchResult> searchResults;
        //reads changes to the book search to display them to the user
        private DataTable searchResultsDataTable;

        public MemberView()
        {
            InitializeComponent();
        }

        private void MemberView_Load(object sender, EventArgs e)
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
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    var result = (BookSearchResult)item;
                    searchResultsDataTable.Rows.Add(result.Title, result.Authors.GetNames(), result.PublishDate, result.ISBN);
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
        private void PopulateDetailsSection(BookSearchResult item)
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
        private int GetCheckoutCountForItem(BookSearchResult item)
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
        private void UpdateDetailsText(BookSearchResult item, int checkedOutCount)
        {
            txtDetailsTitle.Text = item.Title;
            txtDetailsAuthor.Text = item.Authors.GetNames();
            txtDetailsIsbn.Text = item.ISBN;
            txtDetailsPublishDate.Text = item.PublishDate;
            txtDetailsAvailable.Text = (item.Quantity - checkedOutCount).ToString();
            txtDetailsQuantity.Text = item.Quantity.ToString();
        }

        private void MemberView_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
            return (req.Title.Length < minChars && req.Author.Length < minChars);
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

            if(req.Title.Length > 0)
            {
                cmd.CommandText += " and upper(b.Title) like @title ";
                cmd.Parameters.AddWithValue("title", "%" + req.Title.ToUpper() + "%");
            }

            if(req.Author.Length > 0)
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

                    if(item == null)
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

                    item.Authors.Add(new Author() {
                        Firstname = reader.GetString(5),
                        MiddleInitial = (reader.IsDBNull(6) ? null : reader.GetString(6)),
                        Lastname = reader.GetString(7)
                    });
                }
            }

            foreach(var item in resultsHash.Values)
            {
                //this will fire the collection changed event
                searchResults.Add((BookSearchResult)item);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var form = new MemberLoginView())
            {
                form.DbConnection = DbConnection;

                var result = form.ShowDialog();

                if(result == DialogResult.OK)
                {
                    memberDetails = form.MemberDetails;

                    PopulateGroupMemberInfo();

                    groupButtonsNoLogin.Hide();
                    groupButtonLoggedIn.Show();
                    groupMemberInfo.Show();
                }
            }
        }

        private void PopulateGroupMemberInfo()
        {
            lblMemberInfoMemberId.Text = memberDetails.MemberId;
            lblMemberInfoName.Text = string.Format("{0} {1}", memberDetails.Firstname, memberDetails.Lastname);
            lblMemberInfoJoinDate.Text = memberDetails.JoinDate.ToString("MMM dd, yyyy");
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
}
