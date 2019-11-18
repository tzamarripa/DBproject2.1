namespace DBproject2._1
{
    partial class EditInventoryView
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
            this.errorQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBarcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPublishedDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIsbn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupInventory = new System.Windows.Forms.GroupBox();
            this.lblBarcodeInput = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBook = new System.Windows.Forms.GroupBox();
            this.lblTitleInput = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblIsbnInput = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblPublishDateInput = new System.Windows.Forms.Label();
            this.datePublishDate = new System.Windows.Forms.DateTimePicker();
            this.gridAuthors = new System.Windows.Forms.DataGridView();
            this.groupAuthors = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblEnteredBy = new System.Windows.Forms.Label();
            this.txtLibrarian = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublishedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).BeginInit();
            this.groupInventory.SuspendLayout();
            this.groupBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).BeginInit();
            this.groupAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorQuantity
            // 
            this.errorQuantity.ContainerControl = this;
            // 
            // errorBarcode
            // 
            this.errorBarcode.ContainerControl = this;
            // 
            // errorPublishedDate
            // 
            this.errorPublishedDate.ContainerControl = this;
            // 
            // errorIsbn
            // 
            this.errorIsbn.ContainerControl = this;
            // 
            // errorTitle
            // 
            this.errorTitle.ContainerControl = this;
            // 
            // groupInventory
            // 
            this.groupInventory.Controls.Add(this.lblBarcodeInput);
            this.groupInventory.Controls.Add(this.txtBarcode);
            this.groupInventory.Controls.Add(this.txtQuantity);
            this.groupInventory.Controls.Add(this.lblQuantity);
            this.groupInventory.Location = new System.Drawing.Point(34, 256);
            this.groupInventory.Name = "groupInventory";
            this.groupInventory.Size = new System.Drawing.Size(599, 96);
            this.groupInventory.TabIndex = 47;
            this.groupInventory.TabStop = false;
            this.groupInventory.Text = "Inventory";
            // 
            // lblBarcodeInput
            // 
            this.lblBarcodeInput.AutoSize = true;
            this.lblBarcodeInput.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBarcodeInput.Location = new System.Drawing.Point(99, 29);
            this.lblBarcodeInput.Name = "lblBarcodeInput";
            this.lblBarcodeInput.Size = new System.Drawing.Size(76, 19);
            this.lblBarcodeInput.TabIndex = 35;
            this.lblBarcodeInput.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBarcode.Location = new System.Drawing.Point(209, 26);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarcode.MaxLength = 10;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(225, 22);
            this.txtBarcode.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(209, 62);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(52, 22);
            this.txtQuantity.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuantity.Location = new System.Drawing.Point(97, 65);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 19);
            this.lblQuantity.TabIndex = 38;
            this.lblQuantity.Text = "Quantity";
            // 
            // groupBook
            // 
            this.groupBook.Controls.Add(this.lblEnteredBy);
            this.groupBook.Controls.Add(this.txtLibrarian);
            this.groupBook.Controls.Add(this.lblTitleInput);
            this.groupBook.Controls.Add(this.txtTitle);
            this.groupBook.Controls.Add(this.lblIsbnInput);
            this.groupBook.Controls.Add(this.txtIsbn);
            this.groupBook.Controls.Add(this.lblPublishDateInput);
            this.groupBook.Controls.Add(this.datePublishDate);
            this.groupBook.Location = new System.Drawing.Point(34, 51);
            this.groupBook.Name = "groupBook";
            this.groupBook.Size = new System.Drawing.Size(599, 185);
            this.groupBook.TabIndex = 46;
            this.groupBook.TabStop = false;
            this.groupBook.Text = "Book";
            // 
            // lblTitleInput
            // 
            this.lblTitleInput.AutoSize = true;
            this.lblTitleInput.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitleInput.Location = new System.Drawing.Point(130, 31);
            this.lblTitleInput.Name = "lblTitleInput";
            this.lblTitleInput.Size = new System.Drawing.Size(45, 19);
            this.lblTitleInput.TabIndex = 19;
            this.lblTitleInput.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(209, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(225, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblIsbnInput
            // 
            this.lblIsbnInput.AutoSize = true;
            this.lblIsbnInput.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIsbnInput.Location = new System.Drawing.Point(126, 73);
            this.lblIsbnInput.Name = "lblIsbnInput";
            this.lblIsbnInput.Size = new System.Drawing.Size(49, 19);
            this.lblIsbnInput.TabIndex = 32;
            this.lblIsbnInput.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIsbn.Location = new System.Drawing.Point(209, 70);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsbn.MaxLength = 10;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(225, 22);
            this.txtIsbn.TabIndex = 2;
            // 
            // lblPublishDateInput
            // 
            this.lblPublishDateInput.AutoSize = true;
            this.lblPublishDateInput.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPublishDateInput.Location = new System.Drawing.Point(64, 108);
            this.lblPublishDateInput.Name = "lblPublishDateInput";
            this.lblPublishDateInput.Size = new System.Drawing.Size(111, 19);
            this.lblPublishDateInput.TabIndex = 20;
            this.lblPublishDateInput.Text = "Publish Date";
            // 
            // datePublishDate
            // 
            this.datePublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePublishDate.Location = new System.Drawing.Point(209, 108);
            this.datePublishDate.Name = "datePublishDate";
            this.datePublishDate.Size = new System.Drawing.Size(110, 22);
            this.datePublishDate.TabIndex = 3;
            // 
            // gridAuthors
            // 
            this.gridAuthors.AllowUserToAddRows = false;
            this.gridAuthors.AllowUserToDeleteRows = false;
            this.gridAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAuthors.CausesValidation = false;
            this.gridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthors.Location = new System.Drawing.Point(0, 21);
            this.gridAuthors.MultiSelect = false;
            this.gridAuthors.Name = "gridAuthors";
            this.gridAuthors.ReadOnly = true;
            this.gridAuthors.RowHeadersWidth = 51;
            this.gridAuthors.RowTemplate.Height = 24;
            this.gridAuthors.Size = new System.Drawing.Size(599, 139);
            this.gridAuthors.TabIndex = 0;
            this.gridAuthors.TabStop = false;
            // 
            // groupAuthors
            // 
            this.groupAuthors.Controls.Add(this.gridAuthors);
            this.groupAuthors.Location = new System.Drawing.Point(34, 374);
            this.groupAuthors.Name = "groupAuthors";
            this.groupAuthors.Size = new System.Drawing.Size(599, 164);
            this.groupAuthors.TabIndex = 45;
            this.groupAuthors.TabStop = false;
            this.groupAuthors.Text = "Authors";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(168, 551);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 44);
            this.btnReset.TabIndex = 42;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(382, 551);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 44);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHeader.Location = new System.Drawing.Point(258, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(148, 24);
            this.lblHeader.TabIndex = 43;
            this.lblHeader.Text = "Edit Inventory";
            // 
            // lblEnteredBy
            // 
            this.lblEnteredBy.AutoSize = true;
            this.lblEnteredBy.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEnteredBy.Location = new System.Drawing.Point(75, 151);
            this.lblEnteredBy.Name = "lblEnteredBy";
            this.lblEnteredBy.Size = new System.Drawing.Size(100, 19);
            this.lblEnteredBy.TabIndex = 34;
            this.lblEnteredBy.Text = "Entered By";
            // 
            // txtLibrarian
            // 
            this.txtLibrarian.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLibrarian.Enabled = false;
            this.txtLibrarian.Location = new System.Drawing.Point(209, 148);
            this.txtLibrarian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibrarian.MaxLength = 10;
            this.txtLibrarian.Name = "txtLibrarian";
            this.txtLibrarian.Size = new System.Drawing.Size(225, 22);
            this.txtLibrarian.TabIndex = 33;
            // 
            // EditInventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 614);
            this.Controls.Add(this.groupInventory);
            this.Controls.Add(this.groupBook);
            this.Controls.Add(this.groupAuthors);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblHeader);
            this.Name = "EditInventoryView";
            this.Text = "Edit Inventory";
            this.Load += new System.EventHandler(this.EditInventoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublishedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).EndInit();
            this.groupInventory.ResumeLayout(false);
            this.groupInventory.PerformLayout();
            this.groupBook.ResumeLayout(false);
            this.groupBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).EndInit();
            this.groupAuthors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupInventory;
        private System.Windows.Forms.Label lblBarcodeInput;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox groupBook;
        private System.Windows.Forms.Label lblTitleInput;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblIsbnInput;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblPublishDateInput;
        private System.Windows.Forms.DateTimePicker datePublishDate;
        private System.Windows.Forms.GroupBox groupAuthors;
        private System.Windows.Forms.DataGridView gridAuthors;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ErrorProvider errorQuantity;
        private System.Windows.Forms.ErrorProvider errorBarcode;
        private System.Windows.Forms.ErrorProvider errorPublishedDate;
        private System.Windows.Forms.ErrorProvider errorIsbn;
        private System.Windows.Forms.ErrorProvider errorTitle;
        private System.Windows.Forms.Label lblEnteredBy;
        private System.Windows.Forms.TextBox txtLibrarian;
    }
}