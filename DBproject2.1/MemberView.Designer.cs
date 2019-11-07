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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupSearchInput = new System.Windows.Forms.GroupBox();
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupSelectionDetails = new System.Windows.Forms.GroupBox();
            this.groupButtonsNoLogin = new System.Windows.Forms.GroupBox();
            this.groupButtonLoggedIn = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCheckoutHistory = new System.Windows.Forms.Button();
            this.btnCurrentCheckouts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for books";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 81);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupSearchInput
            // 
            this.groupSearchInput.Controls.Add(this.label3);
            this.groupSearchInput.Controls.Add(this.label1);
            this.groupSearchInput.Controls.Add(this.button2);
            this.groupSearchInput.Controls.Add(this.label2);
            this.groupSearchInput.Controls.Add(this.button1);
            this.groupSearchInput.Controls.Add(this.textBox1);
            this.groupSearchInput.Controls.Add(this.textBox2);
            this.groupSearchInput.Location = new System.Drawing.Point(231, 35);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Size = new System.Drawing.Size(511, 125);
            this.groupSearchInput.TabIndex = 7;
            this.groupSearchInput.TabStop = false;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.dataGridView1);
            this.groupSearchResults.Location = new System.Drawing.Point(231, 166);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Size = new System.Drawing.Size(511, 255);
            this.groupSearchResults.TabIndex = 8;
            this.groupSearchResults.TabStop = false;
            this.groupSearchResults.Text = "Search Results: 0";
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
            this.dataGridView1.Size = new System.Drawing.Size(511, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupSelectionDetails
            // 
            this.groupSelectionDetails.Location = new System.Drawing.Point(231, 438);
            this.groupSelectionDetails.Name = "groupSelectionDetails";
            this.groupSelectionDetails.Size = new System.Drawing.Size(511, 104);
            this.groupSelectionDetails.TabIndex = 9;
            this.groupSelectionDetails.TabStop = false;
            this.groupSelectionDetails.Text = "Details";
            // 
            // groupButtonsNoLogin
            // 
            this.groupButtonsNoLogin.Controls.Add(this.btnLogin);
            this.groupButtonsNoLogin.Location = new System.Drawing.Point(12, 35);
            this.groupButtonsNoLogin.Name = "groupButtonsNoLogin";
            this.groupButtonsNoLogin.Size = new System.Drawing.Size(136, 34);
            this.groupButtonsNoLogin.TabIndex = 10;
            this.groupButtonsNoLogin.TabStop = false;
            // 
            // groupButtonLoggedIn
            // 
            this.groupButtonLoggedIn.Controls.Add(this.btnLogout);
            this.groupButtonLoggedIn.Controls.Add(this.btnCurrentCheckouts);
            this.groupButtonLoggedIn.Controls.Add(this.btnCheckoutHistory);
            this.groupButtonLoggedIn.Location = new System.Drawing.Point(12, 67);
            this.groupButtonLoggedIn.Name = "groupButtonLoggedIn";
            this.groupButtonLoggedIn.Size = new System.Drawing.Size(136, 107);
            this.groupButtonLoggedIn.TabIndex = 11;
            this.groupButtonLoggedIn.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(0, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCheckoutHistory
            // 
            this.btnCheckoutHistory.Location = new System.Drawing.Point(0, 6);
            this.btnCheckoutHistory.Name = "btnCheckoutHistory";
            this.btnCheckoutHistory.Size = new System.Drawing.Size(136, 23);
            this.btnCheckoutHistory.TabIndex = 1;
            this.btnCheckoutHistory.Text = "Checkout History";
            this.btnCheckoutHistory.UseVisualStyleBackColor = true;
            // 
            // btnCurrentCheckouts
            // 
            this.btnCurrentCheckouts.Location = new System.Drawing.Point(0, 31);
            this.btnCurrentCheckouts.Name = "btnCurrentCheckouts";
            this.btnCurrentCheckouts.Size = new System.Drawing.Size(136, 23);
            this.btnCurrentCheckouts.TabIndex = 2;
            this.btnCurrentCheckouts.Text = "Current Checkouts";
            this.btnCurrentCheckouts.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 76);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupButtonLoggedIn);
            this.Controls.Add(this.groupButtonsNoLogin);
            this.Controls.Add(this.groupSelectionDetails);
            this.Controls.Add(this.groupSearchResults);
            this.Controls.Add(this.groupSearchInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberView";
            this.Text = "Member view";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_FormClosed);
            this.Load += new System.EventHandler(this.Customer_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
    }
}