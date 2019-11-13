namespace DBproject2._1
{
    partial class EditMemberView
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
            this.errorZipcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStreet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDOB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFirstname = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.errorState = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConfirm = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupPassword = new System.Windows.Forms.GroupBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.checkBoxChangePassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorZipcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirm)).BeginInit();
            this.groupPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorZipcode
            // 
            this.errorZipcode.ContainerControl = this;
            // 
            // errorCity
            // 
            this.errorCity.ContainerControl = this;
            // 
            // errorStreet
            // 
            this.errorStreet.ContainerControl = this;
            // 
            // errorDOB
            // 
            this.errorDOB.ContainerControl = this;
            // 
            // errorLastname
            // 
            this.errorLastname.ContainerControl = this;
            // 
            // errorFirstname
            // 
            this.errorFirstname.ContainerControl = this;
            // 
            // dateDob
            // 
            this.dateDob.Location = new System.Drawing.Point(365, 148);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(200, 22);
            this.dateDob.TabIndex = 49;
            // 
            // errorState
            // 
            this.errorState.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(412, 581);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 47);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 581);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 47);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(365, 381);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(155, 22);
            this.txtZipcode.TabIndex = 46;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(365, 318);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtState.MaxLength = 30;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(155, 22);
            this.txtState.TabIndex = 45;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(365, 264);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 22);
            this.txtCity.TabIndex = 44;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(365, 200);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(155, 22);
            this.txtStreet.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(217, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Zipcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(217, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(217, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(217, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "DOB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(217, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(217, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(217, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Firstname";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(365, 84);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastname.MaxLength = 30;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(155, 22);
            this.txtLastname.TabIndex = 35;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(365, 25);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstname.MaxLength = 25;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(155, 22);
            this.txtFirstname.TabIndex = 34;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // errorConfirm
            // 
            this.errorConfirm.ContainerControl = this;
            // 
            // groupPassword
            // 
            this.groupPassword.Controls.Add(this.txtConfirm);
            this.groupPassword.Controls.Add(this.labelConfirm);
            this.groupPassword.Controls.Add(this.checkBoxChangePassword);
            this.groupPassword.Controls.Add(this.txtPassword);
            this.groupPassword.Controls.Add(this.labelPassword);
            this.groupPassword.Location = new System.Drawing.Point(221, 424);
            this.groupPassword.Name = "groupPassword";
            this.groupPassword.Size = new System.Drawing.Size(382, 138);
            this.groupPassword.TabIndex = 50;
            this.groupPassword.TabStop = false;
            this.groupPassword.Text = "Change Password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Enabled = false;
            this.txtConfirm.Location = new System.Drawing.Point(84, 81);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(265, 22);
            this.txtConfirm.TabIndex = 42;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Enabled = false;
            this.labelConfirm.Location = new System.Drawing.Point(7, 81);
            this.labelConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(56, 17);
            this.labelConfirm.TabIndex = 41;
            this.labelConfirm.Text = "Confirm";
            // 
            // checkBoxChangePassword
            // 
            this.checkBoxChangePassword.AutoSize = true;
            this.checkBoxChangePassword.Location = new System.Drawing.Point(6, 21);
            this.checkBoxChangePassword.Name = "checkBoxChangePassword";
            this.checkBoxChangePassword.Size = new System.Drawing.Size(79, 21);
            this.checkBoxChangePassword.TabIndex = 0;
            this.checkBoxChangePassword.Text = "Change";
            this.checkBoxChangePassword.UseVisualStyleBackColor = true;
            this.checkBoxChangePassword.CheckedChanged += new System.EventHandler(this.checkBoxChangePassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(84, 51);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 22);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Enabled = false;
            this.labelPassword.Location = new System.Drawing.Point(7, 54);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 39;
            this.labelPassword.Text = "Password";
            // 
            // EditMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.groupPassword);
            this.Controls.Add(this.dateDob);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Name = "EditMemberView";
            this.Text = "Edit Member";
            this.Load += new System.EventHandler(this.EditMemberView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorZipcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirm)).EndInit();
            this.groupPassword.ResumeLayout(false);
            this.groupPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorZipcode;
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.ErrorProvider errorCity;
        private System.Windows.Forms.ErrorProvider errorStreet;
        private System.Windows.Forms.ErrorProvider errorDOB;
        private System.Windows.Forms.ErrorProvider errorLastname;
        private System.Windows.Forms.ErrorProvider errorFirstname;
        private System.Windows.Forms.ErrorProvider errorState;
        private System.Windows.Forms.GroupBox groupPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.CheckBox checkBoxChangePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorConfirm;
    }
}