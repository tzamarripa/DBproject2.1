namespace DBproject2._1
{
    partial class ManageMembersView
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
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.MemberID = new System.Windows.Forms.Label();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.errorMemberId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFirstname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupId = new System.Windows.Forms.GroupBox();
            this.groupName = new System.Windows.Forms.GroupBox();
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).BeginInit();
            this.groupId.SuspendLayout();
            this.groupName.SuspendLayout();
            this.groupSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSearchResults
            // 
            this.gridSearchResults.AllowUserToAddRows = false;
            this.gridSearchResults.AllowUserToDeleteRows = false;
            this.gridSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSearchResults.CausesValidation = false;
            this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResults.Location = new System.Drawing.Point(6, 32);
            this.gridSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSearchResults.MultiSelect = false;
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RowHeadersWidth = 62;
            this.gridSearchResults.RowTemplate.Height = 27;
            this.gridSearchResults.Size = new System.Drawing.Size(782, 177);
            this.gridSearchResults.TabIndex = 21;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchByName.Location = new System.Drawing.Point(371, 35);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(168, 63);
            this.btnSearchByName.TabIndex = 20;
            this.btnSearchByName.Text = "Search by name";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(352, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "- OR -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lastname";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(162, 79);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(128, 22);
            this.txtLastname.TabIndex = 17;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(162, 26);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(128, 22);
            this.txtFirstname.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firstname";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(162, 48);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(128, 22);
            this.txtMemberId.TabIndex = 14;
            // 
            // MemberID
            // 
            this.MemberID.AutoSize = true;
            this.MemberID.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberID.Location = new System.Drawing.Point(43, 48);
            this.MemberID.Name = "MemberID";
            this.MemberID.Size = new System.Drawing.Size(96, 19);
            this.MemberID.TabIndex = 13;
            this.MemberID.Text = "Member ID";
            // 
            // btnSearchById
            // 
            this.btnSearchById.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchById.Location = new System.Drawing.Point(371, 27);
            this.btnSearchById.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(168, 63);
            this.btnSearchById.TabIndex = 12;
            this.btnSearchById.Text = "Search by ID";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // errorMemberId
            // 
            this.errorMemberId.ContainerControl = this;
            // 
            // errorFirstname
            // 
            this.errorFirstname.ContainerControl = this;
            // 
            // errorLastname
            // 
            this.errorLastname.ContainerControl = this;
            // 
            // groupId
            // 
            this.groupId.Controls.Add(this.MemberID);
            this.groupId.Controls.Add(this.txtMemberId);
            this.groupId.Controls.Add(this.btnSearchById);
            this.groupId.Location = new System.Drawing.Point(248, 27);
            this.groupId.Name = "groupId";
            this.groupId.Size = new System.Drawing.Size(563, 116);
            this.groupId.TabIndex = 24;
            this.groupId.TabStop = false;
            // 
            // groupName
            // 
            this.groupName.Controls.Add(this.label2);
            this.groupName.Controls.Add(this.label1);
            this.groupName.Controls.Add(this.txtFirstname);
            this.groupName.Controls.Add(this.txtLastname);
            this.groupName.Controls.Add(this.btnSearchByName);
            this.groupName.Location = new System.Drawing.Point(248, 194);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(563, 138);
            this.groupName.TabIndex = 25;
            this.groupName.TabStop = false;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.gridSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(141, 352);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Size = new System.Drawing.Size(794, 214);
            this.groupSearchResults.TabIndex = 26;
            this.groupSearchResults.TabStop = false;
            // 
            // ManageMembersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 599);
            this.Controls.Add(this.groupSearchResults);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.groupId);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageMembersView";
            this.Text = "Manage Members";
            this.Load += new System.EventHandler(this.ManageMembersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).EndInit();
            this.groupId.ResumeLayout(false);
            this.groupId.PerformLayout();
            this.groupName.ResumeLayout(false);
            this.groupName.PerformLayout();
            this.groupSearchResults.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label MemberID;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.ErrorProvider errorMemberId;
        private System.Windows.Forms.ErrorProvider errorFirstname;
        private System.Windows.Forms.ErrorProvider errorLastname;
        private System.Windows.Forms.GroupBox groupSearchResults;
        private System.Windows.Forms.GroupBox groupName;
        private System.Windows.Forms.GroupBox groupId;
    }
}