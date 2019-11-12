﻿using System;
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
            using (MemberView form = new MemberView())
            {
                form.DbConnection = DbConnection;
                this.Hide();
                form.ShowDialog();
            }

            Close();
        }

        private void Checkoutbutton_Click(object sender, EventArgs e)
        {
            using (Checkout form = new Checkout())
            {
                form.DbConnection = DbConnection;
                this.Hide();
                form.ShowDialog();
            }

            Close();
        }

        private void Librarianbutton_Click(object sender, EventArgs e)
        {
            //this will be the librarian that successfully logged in
            LibrarianAccount librarian = null;

            //create the login form
            using (LibrarianLogin form = new LibrarianLogin())
            {
                //ensure it has a DB connection
                form.DbConnection = DbConnection;
                this.Hide();
                //display the login form as a modal
                var result = form.ShowDialog();
                //if the user login was successful
                if(result == DialogResult.OK)
                {
                    //pull the user object
                    librarian = form.LibrarianAccount;
                    //do something with the data
                    
                }
            }

            if(librarian != null)
            {
                using (LibrarianView form = new LibrarianView())
                {
                    form.DbConnection = DbConnection;
                    form.Account = librarian;

                    form.ShowDialog();
                }
            }

            Close();
        }
    }
}
