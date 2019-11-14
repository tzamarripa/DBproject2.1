namespace DBproject2._1
{
    partial class HistoricalCheckoutsView
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
            this.groupSearchInputs = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.gridSearchResults = new System.Windows.Forms.DataGridView();
            this.errorStart = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEnd = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupSearchInputs.SuspendLayout();
            this.groupSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSearchInputs
            // 
            this.groupSearchInputs.Controls.Add(this.dateEnd);
            this.groupSearchInputs.Controls.Add(this.dateStart);
            this.groupSearchInputs.Controls.Add(this.btnSearch);
            this.groupSearchInputs.Controls.Add(this.lblEnd);
            this.groupSearchInputs.Controls.Add(this.lblStart);
            this.groupSearchInputs.Location = new System.Drawing.Point(285, 25);
            this.groupSearchInputs.Name = "groupSearchInputs";
            this.groupSearchInputs.Size = new System.Drawing.Size(387, 143);
            this.groupSearchInputs.TabIndex = 0;
            this.groupSearchInputs.TabStop = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(16, 79);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(74, 32);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "End:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(7, 30);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(83, 32);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(221, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 71);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.gridSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(3, 203);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Size = new System.Drawing.Size(969, 335);
            this.groupSearchResults.TabIndex = 1;
            this.groupSearchResults.TabStop = false;
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(96, 38);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(110, 22);
            this.dateStart.TabIndex = 3;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(96, 87);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(110, 22);
            this.dateEnd.TabIndex = 4;
            // 
            // gridSearchResults
            // 
            this.gridSearchResults.AllowUserToAddRows = false;
            this.gridSearchResults.AllowUserToDeleteRows = false;
            this.gridSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSearchResults.CausesValidation = false;
            this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResults.Location = new System.Drawing.Point(0, 21);
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RowHeadersWidth = 51;
            this.gridSearchResults.RowTemplate.Height = 24;
            this.gridSearchResults.Size = new System.Drawing.Size(969, 317);
            this.gridSearchResults.TabIndex = 0;
            // 
            // errorStart
            // 
            this.errorStart.ContainerControl = this;
            // 
            // errorEnd
            // 
            this.errorEnd.ContainerControl = this;
            // 
            // HistoricalCheckoutsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 542);
            this.Controls.Add(this.groupSearchResults);
            this.Controls.Add(this.groupSearchInputs);
            this.Name = "HistoricalCheckoutsView";
            this.Text = "Historical Checkouts";
            this.Load += new System.EventHandler(this.HistoricalCheckoutsView_Load);
            this.groupSearchInputs.ResumeLayout(false);
            this.groupSearchInputs.PerformLayout();
            this.groupSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSearchInputs;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.GroupBox groupSearchResults;
        private System.Windows.Forms.DataGridView gridSearchResults;
        private System.Windows.Forms.ErrorProvider errorStart;
        private System.Windows.Forms.ErrorProvider errorEnd;
    }
}