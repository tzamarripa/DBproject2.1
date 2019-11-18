namespace DBproject2._1
{
    partial class AddInventoryView
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTitleInput = new System.Windows.Forms.Label();
            this.lblPublishDateInput = new System.Windows.Forms.Label();
            this.lblAuthorFirstname = new System.Windows.Forms.Label();
            this.lblAuthorLastname = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorFirstname = new System.Windows.Forms.TextBox();
            this.txtAuthorLastname = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbnInput = new System.Windows.Forms.Label();
            this.datePublishDate = new System.Windows.Forms.DateTimePicker();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcodeInput = new System.Windows.Forms.Label();
            this.groupAuthors = new System.Windows.Forms.GroupBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.txtAuthorMiddleInitial = new System.Windows.Forms.TextBox();
            this.lblAuthorMiddlename = new System.Windows.Forms.Label();
            this.gridAuthors = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBook = new System.Windows.Forms.GroupBox();
            this.groupInventory = new System.Windows.Forms.GroupBox();
            this.errorTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIsbn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPublishedDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBarcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMiddleInitial = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFirstname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).BeginInit();
            this.groupBook.SuspendLayout();
            this.groupInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublishedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMiddleInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHeader.Location = new System.Drawing.Point(236, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(148, 24);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "Add Inventory";
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
            // lblAuthorFirstname
            // 
            this.lblAuthorFirstname.AutoSize = true;
            this.lblAuthorFirstname.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAuthorFirstname.Location = new System.Drawing.Point(86, 24);
            this.lblAuthorFirstname.Name = "lblAuthorFirstname";
            this.lblAuthorFirstname.Size = new System.Drawing.Size(89, 19);
            this.lblAuthorFirstname.TabIndex = 21;
            this.lblAuthorFirstname.Text = "Firstname";
            // 
            // lblAuthorLastname
            // 
            this.lblAuthorLastname.AutoSize = true;
            this.lblAuthorLastname.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAuthorLastname.Location = new System.Drawing.Point(88, 93);
            this.lblAuthorLastname.Name = "lblAuthorLastname";
            this.lblAuthorLastname.Size = new System.Drawing.Size(87, 19);
            this.lblAuthorLastname.TabIndex = 22;
            this.lblAuthorLastname.Text = "Lastname";
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
            // txtAuthorFirstname
            // 
            this.txtAuthorFirstname.Location = new System.Drawing.Point(209, 23);
            this.txtAuthorFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthorFirstname.MaxLength = 25;
            this.txtAuthorFirstname.Name = "txtAuthorFirstname";
            this.txtAuthorFirstname.Size = new System.Drawing.Size(225, 22);
            this.txtAuthorFirstname.TabIndex = 16;
            // 
            // txtAuthorLastname
            // 
            this.txtAuthorLastname.Location = new System.Drawing.Point(209, 93);
            this.txtAuthorLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthorLastname.MaxLength = 30;
            this.txtAuthorLastname.Name = "txtAuthorLastname";
            this.txtAuthorLastname.Size = new System.Drawing.Size(225, 22);
            this.txtAuthorLastname.TabIndex = 18;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Enabled = false;
            this.btnAddBook.Location = new System.Drawing.Point(360, 633);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(83, 44);
            this.btnAddBook.TabIndex = 20;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(146, 633);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 44);
            this.btnReset.TabIndex = 15;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            // datePublishDate
            // 
            this.datePublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePublishDate.Location = new System.Drawing.Point(209, 108);
            this.datePublishDate.Name = "datePublishDate";
            this.datePublishDate.Size = new System.Drawing.Size(110, 22);
            this.datePublishDate.TabIndex = 3;
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
            // groupAuthors
            // 
            this.groupAuthors.Controls.Add(this.btnAddAuthor);
            this.groupAuthors.Controls.Add(this.txtAuthorMiddleInitial);
            this.groupAuthors.Controls.Add(this.lblAuthorMiddlename);
            this.groupAuthors.Controls.Add(this.gridAuthors);
            this.groupAuthors.Controls.Add(this.txtAuthorLastname);
            this.groupAuthors.Controls.Add(this.lblAuthorFirstname);
            this.groupAuthors.Controls.Add(this.lblAuthorLastname);
            this.groupAuthors.Controls.Add(this.txtAuthorFirstname);
            this.groupAuthors.Location = new System.Drawing.Point(12, 341);
            this.groupAuthors.Name = "groupAuthors";
            this.groupAuthors.Size = new System.Drawing.Size(599, 278);
            this.groupAuthors.TabIndex = 37;
            this.groupAuthors.TabStop = false;
            this.groupAuthors.Text = "Authors";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(467, 23);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(126, 92);
            this.btnAddAuthor.TabIndex = 19;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtAuthorMiddleInitial
            // 
            this.txtAuthorMiddleInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAuthorMiddleInitial.Location = new System.Drawing.Point(209, 58);
            this.txtAuthorMiddleInitial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthorMiddleInitial.MaxLength = 1;
            this.txtAuthorMiddleInitial.Name = "txtAuthorMiddleInitial";
            this.txtAuthorMiddleInitial.Size = new System.Drawing.Size(52, 22);
            this.txtAuthorMiddleInitial.TabIndex = 17;
            // 
            // lblAuthorMiddlename
            // 
            this.lblAuthorMiddlename.AutoSize = true;
            this.lblAuthorMiddlename.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAuthorMiddlename.Location = new System.Drawing.Point(67, 58);
            this.lblAuthorMiddlename.Name = "lblAuthorMiddlename";
            this.lblAuthorMiddlename.Size = new System.Drawing.Size(108, 19);
            this.lblAuthorMiddlename.TabIndex = 27;
            this.lblAuthorMiddlename.Text = "Middle Initial";
            // 
            // gridAuthors
            // 
            this.gridAuthors.AllowUserToAddRows = false;
            this.gridAuthors.AllowUserToDeleteRows = false;
            this.gridAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAuthors.CausesValidation = false;
            this.gridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthors.Location = new System.Drawing.Point(0, 133);
            this.gridAuthors.MultiSelect = false;
            this.gridAuthors.Name = "gridAuthors";
            this.gridAuthors.ReadOnly = true;
            this.gridAuthors.RowHeadersWidth = 51;
            this.gridAuthors.RowTemplate.Height = 24;
            this.gridAuthors.Size = new System.Drawing.Size(599, 139);
            this.gridAuthors.TabIndex = 0;
            this.gridAuthors.TabStop = false;
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
            this.groupBook.Controls.Add(this.lblTitleInput);
            this.groupBook.Controls.Add(this.txtTitle);
            this.groupBook.Controls.Add(this.lblIsbnInput);
            this.groupBook.Controls.Add(this.txtIsbn);
            this.groupBook.Controls.Add(this.lblPublishDateInput);
            this.groupBook.Controls.Add(this.datePublishDate);
            this.groupBook.Location = new System.Drawing.Point(12, 65);
            this.groupBook.Name = "groupBook";
            this.groupBook.Size = new System.Drawing.Size(599, 141);
            this.groupBook.TabIndex = 40;
            this.groupBook.TabStop = false;
            this.groupBook.Text = "Book";
            // 
            // groupInventory
            // 
            this.groupInventory.Controls.Add(this.lblBarcodeInput);
            this.groupInventory.Controls.Add(this.txtBarcode);
            this.groupInventory.Controls.Add(this.txtQuantity);
            this.groupInventory.Controls.Add(this.lblQuantity);
            this.groupInventory.Location = new System.Drawing.Point(12, 223);
            this.groupInventory.Name = "groupInventory";
            this.groupInventory.Size = new System.Drawing.Size(599, 96);
            this.groupInventory.TabIndex = 41;
            this.groupInventory.TabStop = false;
            this.groupInventory.Text = "Inventory";
            // 
            // errorTitle
            // 
            this.errorTitle.ContainerControl = this;
            // 
            // errorIsbn
            // 
            this.errorIsbn.ContainerControl = this;
            // 
            // errorPublishedDate
            // 
            this.errorPublishedDate.ContainerControl = this;
            // 
            // errorBarcode
            // 
            this.errorBarcode.ContainerControl = this;
            // 
            // errorQuantity
            // 
            this.errorQuantity.ContainerControl = this;
            // 
            // errorMiddleInitial
            // 
            this.errorMiddleInitial.ContainerControl = this;
            // 
            // errorFirstname
            // 
            this.errorFirstname.ContainerControl = this;
            // 
            // errorLastname
            // 
            this.errorLastname.ContainerControl = this;
            // 
            // AddInventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 685);
            this.Controls.Add(this.groupInventory);
            this.Controls.Add(this.groupBook);
            this.Controls.Add(this.groupAuthors);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddInventoryView";
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.AddInventoryView_Load);
            this.groupAuthors.ResumeLayout(false);
            this.groupAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).EndInit();
            this.groupBook.ResumeLayout(false);
            this.groupBook.PerformLayout();
            this.groupInventory.ResumeLayout(false);
            this.groupInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublishedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMiddleInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTitleInput;
        private System.Windows.Forms.Label lblPublishDateInput;
        private System.Windows.Forms.Label lblAuthorFirstname;
        private System.Windows.Forms.Label lblAuthorLastname;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorFirstname;
        private System.Windows.Forms.TextBox txtAuthorLastname;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbnInput;
        private System.Windows.Forms.DateTimePicker datePublishDate;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcodeInput;
        private System.Windows.Forms.GroupBox groupAuthors;
        private System.Windows.Forms.TextBox txtAuthorMiddleInitial;
        private System.Windows.Forms.Label lblAuthorMiddlename;
        private System.Windows.Forms.DataGridView gridAuthors;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox groupBook;
        private System.Windows.Forms.GroupBox groupInventory;
        private System.Windows.Forms.ErrorProvider errorTitle;
        private System.Windows.Forms.ErrorProvider errorIsbn;
        private System.Windows.Forms.ErrorProvider errorPublishedDate;
        private System.Windows.Forms.ErrorProvider errorBarcode;
        private System.Windows.Forms.ErrorProvider errorQuantity;
        private System.Windows.Forms.ErrorProvider errorMiddleInitial;
        private System.Windows.Forms.ErrorProvider errorFirstname;
        private System.Windows.Forms.ErrorProvider errorLastname;
    }
}