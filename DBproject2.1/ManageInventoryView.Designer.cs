namespace DBproject2._1
{
    partial class ManageInventoryView
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
            this.components = new System.ComponentModel.Container();
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            this.gridSearchResults = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.groupSearchInput = new System.Windows.Forms.GroupBox();
            this.errorTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            this.groupSearchInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.gridSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(95, 209);
            this.groupSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchResults.Size = new System.Drawing.Size(877, 402);
            this.groupSearchResults.TabIndex = 10;
            this.groupSearchResults.TabStop = false;
            this.groupSearchResults.Text = "Search Results: 0";
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHeader.Location = new System.Drawing.Point(439, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(184, 24);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Manage Inventory";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(143, 82);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(521, 22);
            this.txtAuthor.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(143, 42);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(521, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(696, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 54);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(47, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(696, 76);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 62);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(25, 79);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // groupSearchInput
            // 
            this.groupSearchInput.Controls.Add(this.lblAuthor);
            this.groupSearchInput.Controls.Add(this.btnClear);
            this.groupSearchInput.Controls.Add(this.lblTitle);
            this.groupSearchInput.Controls.Add(this.btnSearch);
            this.groupSearchInput.Controls.Add(this.txtTitle);
            this.groupSearchInput.Controls.Add(this.txtAuthor);
            this.groupSearchInput.Location = new System.Drawing.Point(95, 65);
            this.groupSearchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupSearchInput.Size = new System.Drawing.Size(877, 138);
            this.groupSearchInput.TabIndex = 9;
            this.groupSearchInput.TabStop = false;
            // 
            // errorTitle
            // 
            this.errorTitle.ContainerControl = this;
            // 
            // errorAuthor
            // 
            this.errorAuthor.ContainerControl = this;
            // 
            // ManageInventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 627);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.groupSearchResults);
            this.Controls.Add(this.groupSearchInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageInventoryView";
            this.Text = "Manage Inventory";
            this.Load += new System.EventHandler(this.ManageInventoryView_Load);
            this.groupSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            this.groupSearchInput.ResumeLayout(false);
            this.groupSearchInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSearchResults;
        private System.Windows.Forms.DataGridView gridSearchResults;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.GroupBox groupSearchInput;
        private System.Windows.Forms.ErrorProvider errorTitle;
        private System.Windows.Forms.ErrorProvider errorAuthor;
    }
}