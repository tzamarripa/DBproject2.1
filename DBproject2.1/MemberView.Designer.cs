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
            this.lblMemberInfoJoinDate = new System.Windows.Forms.Label();
            this.lblMemberInfoName = new System.Windows.Forms.Label();
            this.lblMemberInfoMemberId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupSearchInput.SuspendLayout();
            this.groupSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            this.groupSelectionDetails.SuspendLayout();
            this.groupButtonsNoLogin.SuspendLayout();
            this.groupButtonLoggedIn.SuspendLayout();
            this.groupMemberInfo.SuspendLayout();
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
            this.lblTitle.Location = new System.Drawing.Point(71, 38);
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
            this.lblAuthor.Location = new System.Drawing.Point(49, 79);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(167, 42);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(521, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(167, 82);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(521, 22);
            this.txtAuthor.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(696, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 54);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(696, 76);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 62);
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
            this.groupSearchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchInput.Size = new System.Drawing.Size(877, 138);
            this.groupSearchInput.TabIndex = 7;
            this.groupSearchInput.TabStop = false;
            // 
            // lblSearchError
            // 
            this.lblSearchError.AutoSize = true;
            this.lblSearchError.ForeColor = System.Drawing.Color.Red;
            this.lblSearchError.Location = new System.Drawing.Point(167, 113);
            this.lblSearchError.Name = "lblSearchError";
            this.lblSearchError.Size = new System.Drawing.Size(0, 17);
            this.lblSearchError.TabIndex = 7;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.gridSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(564, 180);
            this.groupSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchResults.Size = new System.Drawing.Size(877, 402);
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
            this.gridSearchResults.Location = new System.Drawing.Point(0, 21);
            this.gridSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSearchResults.MultiSelect = false;
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RowHeadersWidth = 51;
            this.gridSearchResults.RowTemplate.Height = 24;
            this.gridSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearchResults.Size = new System.Drawing.Size(877, 382);
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
            this.groupSelectionDetails.Location = new System.Drawing.Point(564, 603);
            this.groupSelectionDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSelectionDetails.Name = "groupSelectionDetails";
            this.groupSelectionDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSelectionDetails.Size = new System.Drawing.Size(877, 169);
            this.groupSelectionDetails.TabIndex = 9;
            this.groupSelectionDetails.TabStop = false;
            this.groupSelectionDetails.Text = "Details";
            this.groupSelectionDetails.Visible = false;
            // 
            // txtDetailsQuantity
            // 
            this.txtDetailsQuantity.Enabled = false;
            this.txtDetailsQuantity.Location = new System.Drawing.Point(753, 114);
            this.txtDetailsQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailsQuantity.Name = "txtDetailsQuantity";
            this.txtDetailsQuantity.Size = new System.Drawing.Size(105, 22);
            this.txtDetailsQuantity.TabIndex = 11;
            // 
            // txtDetailsAvailable
            // 
            this.txtDetailsAvailable.Enabled = false;
            this.txtDetailsAvailable.Location = new System.Drawing.Point(753, 71);
            this.txtDetailsAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailsAvailable.Name = "txtDetailsAvailable";
            this.txtDetailsAvailable.Size = new System.Drawing.Size(105, 22);
            this.txtDetailsAvailable.TabIndex = 10;
            // 
            // txtDetailsPublishDate
            // 
            this.txtDetailsPublishDate.Enabled = false;
            this.txtDetailsPublishDate.Location = new System.Drawing.Point(753, 30);
            this.txtDetailsPublishDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailsPublishDate.Name = "txtDetailsPublishDate";
            this.txtDetailsPublishDate.Size = new System.Drawing.Size(105, 22);
            this.txtDetailsPublishDate.TabIndex = 9;
            // 
            // txtDetailsIsbn
            // 
            this.txtDetailsIsbn.Enabled = false;
            this.txtDetailsIsbn.Location = new System.Drawing.Point(100, 107);
            this.txtDetailsIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailsIsbn.Name = "txtDetailsIsbn";
            this.txtDetailsIsbn.Size = new System.Drawing.Size(469, 22);
            this.txtDetailsIsbn.TabIndex = 8;
            // 
            // txtDetailsAuthor
            // 
            this.txtDetailsAuthor.Enabled = false;
            this.txtDetailsAuthor.Location = new System.Drawing.Point(100, 71);
            this.txtDetailsAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailsAuthor.Name = "txtDetailsAuthor";
            this.txtDetailsAuthor.Size = new System.Drawing.Size(469, 22);
            this.txtDetailsAuthor.TabIndex = 7;
            // 
            // txtDetailsTitle
            // 
            this.txtDetailsTitle.Enabled = false;
            this.txtDetailsTitle.Location = new System.Drawing.Point(100, 30);
            this.txtDetailsTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailsTitle.Name = "txtDetailsTitle";
            this.txtDetailsTitle.Size = new System.Drawing.Size(469, 22);
            this.txtDetailsTitle.TabIndex = 6;
            // 
            // lblDetailsQuantity
            // 
            this.lblDetailsQuantity.AutoSize = true;
            this.lblDetailsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsQuantity.Location = new System.Drawing.Point(641, 107);
            this.lblDetailsQuantity.Name = "lblDetailsQuantity";
            this.lblDetailsQuantity.Size = new System.Drawing.Size(106, 29);
            this.lblDetailsQuantity.TabIndex = 5;
            this.lblDetailsQuantity.Text = "Quantity:";
            // 
            // lblDetailsAvailable
            // 
            this.lblDetailsAvailable.AutoSize = true;
            this.lblDetailsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsAvailable.Location = new System.Drawing.Point(629, 65);
            this.lblDetailsAvailable.Name = "lblDetailsAvailable";
            this.lblDetailsAvailable.Size = new System.Drawing.Size(117, 29);
            this.lblDetailsAvailable.TabIndex = 4;
            this.lblDetailsAvailable.Text = "Available:";
            // 
            // lblDetailsPublishDate
            // 
            this.lblDetailsPublishDate.AutoSize = true;
            this.lblDetailsPublishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsPublishDate.Location = new System.Drawing.Point(592, 22);
            this.lblDetailsPublishDate.Name = "lblDetailsPublishDate";
            this.lblDetailsPublishDate.Size = new System.Drawing.Size(155, 29);
            this.lblDetailsPublishDate.TabIndex = 3;
            this.lblDetailsPublishDate.Text = "Publish Date:";
            // 
            // lblDetailsIsbn
            // 
            this.lblDetailsIsbn.AutoSize = true;
            this.lblDetailsIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsIsbn.Location = new System.Drawing.Point(19, 107);
            this.lblDetailsIsbn.Name = "lblDetailsIsbn";
            this.lblDetailsIsbn.Size = new System.Drawing.Size(75, 29);
            this.lblDetailsIsbn.TabIndex = 2;
            this.lblDetailsIsbn.Text = "ISBN:";
            // 
            // lblDetailsAuthor
            // 
            this.lblDetailsAuthor.AutoSize = true;
            this.lblDetailsAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsAuthor.Location = new System.Drawing.Point(5, 65);
            this.lblDetailsAuthor.Name = "lblDetailsAuthor";
            this.lblDetailsAuthor.Size = new System.Drawing.Size(88, 29);
            this.lblDetailsAuthor.TabIndex = 1;
            this.lblDetailsAuthor.Text = "Author:";
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTitle.Location = new System.Drawing.Point(27, 22);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(67, 29);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Title:";
            // 
            // groupButtonsNoLogin
            // 
            this.groupButtonsNoLogin.Controls.Add(this.btnLogin);
            this.groupButtonsNoLogin.Location = new System.Drawing.Point(21, 36);
            this.groupButtonsNoLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupButtonsNoLogin.Name = "groupButtonsNoLogin";
            this.groupButtonsNoLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupButtonsNoLogin.Size = new System.Drawing.Size(224, 64);
            this.groupButtonsNoLogin.TabIndex = 10;
            this.groupButtonsNoLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(0, 4);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(224, 54);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupButtonLoggedIn
            // 
            this.groupButtonLoggedIn.Controls.Add(this.btnLogout);
            this.groupButtonLoggedIn.Controls.Add(this.btnCurrentCheckouts);
            this.groupButtonLoggedIn.Controls.Add(this.btnCheckoutHistory);
            this.groupButtonLoggedIn.Location = new System.Drawing.Point(21, 112);
            this.groupButtonLoggedIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupButtonLoggedIn.Name = "groupButtonLoggedIn";
            this.groupButtonLoggedIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupButtonLoggedIn.Size = new System.Drawing.Size(224, 156);
            this.groupButtonLoggedIn.TabIndex = 11;
            this.groupButtonLoggedIn.TabStop = false;
            this.groupButtonLoggedIn.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 111);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnCurrentCheckouts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrentCheckouts.Name = "btnCurrentCheckouts";
            this.btnCurrentCheckouts.Size = new System.Drawing.Size(224, 37);
            this.btnCurrentCheckouts.TabIndex = 2;
            this.btnCurrentCheckouts.Text = "Current Checkouts";
            this.btnCurrentCheckouts.UseVisualStyleBackColor = true;
            this.btnCurrentCheckouts.Click += new System.EventHandler(this.btnCurrentCheckouts_Click);
            // 
            // btnCheckoutHistory
            // 
            this.btnCheckoutHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckoutHistory.Location = new System.Drawing.Point(0, 6);
            this.btnCheckoutHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckoutHistory.Name = "btnCheckoutHistory";
            this.btnCheckoutHistory.Size = new System.Drawing.Size(224, 41);
            this.btnCheckoutHistory.TabIndex = 1;
            this.btnCheckoutHistory.Text = "Checkout History";
            this.btnCheckoutHistory.UseVisualStyleBackColor = true;
            this.btnCheckoutHistory.Click += new System.EventHandler(this.btnCheckoutHistory_Click);
            // 
            // groupMemberInfo
            // 
            this.groupMemberInfo.Controls.Add(this.lblMemberInfoJoinDate);
            this.groupMemberInfo.Controls.Add(this.lblMemberInfoName);
            this.groupMemberInfo.Controls.Add(this.lblMemberInfoMemberId);
            this.groupMemberInfo.Controls.Add(this.label4);
            this.groupMemberInfo.Controls.Add(this.label3);
            this.groupMemberInfo.Controls.Add(this.label2);
            this.groupMemberInfo.Location = new System.Drawing.Point(1503, 39);
            this.groupMemberInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupMemberInfo.Name = "groupMemberInfo";
            this.groupMemberInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupMemberInfo.Size = new System.Drawing.Size(267, 172);
            this.groupMemberInfo.TabIndex = 12;
            this.groupMemberInfo.TabStop = false;
            this.groupMemberInfo.Text = "Member Info";
            this.groupMemberInfo.Visible = false;
            // 
            // lblMemberInfoJoinDate
            // 
            this.lblMemberInfoJoinDate.AutoSize = true;
            this.lblMemberInfoJoinDate.Location = new System.Drawing.Point(117, 87);
            this.lblMemberInfoJoinDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberInfoJoinDate.Name = "lblMemberInfoJoinDate";
            this.lblMemberInfoJoinDate.Size = new System.Drawing.Size(35, 17);
            this.lblMemberInfoJoinDate.TabIndex = 5;
            this.lblMemberInfoJoinDate.Text = "XXX";
            // 
            // lblMemberInfoName
            // 
            this.lblMemberInfoName.AutoSize = true;
            this.lblMemberInfoName.Location = new System.Drawing.Point(117, 57);
            this.lblMemberInfoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberInfoName.Name = "lblMemberInfoName";
            this.lblMemberInfoName.Size = new System.Drawing.Size(35, 17);
            this.lblMemberInfoName.TabIndex = 4;
            this.lblMemberInfoName.Text = "XXX";
            // 
            // lblMemberInfoMemberId
            // 
            this.lblMemberInfoMemberId.AutoSize = true;
            this.lblMemberInfoMemberId.Location = new System.Drawing.Point(117, 30);
            this.lblMemberInfoMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberInfoMemberId.Name = "lblMemberInfoMemberId";
            this.lblMemberInfoMemberId.Size = new System.Drawing.Size(35, 17);
            this.lblMemberInfoMemberId.TabIndex = 3;
            this.lblMemberInfoMemberId.Text = "XXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Member since:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID:";
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupMemberInfo.ResumeLayout(false);
            this.groupMemberInfo.PerformLayout();
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
        private System.Windows.Forms.Label lblMemberInfoJoinDate;
        private System.Windows.Forms.Label lblMemberInfoName;
        private System.Windows.Forms.Label lblMemberInfoMemberId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}