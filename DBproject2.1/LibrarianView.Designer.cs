namespace DBproject2._1
{
    partial class LibrarianView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentCheckoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastDueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalCheckoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPastDue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupSummary = new System.Windows.Forms.GroupBox();
            this.linkLibrarians = new System.Windows.Forms.LinkLabel();
            this.linkMembers = new System.Windows.Forms.LinkLabel();
            this.linkCheckouts = new System.Windows.Forms.LinkLabel();
            this.linkPastDue = new System.Windows.Forms.LinkLabel();
            this.menuStrip.SuspendLayout();
            this.groupSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.returnsToolStripMenuItem,
            this.librariansToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(688, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.fileToolStripMenuItem.Text = "Members";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.testToolStripMenuItem.Text = "Inventory";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeToolStripMenuItem.Text = "Manage";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentCheckoutsToolStripMenuItem,
            this.pastDueToolStripMenuItem,
            this.historicalCheckoutsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // currentCheckoutsToolStripMenuItem
            // 
            this.currentCheckoutsToolStripMenuItem.Name = "currentCheckoutsToolStripMenuItem";
            this.currentCheckoutsToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.currentCheckoutsToolStripMenuItem.Text = "Current Checkouts";
            this.currentCheckoutsToolStripMenuItem.Click += new System.EventHandler(this.currentCheckoutsToolStripMenuItem_Click);
            // 
            // pastDueToolStripMenuItem
            // 
            this.pastDueToolStripMenuItem.Name = "pastDueToolStripMenuItem";
            this.pastDueToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.pastDueToolStripMenuItem.Text = "Past Due";
            this.pastDueToolStripMenuItem.Click += new System.EventHandler(this.pastDueToolStripMenuItem_Click);
            // 
            // historicalCheckoutsToolStripMenuItem
            // 
            this.historicalCheckoutsToolStripMenuItem.Name = "historicalCheckoutsToolStripMenuItem";
            this.historicalCheckoutsToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.historicalCheckoutsToolStripMenuItem.Text = "Historical Checkouts";
            this.historicalCheckoutsToolStripMenuItem.Click += new System.EventHandler(this.historicalCheckoutsToolStripMenuItem_Click);
            // 
            // returnsToolStripMenuItem
            // 
            this.returnsToolStripMenuItem.Name = "returnsToolStripMenuItem";
            this.returnsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.returnsToolStripMenuItem.Text = "Returns";
            this.returnsToolStripMenuItem.Click += new System.EventHandler(this.returnsToolStripMenuItem_Click);
            // 
            // librariansToolStripMenuItem
            // 
            this.librariansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem});
            this.librariansToolStripMenuItem.Name = "librariansToolStripMenuItem";
            this.librariansToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.librariansToolStripMenuItem.Text = "Librarians";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // mangeToolStripMenuItem
            // 
            this.mangeToolStripMenuItem.Name = "mangeToolStripMenuItem";
            this.mangeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mangeToolStripMenuItem.Text = "Manage";
            this.mangeToolStripMenuItem.Click += new System.EventHandler(this.manageLibrariansToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(400, 42);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(246, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Librarian";
            // 
            // lblPastDue
            // 
            this.lblPastDue.AutoSize = true;
            this.lblPastDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastDue.Location = new System.Drawing.Point(31, 87);
            this.lblPastDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPastDue.Name = "lblPastDue";
            this.lblPastDue.Size = new System.Drawing.Size(160, 39);
            this.lblPastDue.TabIndex = 2;
            this.lblPastDue.Text = "Past due:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Checkouts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Members:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Librarians:";
            // 
            // groupSummary
            // 
            this.groupSummary.Controls.Add(this.linkLibrarians);
            this.groupSummary.Controls.Add(this.linkMembers);
            this.groupSummary.Controls.Add(this.linkCheckouts);
            this.groupSummary.Controls.Add(this.linkPastDue);
            this.groupSummary.Controls.Add(this.label4);
            this.groupSummary.Controls.Add(this.lblPastDue);
            this.groupSummary.Controls.Add(this.label3);
            this.groupSummary.Controls.Add(this.label2);
            this.groupSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSummary.Location = new System.Drawing.Point(125, 94);
            this.groupSummary.Margin = new System.Windows.Forms.Padding(4);
            this.groupSummary.Name = "groupSummary";
            this.groupSummary.Padding = new System.Windows.Forms.Padding(4);
            this.groupSummary.Size = new System.Drawing.Size(355, 250);
            this.groupSummary.TabIndex = 6;
            this.groupSummary.TabStop = false;
            this.groupSummary.Text = "Summary";
            // 
            // linkLibrarians
            // 
            this.linkLibrarians.AutoSize = true;
            this.linkLibrarians.Location = new System.Drawing.Point(276, 203);
            this.linkLibrarians.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLibrarians.Name = "linkLibrarians";
            this.linkLibrarians.Size = new System.Drawing.Size(26, 29);
            this.linkLibrarians.TabIndex = 9;
            this.linkLibrarians.TabStop = true;
            this.linkLibrarians.Text = "0";
            this.linkLibrarians.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLibrarians_LinkClicked);
            // 
            // linkMembers
            // 
            this.linkMembers.AutoSize = true;
            this.linkMembers.Location = new System.Drawing.Point(276, 146);
            this.linkMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkMembers.Name = "linkMembers";
            this.linkMembers.Size = new System.Drawing.Size(26, 29);
            this.linkMembers.TabIndex = 8;
            this.linkMembers.TabStop = true;
            this.linkMembers.Text = "0";
            this.linkMembers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMembers_LinkClicked);
            // 
            // linkCheckouts
            // 
            this.linkCheckouts.AutoSize = true;
            this.linkCheckouts.Location = new System.Drawing.Point(276, 41);
            this.linkCheckouts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkCheckouts.Name = "linkCheckouts";
            this.linkCheckouts.Size = new System.Drawing.Size(26, 29);
            this.linkCheckouts.TabIndex = 7;
            this.linkCheckouts.TabStop = true;
            this.linkCheckouts.Text = "0";
            this.linkCheckouts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCheckouts_LinkClicked);
            // 
            // linkPastDue
            // 
            this.linkPastDue.AutoSize = true;
            this.linkPastDue.Location = new System.Drawing.Point(276, 96);
            this.linkPastDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPastDue.Name = "linkPastDue";
            this.linkPastDue.Size = new System.Drawing.Size(26, 29);
            this.linkPastDue.TabIndex = 6;
            this.linkPastDue.TabStop = true;
            this.linkPastDue.Text = "0";
            this.linkPastDue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPastDue_LinkClicked);
            // 
            // LibrarianView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 554);
            this.Controls.Add(this.groupSummary);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibrarianView";
            this.Text = "Librarian View";
            this.Load += new System.EventHandler(this.LibrarianView_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupSummary.ResumeLayout(false);
            this.groupSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentCheckoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastDueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librariansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPastDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupSummary;
        private System.Windows.Forms.LinkLabel linkPastDue;
        private System.Windows.Forms.LinkLabel linkLibrarians;
        private System.Windows.Forms.LinkLabel linkMembers;
        private System.Windows.Forms.LinkLabel linkCheckouts;
        private System.Windows.Forms.ToolStripMenuItem historicalCheckoutsToolStripMenuItem;
    }
}