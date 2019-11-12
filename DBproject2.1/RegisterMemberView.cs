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
            fname.ResetText();
            lname.ResetText();
            dob.ResetText();
            street.ResetText();
            city.ResetText();
            state.ResetText();
            zipcode.ResetText();
        }

        private void register_Click(object sender, EventArgs e)
        {
            SqlCommand cmdRegister = DbConnection.CreateCommand();
            cmdRegister.CommandText = "INSERT INTO MEMBER (Fname, Lname,dob,joindate,street,city,state,zipcode) VALUES (@Fname, @Lname,@dob,@joindate,@street,@city,@state,@zipcode)";

            //cmdRegister.Parameters.AddWithValue("@memberID", .Text);
            cmdRegister.Parameters.AddWithValue("@Fname", fname.Text);
            cmdRegister.Parameters.AddWithValue("@Lname", lname.Text);
            cmdRegister.Parameters.AddWithValue("@dob", dob.Text);
            cmdRegister.Parameters.AddWithValue("@joindate", DateTime.Now);
            cmdRegister.Parameters.AddWithValue("@street", street.Text);
            cmdRegister.Parameters.AddWithValue("@city", city.Text);
            cmdRegister.Parameters.AddWithValue("@state", state.Text);
            cmdRegister.Parameters.AddWithValue("@zipcode", zipcode.Text);

            cmdRegister.ExecuteNonQuery();
            MessageBox.Show("1 customer added");
        }
    }
}
