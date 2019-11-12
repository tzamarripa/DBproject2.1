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
    public partial class AddInventoryView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        public AddInventoryView()
        {
            InitializeComponent();
        }

        public AddInventoryView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            publishdate.ResetText();
            authorfname.ResetText();
            authorlname.ResetText();
        }

        private void addbook_Click(object sender, EventArgs e)
        {
            SqlCommand cmdbookadd = DbConnection.CreateCommand();
            cmdbookadd.CommandText = "INSERT INTO INVENTORY VALUES(@publishdate,@authorf, @authorl)";

            cmdbookadd.Parameters.AddWithValue("@publishdate", publishdate.Text);
            cmdbookadd.Parameters.AddWithValue("@authorf", authorfname.Text);
            cmdbookadd.Parameters.AddWithValue("@auhurl", authorlname.Text);

            cmdbookadd.ExecuteNonQuery();
            MessageBox.Show("1 book added");
        }

        private void addinventory_Click(object sender, EventArgs e)
        {
            SqlCommand add = DbConnection.CreateCommand();
            add.CommandText = "UPDATE INVENTORY SET Quantity=Quantity+1 WHERE Bookid=@bookid";

            add.Parameters.AddWithValue("@bookid", bookid.Text);


            add.ExecuteNonQuery();
            MessageBox.Show("1 book added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookid.ResetText();
        }
    }
}
