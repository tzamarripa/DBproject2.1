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
    public partial class ManageLibrarianAccountView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        public ManageLibrarianAccountView()
        {
            InitializeComponent();
        }

        public ManageLibrarianAccountView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void ManageLibrarianAccountView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void LoadFromDB()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select fname, lname, street, city, state, zipcode from LIBRARIAN where ID = @id";
            cmd.Parameters.AddWithValue("id", Account.ID);

            using (var reader = cmd.ExecuteReader())
            {
                if(reader.Read())
                {
                    txtFirstname.Text = reader.GetString(0);
                    txtLastname.Text = reader.GetString(1);
                    txtStreet.Text = reader.GetString(2);
                    txtCity.Text = reader.GetString(3);
                    txtState.Text = reader.GetString(4);
                    txtZipcode.Text = reader.GetString(5);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Verify cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearErrors();

            bool valErrors = ValidateInputs();

            if (!valErrors)
            {
                if (SaveToDB())
                {
                    MessageBox.Show("Record updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateAccountWithUpdatedInfo();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to save data, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopulateAccountWithUpdatedInfo()
        {
            //simplified as the only the name is used within the parent
            Account.Firstname = txtFirstname.Text;
            Account.Lastname = txtFirstname.Text;
        }

        private bool SaveToDB()
        {
            var cmd = DbConnection.CreateCommand();

            cmd.CommandText = "update LIBRARIAN set fname = @firstname, lname = @lastname, street = @street, " +
                                "city = @city, state = @state, zipcode = @zipcode ";
            
            if(checkBoxChangePassword.Checked)
            {
                cmd.CommandText += ", PasswordHash = @PasswordHash ";
                cmd.Parameters.AddWithValue("PasswordHash", PasswordHasher.ToHash(txtPassword.Text));
            }

            cmd.Parameters.AddWithValue("firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("street", txtStreet.Text);
            cmd.Parameters.AddWithValue("city", txtCity.Text);
            cmd.Parameters.AddWithValue("state", txtState.Text);
            cmd.Parameters.AddWithValue("zipcode", txtZipcode.Text);

            cmd.CommandText += "where ID = @id";
            cmd.Parameters.AddWithValue("id", Account.ID);

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
            errorPassword.SetError(txtPassword, "");
            errorConfirm.SetError(txtConfirm, "");
        }

        private bool ValidateInputs()
        {
            bool invalid = false;
            if (txtFirstname.TextLength == 0)
            {
                errorFirstname.SetError(txtFirstname, "value required");
                invalid = true;
            }
            if (txtLastname.TextLength == 0)
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

            if (txtZipcode.TextLength != 5)
            {
                errorZipcode.SetError(txtZipcode, "5 digits required");
            }
            else if (!int.TryParse(txtZipcode.Text, out _))
            {
                errorZipcode.SetError(txtZipcode, "numeric values only");
            }

            if (checkBoxChangePassword.Checked)
            {
                if (txtPassword.TextLength == 0)
                {
                    errorPassword.SetError(txtPassword, "value required");
                    invalid = true;
                }

                if (txtConfirm.TextLength == 0)
                {
                    errorConfirm.SetError(txtConfirm, "value required");
                    invalid = true;
                }

                if(txtConfirm.TextLength > 0 && txtConfirm.TextLength > 0 && !txtPassword.Text.Equals(txtConfirm.Text)) {
                    errorConfirm.SetError(txtConfirm, "values do not match");
                    invalid = true;
                }
            }

            return invalid;
        }

        private void checkBoxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordChangeEnabled(checkBoxChangePassword.Checked);
        }

        private void TogglePasswordChangeEnabled(bool state)
        {
            labelPassword.Enabled = state;
            labelConfirm.Enabled = state;
            txtPassword.Enabled = state;
            txtConfirm.Enabled = state;
        }
    }
}
