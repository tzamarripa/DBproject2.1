namespace DBproject2._1
{
    partial class CheckoutView
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
            this.checkoutlabel = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.btnMemberLookup = new System.Windows.Forms.Button();
            this.groupMemberLookup = new System.Windows.Forms.GroupBox();
            this.lblMemberIdError = new System.Windows.Forms.Label();
            this.groupChooseBooks = new System.Windows.Forms.GroupBox();
            this.groupReview = new System.Windows.Forms.GroupBox();
            this.gridReview = new System.Windows.Forms.DataGridView();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblCheckoutReview = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnEditSelection = new System.Windows.Forms.Button();
            this.btnCancelCheckout = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.gridSelections = new System.Windows.Forms.DataGridView();
            this.lblBarcodeError = new System.Windows.Forms.Label();
            this.lblMemberHeader = new System.Windows.Forms.Label();
            this.btnCancelSelections = new System.Windows.Forms.Button();
            this.btnContinueSelections = new System.Windows.Forms.Button();
            this.btnAddBarcode = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.groupMemberLookup.SuspendLayout();
            this.groupChooseBooks.SuspendLayout();
            this.groupReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelections)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutlabel
            // 
            this.checkoutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutlabel.Location = new System.Drawing.Point(417, 46);
            this.checkoutlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkoutlabel.Name = "checkoutlabel";
            this.checkoutlabel.Size = new System.Drawing.Size(229, 33);
            this.checkoutlabel.TabIndex = 0;
            this.checkoutlabel.Text = "Library checkout";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(35, 90);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(97, 20);
            this.lblMemberId.TabIndex = 1;
            this.lblMemberId.Text = "Member ID:";
            // 
            // txtMemberId
            // 
            this.txtMemberId.AllowDrop = true;
            this.txtMemberId.Location = new System.Drawing.Point(184, 88);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ShortcutsEnabled = false;
            this.txtMemberId.Size = new System.Drawing.Size(255, 22);
            this.txtMemberId.TabIndex = 2;
            // 
            // btnMemberLookup
            // 
            this.btnMemberLookup.Location = new System.Drawing.Point(151, 185);
            this.btnMemberLookup.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemberLookup.Name = "btnMemberLookup";
            this.btnMemberLookup.Size = new System.Drawing.Size(159, 42);
            this.btnMemberLookup.TabIndex = 3;
            this.btnMemberLookup.Text = "Continue";
            this.btnMemberLookup.UseVisualStyleBackColor = true;
            this.btnMemberLookup.Click += new System.EventHandler(this.btnMemberLookup_Click);
            // 
            // groupMemberLookup
            // 
            this.groupMemberLookup.Controls.Add(this.lblMemberIdError);
            this.groupMemberLookup.Controls.Add(this.txtMemberId);
            this.groupMemberLookup.Controls.Add(this.btnMemberLookup);
            this.groupMemberLookup.Controls.Add(this.lblMemberId);
            this.groupMemberLookup.Location = new System.Drawing.Point(296, 97);
            this.groupMemberLookup.Name = "groupMemberLookup";
            this.groupMemberLookup.Size = new System.Drawing.Size(458, 296);
            this.groupMemberLookup.TabIndex = 4;
            this.groupMemberLookup.TabStop = false;
            // 
            // lblMemberIdError
            // 
            this.lblMemberIdError.AutoSize = true;
            this.lblMemberIdError.ForeColor = System.Drawing.Color.Red;
            this.lblMemberIdError.Location = new System.Drawing.Point(165, 136);
            this.lblMemberIdError.Name = "lblMemberIdError";
            this.lblMemberIdError.Size = new System.Drawing.Size(0, 17);
            this.lblMemberIdError.TabIndex = 4;
            this.lblMemberIdError.Visible = false;
            // 
            // groupChooseBooks
            // 
            this.groupChooseBooks.Controls.Add(this.btnRemoveSelected);
            this.groupChooseBooks.Controls.Add(this.gridSelections);
            this.groupChooseBooks.Controls.Add(this.lblBarcodeError);
            this.groupChooseBooks.Controls.Add(this.lblMemberHeader);
            this.groupChooseBooks.Controls.Add(this.btnCancelSelections);
            this.groupChooseBooks.Controls.Add(this.btnContinueSelections);
            this.groupChooseBooks.Controls.Add(this.btnAddBarcode);
            this.groupChooseBooks.Controls.Add(this.txtBarcode);
            this.groupChooseBooks.Controls.Add(this.lblBarcode);
            this.groupChooseBooks.Location = new System.Drawing.Point(45, 97);
            this.groupChooseBooks.Name = "groupChooseBooks";
            this.groupChooseBooks.Size = new System.Drawing.Size(947, 445);
            this.groupChooseBooks.TabIndex = 5;
            this.groupChooseBooks.TabStop = false;
            this.groupChooseBooks.Visible = false;
            // 
            // groupReview
            // 
            this.groupReview.Controls.Add(this.gridReview);
            this.groupReview.Controls.Add(this.lblDueDate);
            this.groupReview.Controls.Add(this.lblCheckoutReview);
            this.groupReview.Controls.Add(this.btnConfirm);
            this.groupReview.Controls.Add(this.btnEditSelection);
            this.groupReview.Controls.Add(this.btnCancelCheckout);
            this.groupReview.Location = new System.Drawing.Point(51, 91);
            this.groupReview.Name = "groupReview";
            this.groupReview.Size = new System.Drawing.Size(947, 445);
            this.groupReview.TabIndex = 6;
            this.groupReview.TabStop = false;
            this.groupReview.Visible = false;
            // 
            // gridReview
            // 
            this.gridReview.AllowUserToAddRows = false;
            this.gridReview.AllowUserToDeleteRows = false;
            this.gridReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReview.CausesValidation = false;
            this.gridReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReview.Location = new System.Drawing.Point(6, 76);
            this.gridReview.MultiSelect = false;
            this.gridReview.Name = "gridReview";
            this.gridReview.ReadOnly = true;
            this.gridReview.RowHeadersWidth = 51;
            this.gridReview.RowTemplate.Height = 24;
            this.gridReview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReview.ShowCellErrors = false;
            this.gridReview.ShowEditingIcon = false;
            this.gridReview.ShowRowErrors = false;
            this.gridReview.Size = new System.Drawing.Size(941, 316);
            this.gridReview.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(662, 28);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(138, 17);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "To be returned: XXX";
            // 
            // lblCheckoutReview
            // 
            this.lblCheckoutReview.AutoSize = true;
            this.lblCheckoutReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckoutReview.Location = new System.Drawing.Point(360, 18);
            this.lblCheckoutReview.Name = "lblCheckoutReview";
            this.lblCheckoutReview.Size = new System.Drawing.Size(235, 32);
            this.lblCheckoutReview.TabIndex = 3;
            this.lblCheckoutReview.Text = "Checkout Review";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(560, 399);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm Checkout";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnEditSelection
            // 
            this.btnEditSelection.Location = new System.Drawing.Point(430, 398);
            this.btnEditSelection.Name = "btnEditSelection";
            this.btnEditSelection.Size = new System.Drawing.Size(117, 23);
            this.btnEditSelection.TabIndex = 1;
            this.btnEditSelection.Text = "Edit Selection";
            this.btnEditSelection.UseVisualStyleBackColor = true;
            this.btnEditSelection.Click += new System.EventHandler(this.btnEditSelection_Click);
            // 
            // btnCancelCheckout
            // 
            this.btnCancelCheckout.Location = new System.Drawing.Point(281, 398);
            this.btnCancelCheckout.Name = "btnCancelCheckout";
            this.btnCancelCheckout.Size = new System.Drawing.Size(131, 23);
            this.btnCancelCheckout.TabIndex = 0;
            this.btnCancelCheckout.Text = "Cancel Checkout";
            this.btnCancelCheckout.UseVisualStyleBackColor = true;
            this.btnCancelCheckout.Click += new System.EventHandler(this.btnCancelCheckout_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Enabled = false;
            this.btnRemoveSelected.Location = new System.Drawing.Point(415, 405);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(132, 23);
            this.btnRemoveSelected.TabIndex = 8;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // gridSelections
            // 
            this.gridSelections.AllowUserToAddRows = false;
            this.gridSelections.AllowUserToDeleteRows = false;
            this.gridSelections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSelections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSelections.Location = new System.Drawing.Point(6, 117);
            this.gridSelections.MultiSelect = false;
            this.gridSelections.Name = "gridSelections";
            this.gridSelections.ReadOnly = true;
            this.gridSelections.RowHeadersWidth = 51;
            this.gridSelections.RowTemplate.Height = 24;
            this.gridSelections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSelections.Size = new System.Drawing.Size(935, 282);
            this.gridSelections.TabIndex = 7;
            // 
            // lblBarcodeError
            // 
            this.lblBarcodeError.AutoSize = true;
            this.lblBarcodeError.ForeColor = System.Drawing.Color.Red;
            this.lblBarcodeError.Location = new System.Drawing.Point(416, 90);
            this.lblBarcodeError.Name = "lblBarcodeError";
            this.lblBarcodeError.Size = new System.Drawing.Size(0, 17);
            this.lblBarcodeError.TabIndex = 6;
            // 
            // lblMemberHeader
            // 
            this.lblMemberHeader.AutoSize = true;
            this.lblMemberHeader.Location = new System.Drawing.Point(611, 22);
            this.lblMemberHeader.Name = "lblMemberHeader";
            this.lblMemberHeader.Size = new System.Drawing.Size(0, 17);
            this.lblMemberHeader.TabIndex = 5;
            // 
            // btnCancelSelections
            // 
            this.btnCancelSelections.Location = new System.Drawing.Point(259, 405);
            this.btnCancelSelections.Name = "btnCancelSelections";
            this.btnCancelSelections.Size = new System.Drawing.Size(125, 23);
            this.btnCancelSelections.TabIndex = 4;
            this.btnCancelSelections.Text = "Cancel Checkout";
            this.btnCancelSelections.UseVisualStyleBackColor = true;
            this.btnCancelSelections.Click += new System.EventHandler(this.btnCancelSelections_Click);
            // 
            // btnContinueSelections
            // 
            this.btnContinueSelections.Enabled = false;
            this.btnContinueSelections.Location = new System.Drawing.Point(576, 405);
            this.btnContinueSelections.Name = "btnContinueSelections";
            this.btnContinueSelections.Size = new System.Drawing.Size(120, 23);
            this.btnContinueSelections.TabIndex = 3;
            this.btnContinueSelections.Text = "Continue";
            this.btnContinueSelections.UseVisualStyleBackColor = true;
            this.btnContinueSelections.Click += new System.EventHandler(this.btnContinueSelections_Click);
            // 
            // btnAddBarcode
            // 
            this.btnAddBarcode.Location = new System.Drawing.Point(621, 58);
            this.btnAddBarcode.Name = "btnAddBarcode";
            this.btnAddBarcode.Size = new System.Drawing.Size(75, 23);
            this.btnAddBarcode.TabIndex = 2;
            this.btnAddBarcode.Text = "Add";
            this.btnAddBarcode.UseVisualStyleBackColor = true;
            this.btnAddBarcode.Click += new System.EventHandler(this.btnAddBarcode_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(334, 62);
            this.txtBarcode.MaxLength = 10;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(267, 22);
            this.txtBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(256, 64);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(65, 17);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barcode:";
            // 
            // CheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupReview);
            this.Controls.Add(this.groupChooseBooks);
            this.Controls.Add(this.groupMemberLookup);
            this.Controls.Add(this.checkoutlabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckoutView";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.groupMemberLookup.ResumeLayout(false);
            this.groupMemberLookup.PerformLayout();
            this.groupChooseBooks.ResumeLayout(false);
            this.groupChooseBooks.PerformLayout();
            this.groupReview.ResumeLayout(false);
            this.groupReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label checkoutlabel;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Button btnMemberLookup;
        private System.Windows.Forms.GroupBox groupMemberLookup;
        private System.Windows.Forms.Label lblMemberIdError;
        private System.Windows.Forms.GroupBox groupChooseBooks;
        private System.Windows.Forms.Button btnCancelSelections;
        private System.Windows.Forms.Button btnContinueSelections;
        private System.Windows.Forms.Button btnAddBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblMemberHeader;
        private System.Windows.Forms.Label lblBarcodeError;
        private System.Windows.Forms.DataGridView gridSelections;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.GroupBox groupReview;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblCheckoutReview;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnEditSelection;
        private System.Windows.Forms.Button btnCancelCheckout;
        private System.Windows.Forms.DataGridView gridReview;
    }
}