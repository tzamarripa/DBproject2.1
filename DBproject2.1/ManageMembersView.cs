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
    public partial class ManageMembersView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        private DataTable searchResultsTable;

        public ManageMembersView()
        {
            InitializeComponent();
        }

        public ManageMembersView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void ManageMembersView_Load(object sender, EventArgs e)
        {
            searchResultsTable = new DataTable();

            gridSearchResults.DataSource = searchResultsTable;
            gridSearchResults.CellDoubleClick += GridSearchResults_CellDoubleClick;
        }

        private void GridSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var memberId = gridSearchResults.CurrentRow.Cells[0].Value.ToString();
                DisplayMemberEditView(memberId);
            }
        }

        private void DisplayMemberEditView(string memberId)
        {
            using(var form = new EditMemberView(memberId))
            {
                form.DbConnection = DbConnection;
                form.ShowDialog();
            }
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            ClearSearchErrors();

            searchResultsTable.Rows.Clear();

            //validate input
            if (!ValidateIdInput())
            {
                SearchById(txtMemberId.Text);

                PostSearchAction();
            }
        }

        private void ClearSearchErrors()
        {
            errorMemberId.SetError(txtMemberId, "");
            errorFirstname.SetError(txtFirstname, "");
            errorLastname.SetError(txtLastname, "");
        }

        private bool ValidateIdInput()
        {
            bool invalid = false;

            if(txtMemberId.TextLength == 0)
            {
                errorMemberId.SetError(txtMemberId, "value is required");
                invalid = true;
            } else if(!int.TryParse(txtMemberId.Text, out _))
            {
                errorMemberId.SetError(txtMemberId, "numeric values only");
                invalid = true;
            }

            return invalid;
        }

        private bool ValidateNameInput()
        {
            bool invalid = false;

            int firstnameLength = txtFirstname.TextLength;
            int lastnameLength = txtLastname.TextLength;

            int minChars = Properties.Settings.Default.MEMBER_NAME_SEARCH_MIN_CHARS;

            if (firstnameLength == 0 && lastnameLength == 0)
            {
                errorFirstname.SetError(txtFirstname, "at least one name is required");
                invalid = true;
            }
            else if (firstnameLength > 0 && firstnameLength < minChars)
            {
                errorFirstname.SetError(txtFirstname, minChars + " character minimum");
                invalid = true;
            }
            else if (lastnameLength > 0 && lastnameLength < minChars)
            {
                errorLastname.SetError(txtLastname, minChars + " character minimum");
                invalid = true;
            }

            return invalid;
        }

        private void SearchById(string id)
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "SELECT MemberID as ID, fname as Firstname, lname as Lastname, joindate as 'Join Date' FROM MEMBER WHERE MemberID = @id";
            cmd.Parameters.AddWithValue("@id", id);

            using (var reader = cmd.ExecuteReader())
            {
                searchResultsTable.Load(reader);
            }
        }

        private void SearchByName(string firstname, string lastname)
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "SELECT MemberID as ID, fname as Firstname, lname as Lastname, joindate as 'Join Date' FROM MEMBER WHERE 1=1 ";

            if (firstname.Length > 0)
            {
                cmd.CommandText += "and fname like @firstname ";
                cmd.Parameters.AddWithValue("@firstname", "%" + firstname + "%");
            }

            if (lastname.Length > 0)
            {
                cmd.CommandText += "and lname like @lastname ";
                cmd.Parameters.AddWithValue("@lastname", "%" + lastname + "%");
            }

            using (var reader = cmd.ExecuteReader())
            {
                searchResultsTable.Load(reader);
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            ClearSearchErrors();

            searchResultsTable.Rows.Clear();

            //validate input
            if (!ValidateNameInput())
            {
                SearchByName(txtFirstname.Text, txtLastname.Text);

                PostSearchAction();
            }
        }

        private void PostSearchAction()
        {
            //update count label
            int recordCount = searchResultsTable.Rows.Count;
            groupSearchResults.Text = string.Format("Search results: {0}", recordCount);

            if (recordCount == 0)
            {
                MessageBox.Show("No record matched your criteria", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
