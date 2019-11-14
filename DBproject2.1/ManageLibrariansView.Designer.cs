namespace DBproject2._1
{
    partial class ManageLibrariansView
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
            this.gridSearchResults = new System.Windows.Forms.DataGridView();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFirstname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupIdSearch = new System.Windows.Forms.GroupBox();
            this.groupNameSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).BeginInit();
            this.groupSearchResults.SuspendLayout();
            this.groupIdSearch.SuspendLayout();
            this.groupNameSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSearchResults
            // 
            this.gridSearchResults.AllowUserToAddRows = false;
            this.gridSearchResults.AllowUserToDeleteRows = false;
            this.gridSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSearchResults.CausesValidation = false;
            this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResults.Location = new System.Drawing.Point(0, 20);
            this.gridSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSearchResults.MultiSelect = false;
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RowHeadersWidth = 62;
            this.gridSearchResults.RowTemplate.Height = 27;
            this.gridSearchResults.Size = new System.Drawing.Size(1043, 218);
            this.gridSearchResults.TabIndex = 33;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchByName.Location = new System.Drawing.Point(306, 20);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(168, 63);
            this.btnSearchByName.TabIndex = 32;
            this.btnSearchByName.Text = "Search by name";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(355, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "- OR -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Lastname";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(116, 58);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(149, 22);
            this.txtLastname.TabIndex = 29;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(116, 20);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(149, 22);
            this.txtFirstname.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Firstname";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 40);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(149, 22);
            this.txtId.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblID.Location = new System.Drawing.Point(55, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 19);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID";
            // 
            // btnSearchById
            // 
            this.btnSearchById.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchById.Location = new System.Drawing.Point(306, 20);
            this.btnSearchById.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(168, 63);
            this.btnSearchById.TabIndex = 24;
            this.btnSearchById.Text = "Search by ID";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // errorFirstname
            // 
            this.errorFirstname.ContainerControl = this;
            // 
            // errorLastname
            // 
            this.errorLastname.ContainerControl = this;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.gridSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(12, 275);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Size = new System.Drawing.Size(1043, 277);
            this.groupSearchResults.TabIndex = 36;
            this.groupSearchResults.TabStop = false;
            // 
            // groupIdSearch
            // 
            this.groupIdSearch.Controls.Add(this.txtId);
            this.groupIdSearch.Controls.Add(this.lblID);
            this.groupIdSearch.Controls.Add(this.btnSearchById);
            this.groupIdSearch.Location = new System.Drawing.Point(285, 12);
            this.groupIdSearch.Name = "groupIdSearch";
            this.groupIdSearch.Size = new System.Drawing.Size(480, 92);
            this.groupIdSearch.TabIndex = 37;
            this.groupIdSearch.TabStop = false;
            // 
            // groupNameSearch
            // 
            this.groupNameSearch.Controls.Add(this.label1);
            this.groupNameSearch.Controls.Add(this.txtFirstname);
            this.groupNameSearch.Controls.Add(this.txtLastname);
            this.groupNameSearch.Controls.Add(this.btnSearchByName);
            this.groupNameSearch.Controls.Add(this.label2);
            this.groupNameSearch.Location = new System.Drawing.Point(285, 149);
            this.groupNameSearch.Name = "groupNameSearch";
            this.groupNameSearch.Size = new System.Drawing.Size(480, 100);
            this.groupNameSearch.TabIndex = 38;
            this.groupNameSearch.TabStop = false;
            // 
            // ManageLibrariansView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupNameSearch);
            this.Controls.Add(this.groupIdSearch);
            this.Controls.Add(this.groupSearchResults);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageLibrariansView";
            this.Text = "Manage Librarians";
            this.Load += new System.EventHandler(this.ManageLibrariansView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).EndInit();
            this.groupSearchResults.ResumeLayout(false);
            this.groupIdSearch.ResumeLayout(false);
            this.groupIdSearch.PerformLayout();
            this.groupNameSearch.ResumeLayout(false);
            this.groupNameSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridSearchResults;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.ErrorProvider errorId;
        private System.Windows.Forms.ErrorProvider errorFirstname;
        private System.Windows.Forms.ErrorProvider errorLastname;
        private System.Windows.Forms.GroupBox groupSearchResults;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupNameSearch;
        private System.Windows.Forms.GroupBox groupIdSearch;
    }
}