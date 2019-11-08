using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject2._1
{
    public partial class MemberView : Form
    {
        //details held when a member logs in
        private MemberDetails memberDetails;

        public MemberView()
        {
            InitializeComponent();
        }

        private void MemberView_Load(object sender, EventArgs e)
        {

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
        }

        private void ClearSearchInputs()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRequest req = new SearchRequest { Title = txtTitle.Text.Trim(), Author = txtAuthor.Text.Trim() };

            if(IsEmptySearch(req))
            {
                NotifySearchError("Title or Author is required");
            }
            else
            {
                var results = SearchForBooks(req);

                PopulateSearchResults();
            }
        }

        private void PopulateSearchResults()
        {
            //TODO: place the list in the DataSource

            groupSearchResults.Text = string.Format("Search Results: {0}", 0);

            groupSearchResults.Show();
            groupSelectionDetails.Hide();
        }

        private object SearchForBooks(SearchRequest req)
        {
            throw new NotImplementedException();

            //title, author, isbn, barcode, quantity total, quantity available
            //inventory, book, checkout_item
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
            string Title;
            string Author;
            string Isbn;
            string Barcode;
            int QuantityTotal;
            int QuantityAvailable;
        }
    }
}
