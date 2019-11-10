namespace DBproject2._1
{
    partial class CurrentCheckoutsView
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gridCheckouts = new System.Windows.Forms.DataGridView();
            this.btnRenew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckouts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(121, 354);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(206, 20);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(284, 37);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Current Checkouts";
            // 
            // gridCheckouts
            // 
            this.gridCheckouts.AllowUserToAddRows = false;
            this.gridCheckouts.AllowUserToDeleteRows = false;
            this.gridCheckouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCheckouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckouts.Location = new System.Drawing.Point(11, 67);
            this.gridCheckouts.Margin = new System.Windows.Forms.Padding(2);
            this.gridCheckouts.MultiSelect = false;
            this.gridCheckouts.Name = "gridCheckouts";
            this.gridCheckouts.ReadOnly = true;
            this.gridCheckouts.RowHeadersWidth = 51;
            this.gridCheckouts.RowTemplate.Height = 24;
            this.gridCheckouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCheckouts.Size = new System.Drawing.Size(660, 283);
            this.gridCheckouts.TabIndex = 4;
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(392, 354);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(146, 28);
            this.btnRenew.TabIndex = 7;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // CurrentCheckoutsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 397);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gridCheckouts);
            this.Name = "CurrentCheckoutsView";
            this.Text = "CurrentCheckoutsView";
            this.Load += new System.EventHandler(this.CurrentCheckoutsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView gridCheckouts;
        private System.Windows.Forms.Button btnRenew;
    }
}