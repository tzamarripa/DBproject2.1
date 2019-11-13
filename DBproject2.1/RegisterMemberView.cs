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
    public partial class RegisterMemberView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        public RegisterMemberView()
        {
            InitializeComponent();
        }

        public RegisterMemberView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtFirstname.ResetText();
            txtLastname.ResetText();
            dateDob.ResetText();
            txtStreet.ResetText();
            txtCity.ResetText();
            txtState.ResetText();
            txtZipcode.ResetText();
        }

        private void register_Click(object sender, EventArgs e)
        {
            ClearErrors();

            bool valErrors = ValidateInputs();

            if (!valErrors)
            {
                string passwordPlaintext = PasswordGenerator.Generate();
                string passwordHash = PasswordHasher.ToHash(passwordPlaintext);

                if (SaveToDB(passwordHash))
                {
                    var message = string.Format("Record created, initial password: {0}", passwordPlaintext);
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(dateDob.Value.Date >= DateTime.Now.Date)
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

            return invalid;
        }

        private bool SaveToDB(string passwordHash)
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "INSERT INTO MEMBER (Fname, Lname,dob,joindate,street,city,state,zipcode,passwordhash) VALUES " +
                                "(@Fname, @Lname,@dob,@joindate,@street,@city,@state,@zipcode,@passwordhash)";

            cmd.Parameters.AddWithValue("@Fname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("@Lname", txtLastname.Text);
            cmd.Parameters.AddWithValue("@dob", dateDob.Value);
            cmd.Parameters.AddWithValue("@joindate", DateTime.Now);
            cmd.Parameters.AddWithValue("@street", txtStreet.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@state", txtState.Text);
            cmd.Parameters.AddWithValue("@zipcode", txtZipcode.Text);
            cmd.Parameters.AddWithValue("@passwordhash", passwordHash);

            return cmd.ExecuteNonQuery() == 1;
        }
    }
}
