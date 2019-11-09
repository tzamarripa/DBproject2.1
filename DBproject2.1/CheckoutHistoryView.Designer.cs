namespace DBproject2._1
{
    partial class CheckoutHistoryView
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
            this.gridCheckouts = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckouts)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCheckouts
            // 
            this.gridCheckouts.AllowUserToAddRows = false;
            this.gridCheckouts.AllowUserToDeleteRows = false;
            this.gridCheckouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCheckouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckouts.Location = new System.Drawing.Point(50, 62);
            this.gridCheckouts.Name = "gridCheckouts";
            this.gridCheckouts.ReadOnly = true;
            this.gridCheckouts.RowHeadersWidth = 51;
            this.gridCheckouts.RowTemplate.Height = 24;
            this.gridCheckouts.Size = new System.Drawing.Size(692, 348);
            this.gridCheckouts.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(227, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(326, 46);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Checkout History";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(298, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(194, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CheckoutHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gridCheckouts);
            this.Name = "CheckoutHistoryView";
            this.Text = "CheckoutHistoryView";
            this.Load += new System.EventHandler(this.CheckoutHistoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCheckouts;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
    }
}