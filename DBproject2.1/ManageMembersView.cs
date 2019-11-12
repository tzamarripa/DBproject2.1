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
    public partial class ManageMembersView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }

        public ManageMembersView()
        {
            InitializeComponent();
        }

        public ManageMembersView(SqlConnection connection, LibrarianAccount account)
        {
            DbConnection = connection;
            Account = account;

            InitializeComponent();
        }

        private void searchID_Click(object sender, EventArgs e)
        {


            SqlCommand cmdfindlibrarain = DbConnection.CreateCommand();
            cmdfindlibrarain.CommandText = "SELECT * FROM MEMBER WHERE MemberID like @id";
            cmdfindlibrarain.Parameters.AddWithValue("@id", int.Parse(customerid.Text));
            SqlDataReader reader = cmdfindlibrarain.ExecuteReader();

            DataTable tempTable = new DataTable();
            tempTable.Load(reader);
            int rowcount = tempTable.Rows.Count;
            count.Text = rowcount.ToString();
            //if the record that has the same ID as a user tyoed in the textbook

            if (rowcount >= 1)
            {
                dataGridView1.DataSource = tempTable;
            }
            else
            {
                MessageBox.Show("couldn't find,please try again");
                customerid.ResetText();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmdfindlibrarain = DbConnection.CreateCommand();
            cmdfindlibrarain.CommandText = "SELECT * FROM MEMBER WHERE Fname=@fname OR Lname=@lname";
            cmdfindlibrarain.Parameters.AddWithValue("@fname", firstname.Text);
            cmdfindlibrarain.Parameters.AddWithValue("@lname", lastname.Text);


            SqlDataReader reader = cmdfindlibrarain.ExecuteReader();
            if (reader != null)
            {
                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dataGridView1.DataSource = tempTable;
            }
            else
            {
                MessageBox.Show("couldn't find");
            }
        }
    }
}
