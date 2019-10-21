using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBproject2._1
{
    public partial class Checkout : Form
    {
        public SqlConnection DbConnection { get; set; }

        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void Checkout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnContinueMemberId_Click(object sender, EventArgs e)
        {
            hideMemberSearchErrorMessages();

            String memberId = txtMemberId.Text;

            if(!isNumeric(memberId))
            {
                notifyNonNumericMemberId();
            } else
            {
                if (isValidMember(memberId))
                {
                    transitionToBookInput();
                }
                else
                {
                    notifyMemberNotFound();
                }
            }
        }

        private bool isNumeric(string s)
        {
            return int.TryParse(s, out int x);
        }

        private void notifyNonNumericMemberId()
        {
            lblMemberIdError.Text = Properties.Resources.MEMBER_ID_REQUIRED_NUMERIC;
            lblMemberIdError.Show();
        }

        private void notifyMemberNotFound()
        {
            lblMemberIdError.Text = Properties.Resources.MEMBER_NOT_FOUND;
            lblMemberIdError.Show();
        }

        private void hideMemberSearchErrorMessages()
        {
            lblMemberIdError.Text = "";
            lblMemberIdError.Hide();
        }

        private void transitionToBookInput()
        {
            txtMemberId.Text = "";
            hideMemberSearchErrorMessages();

            groupMemberId.Hide();
        }

        private bool isValidMember(string memberId)
        {
            SqlCommand cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select count(*) from MEMBER where MemberID = @id";
            cmd.Parameters.AddWithValue("id", memberId);
            
            int result = (int)cmd.ExecuteScalar();

            return result > 0;
        }
    }
}
