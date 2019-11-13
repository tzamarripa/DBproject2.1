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
    public partial class AddLibrarianView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        public AddLibrarianView()
        {
            InitializeComponent();
        }

        public AddLibrarianView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Verify cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearErrors();

            bool valErrors = ValidateInputs();

            if(!valErrors)
            {
                if(SaveToDB())
                {
                    MessageBox.Show("Record created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                } else
                {
                    MessageBox.Show("Failed to save data, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveToDB()
        {
            var cmd = DbConnection.CreateCommand();

            cmd.CommandText = "insert into LIBRARIAN (fname, lname, street, city, state, zipcode, startdate, passwordhash, isadmin) values (@firstname, @lastname, @street, @city, @state, @zipcode, @startdate, @passwordhash, @isadmin)";

            cmd.Parameters.AddWithValue("firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("street", txtStreet.Text);
            cmd.Parameters.AddWithValue("city", txtCity.Text);
            cmd.Parameters.AddWithValue("state", txtState.Text);
            cmd.Parameters.AddWithValue("zipcode", txtZipcode.Text);
            cmd.Parameters.AddWithValue("startdate", dateStartDate.Value);
            cmd.Parameters.AddWithValue("passwordhash", PasswordHasher.ToHash(txtPassword.Text));
            cmd.Parameters.AddWithValue("isadmin", checkIsAdmin.Checked);

            int rows = cmd.ExecuteNonQuery();

            return rows == 1;
        }

        private void ClearErrors()
        {
            errorFirstname.SetError(txtFirstname, "");
            errorLastname.SetError(txtLastname, "");
            errorStreet.SetError(txtStreet, "");
            errorCity.SetError(txtCity, "");
            errorState.SetError(txtState, "");
            errorZipcode.SetError(txtZipcode, "");
            errorStartDate.SetError(dateStartDate, "");
            errorPassword.SetError(txtPassword, "");
        }

        private bool ValidateInputs()
        {
            bool invalid = false;
            if(txtFirstname.TextLength == 0)
            {
                errorFirstname.SetError(txtFirstname, "value required");
                invalid = true;
            }
            if(txtLastname.TextLength == 0)
            {
                errorLastname.SetError(txtLastname, "value required");
                invalid = true;
            }
            if (txtStreet.TextLength == 0)
            {
                errorStreet.SetError(txtStreet, "value required");
                invalid = true;
            }
            if (txtCity.TextLength == 0)
            {
                errorCity.SetError(txtCity, "value required");
                invalid = true;
            }
            if (txtState.TextLength == 0)
            {
                errorState.SetError(txtState, "value required");
                invalid = true;
            }

            if(txtZipcode.TextLength != 5)
            {
                errorZipcode.SetError(txtZipcode, "5 digits required");
                invalid = true;
            } else if(!int.TryParse(txtZipcode.Text, out _))
            {
                errorZipcode.SetError(txtZipcode, "numeric values only");
                invalid = true;
            }

            if (dateStartDate.Value.Date > DateTime.Now.Date)
            {
                errorStartDate.SetError(dateStartDate, "cannot be in the future");
                invalid = true;
            }

            if (txtPassword.TextLength == 0)
            {
                errorPassword.SetError(txtPassword, "value required");
                invalid = true;
            }

            return invalid;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordGenerator.Generate();
        }
    }
}
