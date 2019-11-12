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
    public partial class MemberLoginView : Form
    {
        public SqlConnection DbConnection { get; set; }

        //details held when a member logs in
        public MemberDetails MemberDetails { get; set; }

        public MemberLoginView()
        {
            InitializeComponent();
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

            if (txtAccountId.Text.Length == 0)
            {
                setAccountIdError("value required");
            }
            else if (txtPassword.Text.Length == 0)
            {
                setPasswordError("value required");
            }
            else
            {
                var record = FindRecord();

                if (record == null)
                {
                    setAccountIdError("Record not found, please verify your credentials");
                }
                else
                {
                    MemberDetails = record;

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private MemberDetails FindRecord()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select memberid, fname, lname, joindate from MEMBER where memberid = @id and PasswordHash = @hash";
            cmd.Parameters.AddWithValue("id", txtAccountId.Text);
            cmd.Parameters.AddWithValue("hash", PasswordHasher.ToHash(txtPassword.Text));

            MemberDetails info = null;

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    info = new MemberDetails()
                    {
                        MemberId = reader.GetInt32(0).ToString(),
                        FirstName = reader.GetString(1),
                        Lastname = reader.GetString(2),
                        JoinDate = reader.GetDateTime(3)
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
