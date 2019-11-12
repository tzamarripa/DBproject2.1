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
    public partial class LibrarianView : Form
    {
        public SqlConnection DbConnection { get; set; }

        public LibrarianAccount Account { get; set; }
        
        public LibrarianView()
        {
            InitializeComponent();
        }

        private void LibrarianView_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = string.Format("Welcome, {0}", Account.Firstname);

            LoadSummaryInfo();
        }

        private void DisplayView(string viewName, bool RequiresAdmin)
        {
            if (RequiresAdmin && !Account.IsAdmin)
            {
                MessageBox.Show("You require admin privileges.", "Cannot continue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string fullViewName = string.Format("{0}.{1}", GetType().Namespace, viewName);
                object[] args = { DbConnection, Account };
                using (Form form = (Form)Activator.CreateInstance(Type.GetType(fullViewName), args))
                {
                    form.ShowDialog();
                }

                //data likely changed, so refresh the summary display
                LoadSummaryInfo();
            }
        }

        private void LoadSummaryInfo()
        {
            //throw new NotImplementedException();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void manageLibrariansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("ManageLibrarianAccountView", true);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("ManageLibrariansView", true);
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayView("AddLibrarianView", false);
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("ReturnsView", false);
        }

        private void pastDueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("PastDueReportView", false);
        }

        private void currentCheckoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("CurrentCheckoutsReportView", false);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("RemoveInventoryView", false);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("AddInventoryView", false);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("ManageMembersView", false);
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayView("RegisterMemberView", false);
        }

        private void linkPastDue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pastDueToolStripMenuItem_Click(sender, e);
        }

        private void linkCheckouts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentCheckoutsToolStripMenuItem_Click(sender, e);        }

        private void linkMembers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            manageToolStripMenuItem_Click(sender, e);
        }

        private void linkLibrarians_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }
    }
}
