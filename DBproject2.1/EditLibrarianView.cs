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
    public partial class EditLibrarianView : Form
    {
        public SqlConnection DbConnection { get; set; }

        private string librarianId;

        public EditLibrarianView(string librarianId)
        {
            this.librarianId = librarianId;
            
            InitializeComponent();
        }

        private void EditLibrarianView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void LoadFromDB()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select fname, lname, street, city, state, zipcode, isadmin from LIBRARIAN where id = @id";
            cmd.Parameters.AddWithValue("id", librarianId);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtFirstname.Text = reader.GetString(0);
                    txtLastname.Text = reader.GetString(1);
                    txtStreet.Text = reader.GetString(2);
                    txtCity.Text = reader.GetString(3);
                    txtState.Text = reader.GetString(4);
                    txtZipcode.Text = reader.GetString(5);
                    checkIsAdmin.Checked = reader.GetBoolean(6);
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

        private bool SaveToDB()
        {
            var cmd = DbConnection.CreateCommand();

            cmd.CommandText = "update LIBRARIAN set fname = @firstname, lname = @lastname, street = @street, " +
                                "city = @city, state = @state, zipcode = @zipcode, isadmin = @isadmin ";

            cmd.Parameters.AddWithValue("firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("street", txtStreet.Text);
            cmd.Parameters.AddWithValue("city", txtCity.Text);
            cmd.Parameters.AddWithValue("state", txtState.Text);
            cmd.Parameters.AddWithValue("zipcode", txtZipcode.Text);
            cmd.Parameters.AddWithValue("isadmin", checkIsAdmin.Checked);

            cmd.CommandText += "where id = @id";
            cmd.Parameters.AddWithValue("id", librarianId);

            int rows = cmd.ExecuteNonQuery();

            return rows == 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Verify cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
