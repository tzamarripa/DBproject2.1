namespace DBproject2._1
{
    partial class MemberView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupSearchInput = new System.Windows.Forms.GroupBox();
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupSelectionDetails = new System.Windows.Forms.GroupBox();
            this.groupButtonsNoLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupButtonLoggedIn = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCurrentCheckouts = new System.Windows.Forms.Button();
            this.btnCheckoutHistory = new System.Windows.Forms.Button();
            this.lblSearchError = new System.Windows.Forms.Label();
            this.groupMemberInfo = new System.Windows.Forms.GroupBox();
            this.groupSearchInput.SuspendLayout();
            this.groupSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupButtonsNoLogin.SuspendLayout();
            this.groupButtonLoggedIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for books";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(91, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(69, 79);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(186, 42);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(522, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(186, 83);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(522, 22);
            this.txtAuthor.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(716, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 54);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(716, 76);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 61);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupSearchInput
            // 
            this.groupSearchInput.Controls.Add(this.lblSearchError);
            this.groupSearchInput.Controls.Add(this.lblAuthor);
            this.groupSearchInput.Controls.Add(this.label1);
            this.groupSearchInput.Controls.Add(this.btnClear);
            this.groupSearchInput.Controls.Add(this.lblTitle);
            this.groupSearchInput.Controls.Add(this.btnSearch);
            this.groupSearchInput.Controls.Add(this.txtTitle);
            this.groupSearchInput.Controls.Add(this.txtAuthor);
            this.groupSearchInput.Location = new System.Drawing.Point(564, 36);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Size = new System.Drawing.Size(878, 138);
            this.groupSearchInput.TabIndex = 7;
            this.groupSearchInput.TabStop = false;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.dataGridView1);
            this.groupSearchResults.Location = new System.Drawing.Point(564, 180);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Size = new System.Drawing.Size(878, 403);
            this.groupSearchResults.TabIndex = 8;
            this.groupSearchResults.TabStop = false;
            this.groupSearchResults.Text = "Search Results: 0";
            this.groupSearchResults.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(878, 382);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupSelectionDetails
            // 
            this.groupSelectionDetails.Location = new System.Drawing.Point(564, 603);
            this.groupSelectionDetails.Name = "groupSelectionDetails";
            this.groupSelectionDetails.Size = new System.Drawing.Size(878, 169);
            this.groupSelectionDetails.TabIndex = 9;
            this.groupSelectionDetails.TabStop = false;
            this.groupSelectionDetails.Text = "Details";
            this.groupSelectionDetails.Visible = false;
            // 
            // groupButtonsNoLogin
            // 
            this.groupButtonsNoLogin.Controls.Add(this.btnLogin);
            this.groupButtonsNoLogin.Location = new System.Drawing.Point(21, 36);
            this.groupButtonsNoLogin.Name = "groupButtonsNoLogin";
            this.groupButtonsNoLogin.Size = new System.Drawing.Size(224, 64);
            this.groupButtonsNoLogin.TabIndex = 10;
            this.groupButtonsNoLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(0, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(224, 54);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // groupButtonLoggedIn
            // 
            this.groupButtonLoggedIn.Controls.Add(this.btnLogout);
            this.groupButtonLoggedIn.Controls.Add(this.btnCurrentCheckouts);
            this.groupButtonLoggedIn.Controls.Add(this.btnCheckoutHistory);
            this.groupButtonLoggedIn.Location = new System.Drawing.Point(21, 112);
            this.groupButtonLoggedIn.Name = "groupButtonLoggedIn";
            this.groupButtonLoggedIn.Size = new System.Drawing.Size(224, 156);
            this.groupButtonLoggedIn.TabIndex = 11;
            this.groupButtonLoggedIn.TabStop = false;
            this.groupButtonLoggedIn.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 111);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(224, 39);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCurrentCheckouts
            // 
            this.btnCurrentCheckouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentCheckouts.Location = new System.Drawing.Point(0, 53);
            this.btnCurrentCheckouts.Name = "btnCurrentCheckouts";
            this.btnCurrentCheckouts.Size = new System.Drawing.Size(224, 37);
            this.btnCurrentCheckouts.TabIndex = 2;
            this.btnCurrentCheckouts.Text = "Current Checkouts";
            this.btnCurrentCheckouts.UseVisualStyleBackColor = true;
            // 
            // btnCheckoutHistory
            // 
            this.btnCheckoutHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckoutHistory.Location = new System.Drawing.Point(0, 6);
            this.btnCheckoutHistory.Name = "btnCheckoutHistory";
            this.btnCheckoutHistory.Size = new System.Drawing.Size(224, 41);
            this.btnCheckoutHistory.TabIndex = 1;
            this.btnCheckoutHistory.Text = "Checkout History";
            this.btnCheckoutHistory.UseVisualStyleBackColor = true;
            // 
            // lblSearchError
            // 
            this.lblSearchError.AutoSize = true;
            this.lblSearchError.ForeColor = System.Drawing.Color.Red;
            this.lblSearchError.Location = new System.Drawing.Point(186, 113);
            this.lblSearchError.Name = "lblSearchError";
            this.lblSearchError.Size = new System.Drawing.Size(0, 17);
            this.lblSearchError.TabIndex = 7;
            // 
            // groupMemberInfo
            // 
            this.groupMemberInfo.Location = new System.Drawing.Point(1503, 40);
            this.groupMemberInfo.Name = "groupMemberInfo";
            this.groupMemberInfo.Size = new System.Drawing.Size(266, 172);
            this.groupMemberInfo.TabIndex = 12;
            this.groupMemberInfo.TabStop = false;
            this.groupMemberInfo.Text = "Member Info";
            this.groupMemberInfo.Visible = false;
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 769);
            this.Controls.Add(this.groupMemberInfo);
            this.Controls.Add(this.groupButtonLoggedIn);
            this.Controls.Add(this.groupButtonsNoLogin);
            this.Controls.Add(this.groupSelectionDetails);
            this.Controls.Add(this.groupSearchResults);
            this.Controls.Add(this.groupSearchInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberView";
            this.Text = "Member view";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberView_FormClosed);
            this.Load += new System.EventHandler(this.MemberView_Load);
            this.groupSearchInput.ResumeLayout(false);
            this.groupSearchInput.PerformLayout();
            this.groupSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupButtonsNoLogin.ResumeLayout(false);
            this.groupButtonLoggedIn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupSearchInput;
        private System.Windows.Forms.GroupBox groupSearchResults;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupSelectionDetails;
        private System.Windows.Forms.GroupBox groupButtonsNoLogin;
        private System.Windows.Forms.GroupBox groupButtonLoggedIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCurrentCheckouts;
        private System.Windows.Forms.Button btnCheckoutHistory;
        private System.Windows.Forms.Label lblSearchError;
        private System.Windows.Forms.GroupBox groupMemberInfo;
    }
}