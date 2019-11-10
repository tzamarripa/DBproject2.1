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
            this.lblSearchError = new System.Windows.Forms.Label();
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            this.gridSearchResults = new System.Windows.Forms.DataGridView();
            this.groupSelectionDetails = new System.Windows.Forms.GroupBox();
            this.txtDetailsQuantity = new System.Windows.Forms.TextBox();
            this.txtDetailsAvailable = new System.Windows.Forms.TextBox();
            this.txtDetailsPublishDate = new System.Windows.Forms.TextBox();
            this.txtDetailsIsbn = new System.Windows.Forms.TextBox();
            this.txtDetailsAuthor = new System.Windows.Forms.TextBox();
            this.txtDetailsTitle = new System.Windows.Forms.TextBox();
            this.lblDetailsQuantity = new System.Windows.Forms.Label();
            this.lblDetailsAvailable = new System.Windows.Forms.Label();
            this.lblDetailsPublishDate = new System.Windows.Forms.Label();
            this.lblDetailsIsbn = new System.Windows.Forms.Label();
            this.lblDetailsAuthor = new System.Windows.Forms.Label();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.groupButtonsNoLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupButtonLoggedIn = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCurrentCheckouts = new System.Windows.Forms.Button();
            this.btnCheckoutHistory = new System.Windows.Forms.Button();
            this.groupMemberInfo = new System.Windows.Forms.GroupBox();
            this.groupSearchInput.SuspendLayout();
            this.groupSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            this.groupSelectionDetails.SuspendLayout();
            this.groupButtonsNoLogin.SuspendLayout();
            this.groupButtonLoggedIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for books";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(52, 64);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(68, 20);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(140, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(392, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(140, 67);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(392, 20);
            this.txtAuthor.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 44);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(537, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 50);
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
            this.groupSearchInput.Location = new System.Drawing.Point(423, 29);
            this.groupSearchInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSearchInput.Size = new System.Drawing.Size(658, 112);
            this.groupSearchInput.TabIndex = 7;
            this.groupSearchInput.TabStop = false;
            // 
            // lblSearchError
            // 
            this.lblSearchError.AutoSize = true;
            this.lblSearchError.ForeColor = System.Drawing.Color.Red;
            this.lblSearchError.Location = new System.Drawing.Point(140, 92);
            this.lblSearchError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchError.Name = "lblSearchError";
            this.lblSearchError.Size = new System.Drawing.Size(0, 13);
            this.lblSearchError.TabIndex = 7;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.gridSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(423, 146);
            this.groupSearchResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSearchResults.Size = new System.Drawing.Size(658, 327);
            this.groupSearchResults.TabIndex = 8;
            this.groupSearchResults.TabStop = false;
            this.groupSearchResults.Text = "Search Results: 0";
            this.groupSearchResults.Visible = false;
            // 
            // gridSearchResults
            // 
            this.gridSearchResults.AllowUserToAddRows = false;
            this.gridSearchResults.AllowUserToDeleteRows = false;
            this.gridSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSearchResults.CausesValidation = false;
            this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResults.Location = new System.Drawing.Point(0, 17);
            this.gridSearchResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridSearchResults.MultiSelect = false;
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RowHeadersWidth = 51;
            this.gridSearchResults.RowTemplate.Height = 24;
            this.gridSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearchResults.Size = new System.Drawing.Size(658, 310);
            this.gridSearchResults.TabIndex = 1;
            // 
            // groupSelectionDetails
            // 
            this.groupSelectionDetails.Controls.Add(this.txtDetailsQuantity);
            this.groupSelectionDetails.Controls.Add(this.txtDetailsAvailable);
            this.groupSelectionDetails.Controls.Add(this.txtDetailsPublishDate);
            this.groupSelectionDetails.Controls.Add(this.txtDetailsIsbn);
            this.groupSelectionDetails.Controls.Add(this.txtDetailsAuthor);
            this.groupSelectionDetails.Controls.Add(this.txtDetailsTitle);
            this.groupSelectionDetails.Controls.Add(this.lblDetailsQuantity);
            this.groupSelectionDetails.Controls.Add(this.lblDetailsAvailable);
            this.groupSelectionDetails.Controls.Add(this.lblDetailsPublishDate);
            this.groupSelectionDetails.Controls.Add(this.lblDetailsIsbn);
            this.groupSelectionDetails.Controls.Add(this.lblDetailsAuthor);
            this.groupSelectionDetails.Controls.Add(this.lblDetailsTitle);
            this.groupSelectionDetails.Location = new System.Drawing.Point(423, 490);
            this.groupSelectionDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSelectionDetails.Name = "groupSelectionDetails";
            this.groupSelectionDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSelectionDetails.Size = new System.Drawing.Size(658, 137);
            this.groupSelectionDetails.TabIndex = 9;
            this.groupSelectionDetails.TabStop = false;
            this.groupSelectionDetails.Text = "Details";
            this.groupSelectionDetails.Visible = false;
            // 
            // txtDetailsQuantity
            // 
            this.txtDetailsQuantity.Enabled = false;
            this.txtDetailsQuantity.Location = new System.Drawing.Point(565, 93);
            this.txtDetailsQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetailsQuantity.Name = "txtDetailsQuantity";
            this.txtDetailsQuantity.Size = new System.Drawing.Size(80, 20);
            this.txtDetailsQuantity.TabIndex = 11;
            // 
            // txtDetailsAvailable
            // 
            this.txtDetailsAvailable.Enabled = false;
            this.txtDetailsAvailable.Location = new System.Drawing.Point(565, 58);
            this.txtDetailsAvailable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetailsAvailable.Name = "txtDetailsAvailable";
            this.txtDetailsAvailable.Size = new System.Drawing.Size(80, 20);
            this.txtDetailsAvailable.TabIndex = 10;
            // 
            // txtDetailsPublishDate
            // 
            this.txtDetailsPublishDate.Enabled = false;
            this.txtDetailsPublishDate.Location = new System.Drawing.Point(565, 24);
            this.txtDetailsPublishDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetailsPublishDate.Name = "txtDetailsPublishDate";
            this.txtDetailsPublishDate.Size = new System.Drawing.Size(80, 20);
            this.txtDetailsPublishDate.TabIndex = 9;
            // 
            // txtDetailsIsbn
            // 
            this.txtDetailsIsbn.Enabled = false;
            this.txtDetailsIsbn.Location = new System.Drawing.Point(75, 87);
            this.txtDetailsIsbn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetailsIsbn.Name = "txtDetailsIsbn";
            this.txtDetailsIsbn.Size = new System.Drawing.Size(353, 20);
            this.txtDetailsIsbn.TabIndex = 8;
            // 
            // txtDetailsAuthor
            // 
            this.txtDetailsAuthor.Enabled = false;
            this.txtDetailsAuthor.Location = new System.Drawing.Point(75, 58);
            this.txtDetailsAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetailsAuthor.Name = "txtDetailsAuthor";
            this.txtDetailsAuthor.Size = new System.Drawing.Size(353, 20);
            this.txtDetailsAuthor.TabIndex = 7;
            // 
            // txtDetailsTitle
            // 
            this.txtDetailsTitle.Enabled = false;
            this.txtDetailsTitle.Location = new System.Drawing.Point(75, 24);
            this.txtDetailsTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetailsTitle.Name = "txtDetailsTitle";
            this.txtDetailsTitle.Size = new System.Drawing.Size(353, 20);
            this.txtDetailsTitle.TabIndex = 6;
            // 
            // lblDetailsQuantity
            // 
            this.lblDetailsQuantity.AutoSize = true;
            this.lblDetailsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsQuantity.Location = new System.Drawing.Point(481, 87);
            this.lblDetailsQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailsQuantity.Name = "lblDetailsQuantity";
            this.lblDetailsQuantity.Size = new System.Drawing.Size(83, 24);
            this.lblDetailsQuantity.TabIndex = 5;
            this.lblDetailsQuantity.Text = "Quantity:";
            // 
            // lblDetailsAvailable
            // 
            this.lblDetailsAvailable.AutoSize = true;
            this.lblDetailsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsAvailable.Location = new System.Drawing.Point(472, 53);
            this.lblDetailsAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailsAvailable.Name = "lblDetailsAvailable";
            this.lblDetailsAvailable.Size = new System.Drawing.Size(91, 24);
            this.lblDetailsAvailable.TabIndex = 4;
            this.lblDetailsAvailable.Text = "Available:";
            // 
            // lblDetailsPublishDate
            // 
            this.lblDetailsPublishDate.AutoSize = true;
            this.lblDetailsPublishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsPublishDate.Location = new System.Drawing.Point(444, 18);
            this.lblDetailsPublishDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailsPublishDate.Name = "lblDetailsPublishDate";
            this.lblDetailsPublishDate.Size = new System.Drawing.Size(120, 24);
            this.lblDetailsPublishDate.TabIndex = 3;
            this.lblDetailsPublishDate.Text = "Publish Date:";
            // 
            // lblDetailsIsbn
            // 
            this.lblDetailsIsbn.AutoSize = true;
            this.lblDetailsIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsIsbn.Location = new System.Drawing.Point(14, 87);
            this.lblDetailsIsbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailsIsbn.Name = "lblDetailsIsbn";
            this.lblDetailsIsbn.Size = new System.Drawing.Size(57, 24);
            this.lblDetailsIsbn.TabIndex = 2;
            this.lblDetailsIsbn.Text = "ISBN:";
            // 
            // lblDetailsAuthor
            // 
            this.lblDetailsAuthor.AutoSize = true;
            this.lblDetailsAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsAuthor.Location = new System.Drawing.Point(4, 53);
            this.lblDetailsAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailsAuthor.Name = "lblDetailsAuthor";
            this.lblDetailsAuthor.Size = new System.Drawing.Size(71, 24);
            this.lblDetailsAuthor.TabIndex = 1;
            this.lblDetailsAuthor.Text = "Author:";
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTitle.Location = new System.Drawing.Point(20, 18);
            this.lblDetailsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(50, 24);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Title:";
            // 
            // groupButtonsNoLogin
            // 
            this.groupButtonsNoLogin.Controls.Add(this.btnLogin);
            this.groupButtonsNoLogin.Location = new System.Drawing.Point(16, 29);
            this.groupButtonsNoLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupButtonsNoLogin.Name = "groupButtonsNoLogin";
            this.groupButtonsNoLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupButtonsNoLogin.Size = new System.Drawing.Size(168, 52);
            this.groupButtonsNoLogin.TabIndex = 10;
            this.groupButtonsNoLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(0, 3);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 44);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // groupButtonLoggedIn
            // 
            this.groupButtonLoggedIn.Controls.Add(this.btnLogout);
            this.groupButtonLoggedIn.Controls.Add(this.btnCurrentCheckouts);
            this.groupButtonLoggedIn.Controls.Add(this.btnCheckoutHistory);
            this.groupButtonLoggedIn.Location = new System.Drawing.Point(16, 91);
            this.groupButtonLoggedIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupButtonLoggedIn.Name = "groupButtonLoggedIn";
            this.groupButtonLoggedIn.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupButtonLoggedIn.Size = new System.Drawing.Size(168, 127);
            this.groupButtonLoggedIn.TabIndex = 11;
            this.groupButtonLoggedIn.TabStop = false;
            this.groupButtonLoggedIn.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 90);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCurrentCheckouts
            // 
            this.btnCurrentCheckouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentCheckouts.Location = new System.Drawing.Point(0, 43);
            this.btnCurrentCheckouts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurrentCheckouts.Name = "btnCurrentCheckouts";
            this.btnCurrentCheckouts.Size = new System.Drawing.Size(168, 30);
            this.btnCurrentCheckouts.TabIndex = 2;
            this.btnCurrentCheckouts.Text = "Current Checkouts";
            this.btnCurrentCheckouts.UseVisualStyleBackColor = true;
            this.btnCurrentCheckouts.Click += new System.EventHandler(this.btnCurrentCheckouts_Click);
            // 
            // btnCheckoutHistory
            // 
            this.btnCheckoutHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckoutHistory.Location = new System.Drawing.Point(0, 5);
            this.btnCheckoutHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckoutHistory.Name = "btnCheckoutHistory";
            this.btnCheckoutHistory.Size = new System.Drawing.Size(168, 33);
            this.btnCheckoutHistory.TabIndex = 1;
            this.btnCheckoutHistory.Text = "Checkout History";
            this.btnCheckoutHistory.UseVisualStyleBackColor = true;
            this.btnCheckoutHistory.Click += new System.EventHandler(this.btnCheckoutHistory_Click);
            // 
            // groupMemberInfo
            // 
            this.groupMemberInfo.Location = new System.Drawing.Point(1127, 32);
            this.groupMemberInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupMemberInfo.Name = "groupMemberInfo";
            this.groupMemberInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupMemberInfo.Size = new System.Drawing.Size(200, 140);
            this.groupMemberInfo.TabIndex = 12;
            this.groupMemberInfo.TabStop = false;
            this.groupMemberInfo.Text = "Member Info";
            this.groupMemberInfo.Visible = false;
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 625);
            this.Controls.Add(this.groupMemberInfo);
            this.Controls.Add(this.groupButtonLoggedIn);
            this.Controls.Add(this.groupButtonsNoLogin);
            this.Controls.Add(this.groupSelectionDetails);
            this.Controls.Add(this.groupSearchResults);
            this.Controls.Add(this.groupSearchInput);
            this.Name = "MemberView";
            this.Text = "Member view";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberView_FormClosed);
            this.Load += new System.EventHandler(this.MemberView_Load);
            this.groupSearchInput.ResumeLayout(false);
            this.groupSearchInput.PerformLayout();
            this.groupSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            this.groupSelectionDetails.ResumeLayout(false);
            this.groupSelectionDetails.PerformLayout();
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
        private System.Windows.Forms.DataGridView gridSearchResults;
        private System.Windows.Forms.GroupBox groupSelectionDetails;
        private System.Windows.Forms.GroupBox groupButtonsNoLogin;
        private System.Windows.Forms.GroupBox groupButtonLoggedIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCurrentCheckouts;
        private System.Windows.Forms.Button btnCheckoutHistory;
        private System.Windows.Forms.Label lblSearchError;
        private System.Windows.Forms.GroupBox groupMemberInfo;
        private System.Windows.Forms.TextBox txtDetailsQuantity;
        private System.Windows.Forms.TextBox txtDetailsAvailable;
        private System.Windows.Forms.TextBox txtDetailsPublishDate;
        private System.Windows.Forms.TextBox txtDetailsIsbn;
        private System.Windows.Forms.TextBox txtDetailsAuthor;
        private System.Windows.Forms.TextBox txtDetailsTitle;
        private System.Windows.Forms.Label lblDetailsQuantity;
        private System.Windows.Forms.Label lblDetailsAvailable;
        private System.Windows.Forms.Label lblDetailsPublishDate;
        private System.Windows.Forms.Label lblDetailsIsbn;
        private System.Windows.Forms.Label lblDetailsAuthor;
        private System.Windows.Forms.Label lblDetailsTitle;
    }
}