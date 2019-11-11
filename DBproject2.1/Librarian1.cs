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
    public partial class Librarian1 : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount LibrarianAccount { get; set; }

        public Librarian1()
        {
            InitializeComponent();
        }

        private void Librarian1_Load(object sender, EventArgs e)
        {

        }

        private void accountId_Validating(object sender, CancelEventArgs e)
        {
            if (txtAccountId.Text.Length > 0 && !int.TryParse(txtAccountId.Text, out _))
            {
                e.Cancel = true;
                setAccountIdError("numeric values only");
            }
        }

        private void accountId_Validated(object sender, EventArgs e)
        {
            setAccountIdError("");
        }

        private void setAccountIdError(string message)
        {
            errorAccountId.SetError(txtAccountId, message);
        }

        private void setPasswordError(string message)
        {
            errorPassword.SetError(txtPassword, message);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccountId.Text = "";
            txtPassword.Text = "";

            ResetErrorMessages();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ResetErrorMessages();

            if(txtAccountId.Text.Length == 0)
            {
                setAccountIdError("value required");
            } else if(txtPassword.Text.Length == 0)
            {
                setPasswordError("value required");
            } else
            {
                var record = FindRecord();

                if(record == null)
                {
                    setAccountIdError("Record not found, please verify your credentials");
                } else
                {
                    LibrarianAccount = record;

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private LibrarianAccount FindRecord()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select id, fname, lname, startdate, isadmin, street, city, state, zipcode, passwordhash from Librarian where id = @id and PasswordHash = @hash";
            cmd.Parameters.AddWithValue("id", txtAccountId.Text);
            cmd.Parameters.AddWithValue("hash", PasswordHasher.ToHash(txtPassword.Text));

            LibrarianAccount info = null;

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    info = new LibrarianAccount() {
                        ID = reader.GetInt32(0),
                        Firstname = reader.GetString(1),
                        Lastname = reader.GetString(2),
                        StartDate = reader.GetDateTime(3),
                        IsAdmin = reader.GetBoolean(4),
                        Street = reader.GetString(5),
                        City = reader.GetString(6),
                        State = reader.GetString(7),
                        ZipCode = reader.GetString(8),
                        PasswordHash = reader.GetString(9)
                    };
                }
            }
            
            return info;
        }

        private void ResetErrorMessages()
        {
            setAccountIdError("");
            setPasswordError("");
        }
    }
}
