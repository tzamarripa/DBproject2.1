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
    public partial class EditMemberView : Form
    {
        private string memberId;
        public SqlConnection DbConnection { get; set; }

        public EditMemberView(string memberId)
        {
            this.memberId = memberId;
            InitializeComponent();
        }

        private void EditMemberView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
            TogglePasswordChangeEnabled(false);
        }

        private void LoadFromDB()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select fname, lname, dob, street, city, state, zipcode from MEMBER where memberid = @id";
            cmd.Parameters.AddWithValue("id", memberId);

            using (var reader = cmd.ExecuteReader())
            {
                if(reader.Read())
                {
                    txtFirstname.Text = reader.GetString(0);
                    txtLastname.Text = reader.GetString(1);
                    dateDob.Value = reader.GetDateTime(2);
                    txtStreet.Text = reader.GetString(3);
                    txtCity.Text = reader.GetString(4);
                    txtState.Text = reader.GetString(5);
                    txtZipcode.Text = reader.GetString(6);
                }
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
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to save data, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearErrors()
        {
            errorFirstname.SetError(txtFirstname, "");
            errorLastname.SetError(txtLastname, "");
            errorDOB.SetError(dateDob, "");
            errorStreet.SetError(txtStreet, "");
            errorCity.SetError(txtCity, "");
            errorState.SetError(txtState, "");
            errorZipcode.SetError(txtZipcode, "");

            ClearPasswordRelatedErrors();
        }

        private void ClearPasswordRelatedErrors()
        {
            errorPassword.SetError(txtPassword, "");
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
            if (dateDob.Value.Date >= DateTime.Now.Date)
            {
                errorDOB.SetError(dateDob, "must be in the past");
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
                invalid = true;
            }
            else if (!int.TryParse(txtZipcode.Text, out _))
            {
                errorZipcode.SetError(txtZipcode, "numeric values only");
                invalid = true;
            }

            if (checkBoxChangePassword.Checked)
            {
                if (txtPassword.TextLength == 0)
                {
                    errorPassword.SetError(txtPassword, "value required");
                    invalid = true;
                }
            }

            return invalid;
        }

        private bool SaveToDB()
        {
            var cmd = DbConnection.CreateCommand();

            cmd.CommandText = "update MEMBER set fname = @firstname, lname = @lastname, street = @street, " +
                                "city = @city, state = @state, zipcode = @zipcode, dob = @dob ";

            if (checkBoxChangePassword.Checked)
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
            cmd.Parameters.AddWithValue("dob", dateDob.Value);

            cmd.CommandText += "where MemberID = @id";
            cmd.Parameters.AddWithValue("id", memberId);

            int rows = cmd.ExecuteNonQuery();

            return rows == 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Cancel edit?","Cancel confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void checkBoxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordChangeEnabled(checkBoxChangePassword.Checked);

            ClearPasswordRelatedErrors();
        }

        private void TogglePasswordChangeEnabled(bool state)
        {
            labelPassword.Enabled = state;
            txtPassword.Enabled = state;
            btnGeneratePassword.Enabled = state;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordGenerator.Generate();
        }
    }
}
