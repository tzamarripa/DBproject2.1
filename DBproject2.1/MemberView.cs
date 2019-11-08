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
    public partial class MemberView : Form
    {
        public SqlConnection DbConnection { get; set; }
        
        //details held when a member logs in
        private MemberDetails memberDetails;

        private DataTable searchResults;

        public MemberView()
        {
            InitializeComponent();
        }

        private void MemberView_Load(object sender, EventArgs e)
        {
            searchResults = new DataTable();

            searchResults.Columns.Add("Title");
            searchResults.Columns.Add("Author");
            searchResults.Columns.Add("PublishDate");
            searchResults.Columns.Add("ISBN");

            gridSearchResults.DataSource = searchResults;

            gridSearchResults.CellDoubleClick += GridSearchResults_CellDoubleClick;
        }

        private void GridSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string isbn = GetIsbnOfSelectedRow(e.RowIndex);
            PopulateDetails(isbn);
        }

        private string GetIsbnOfSelectedRow(int rowIndex)
        {
            var row = gridSearchResults.Rows[rowIndex];
            var cell = row.Cells[3];
            return (string)cell.Value;
        }

        private void PopulateDetails(string isbn)
        {
            //var details = GetDetailsByISBN(isbn);
            //UpdateDetails(details);

            groupSelectionDetails.Show();
        }

        private void MemberView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

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
            searchResults.Rows.Clear();
        }

        private void ClearSearchInputs()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
        }

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
                var results = SearchForBooks(req);

                PopulateSearchResults(results);
            }
        }

        private bool IsSearchTooShort(SearchRequest req)
        {
            int minChars = Properties.Settings.Default.MEMBER_MIN_BOOK_SEARCH_CHARS;
            return (req.Title.Length < minChars && req.Author.Length < 3);
        }

        private void PopulateSearchResults(List<SearchResult> results)
        {
            foreach(var result in results)
            {
                searchResults.Rows.Add(result.Title, result.Author, result.PublishDate.ToString("MMM dd, yyyy"), result.ISBN);
            }

            groupSearchResults.Text = string.Format("Search Results: {0}", results.Count);

            groupSearchResults.Show();
            groupSelectionDetails.Hide();
        }

        private List<SearchResult> SearchForBooks(SearchRequest req)
        {
            var cmd = DbConnection.CreateCommand();

            cmd.CommandText = "select title, author_fname, author_lname, PublishDate, ISBN from book where 1 = 1 ";

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

            List<SearchResult> results = new List<SearchResult>();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    results.Add(new SearchResult()
                    {
                        Title = reader.GetString(0),
                        AuthorFirstname = reader.GetString(1),
                        AuthorLastname = reader.GetString(2),
                        PublishDate = reader.GetDateTime(3),
                        ISBN = reader.GetString(4)
                    });
                }
            }

            return results;
        }

        private void NotifySearchError(string message)
        {
            lblSearchError.Text = message;
        }

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

        class SearchRequest
        {
            internal String Title { get; set; }
            internal String Author { get; set; }
        }

        class MemberDetails
        {
            internal String MemberId { get; set; }
            internal String FirstName { get; set; }
            internal String Lastname { get; set; }
            internal DateTime JoinDate { get; set; }
        }

        class SearchResult
        {
            internal string Title { get; set; }
            internal string AuthorFirstname { get; set; }
            internal string AuthorLastname { get; set; }
            internal string Author { get => string.Format("{0}, {1}", AuthorLastname, AuthorFirstname); }
            internal DateTime PublishDate { get; set; }
            internal string ISBN { get; set; }
        }
    }
}
