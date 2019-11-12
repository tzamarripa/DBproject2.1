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
            this.count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchname = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerid = new System.Windows.Forms.TextBox();
            this.MemberID = new System.Windows.Forms.Label();
            this.searchID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.count.Location = new System.Drawing.Point(188, 242);
            this.count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(44, 15);
            this.count.TabIndex = 23;
            this.count.Text = "count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(82, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Search Results:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 283);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(584, 144);
            this.dataGridView1.TabIndex = 21;
            // 
            // searchname
            // 
            this.searchname.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchname.Location = new System.Drawing.Point(566, 176);
            this.searchname.Margin = new System.Windows.Forms.Padding(2);
            this.searchname.Name = "searchname";
            this.searchname.Size = new System.Drawing.Size(96, 51);
            this.searchname.TabIndex = 20;
            this.searchname.Text = "search by name";
            this.searchname.UseVisualStyleBackColor = true;
            this.searchname.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(279, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(186, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "last name";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(326, 194);
            this.lastname.Margin = new System.Windows.Forms.Padding(2);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(97, 20);
            this.lastname.TabIndex = 17;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(326, 149);
            this.firstname.Margin = new System.Windows.Forms.Padding(2);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(97, 20);
            this.firstname.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(183, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "first name";
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(326, 30);
            this.customerid.Margin = new System.Windows.Forms.Padding(2);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(97, 20);
            this.customerid.TabIndex = 14;
            // 
            // MemberID
            // 
            this.MemberID.AutoSize = true;
            this.MemberID.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberID.Location = new System.Drawing.Point(186, 33);
            this.MemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberID.Name = "MemberID";
            this.MemberID.Size = new System.Drawing.Size(76, 15);
            this.MemberID.TabIndex = 13;
            this.MemberID.Text = "Member ID";
            // 
            // searchID
            // 
            this.searchID.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchID.Location = new System.Drawing.Point(566, 41);
            this.searchID.Margin = new System.Windows.Forms.Padding(2);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(96, 51);
            this.searchID.TabIndex = 12;
            this.searchID.Text = "search by ID";
            this.searchID.UseVisualStyleBackColor = true;
            this.searchID.Click += new System.EventHandler(this.searchID_Click);
            // 
            // ManageMembersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.MemberID);
            this.Controls.Add(this.searchID);
            this.Name = "ManageMembersView";
            this.Text = "Manage Members";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.Label MemberID;
        private System.Windows.Forms.Button searchID;
    }
}