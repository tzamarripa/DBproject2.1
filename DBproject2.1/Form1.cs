using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBproject2._1
{
    public partial class Form1 : Form
    {
        public SqlConnection DbConnection { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer f1 = new Customer();
            this.Hide();
            f1.ShowDialog();
        }

        private void Checkoutbutton_Click(object sender, EventArgs e)
        {
            Checkout f2 = new Checkout();
            f2.DbConnection = DbConnection;
            this.Hide();
            f2.ShowDialog();
        }

        private void Librarianbutton_Click(object sender, EventArgs e)
        {
            Librarian1 f3 = new Librarian1();
            this.Hide();
            f3.ShowDialog();
        }
    }
}
