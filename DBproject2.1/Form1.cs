using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer f1 = new Customer();
            this.Hide();
            f1.ShowDialog();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Checkoutbutton_Click(object sender, EventArgs e)
        {
            Checkout f2 = new Checkout();
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
