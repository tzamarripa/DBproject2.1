namespace DBproject2._1
{
    partial class RegisterMemberView
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
            this.register = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
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
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.errorFirstname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDOB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStreet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorState = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorZipcode = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorZipcode)).BeginInit();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(661, 469);
            this.register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(108, 47);
            this.register.TabIndex = 32;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(297, 469);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(108, 47);
            this.clear.TabIndex = 31;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(477, 394);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(155, 22);
            this.txtZipcode.TabIndex = 30;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(477, 331);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtState.MaxLength = 30;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(155, 22);
            this.txtState.TabIndex = 29;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(477, 277);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 22);
            this.txtCity.TabIndex = 28;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(477, 213);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(155, 22);
            this.txtStreet.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(329, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Zipcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(329, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(329, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(329, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "DOB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(329, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(329, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(329, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Firstname";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(477, 97);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastname.MaxLength = 30;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(155, 22);
            this.txtLastname.TabIndex = 18;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(477, 38);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstname.MaxLength = 25;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(155, 22);
            this.txtFirstname.TabIndex = 17;
            // 
            // dateDob
            // 
            this.dateDob.Location = new System.Drawing.Point(477, 161);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(200, 22);
            this.dateDob.TabIndex = 33;
            // 
            // errorFirstname
            // 
            this.errorFirstname.ContainerControl = this;
            // 
            // errorLastname
            // 
            this.errorLastname.ContainerControl = this;
            // 
            // errorDOB
            // 
            this.errorDOB.ContainerControl = this;
            // 
            // errorStreet
            // 
            this.errorStreet.ContainerControl = this;
            // 
            // errorCity
            // 
            this.errorCity.ContainerControl = this;
            // 
            // errorState
            // 
            this.errorState.ContainerControl = this;
            // 
            // errorZipcode
            // 
            this.errorZipcode.ContainerControl = this;
            // 
            // RegisterMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateDob);
            this.Controls.Add(this.register);
            this.Controls.Add(this.clear);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterMemberView";
            this.Text = "Register Member";
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorZipcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button clear;
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
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.ErrorProvider errorFirstname;
        private System.Windows.Forms.ErrorProvider errorLastname;
        private System.Windows.Forms.ErrorProvider errorDOB;
        private System.Windows.Forms.ErrorProvider errorStreet;
        private System.Windows.Forms.ErrorProvider errorCity;
        private System.Windows.Forms.ErrorProvider errorState;
        private System.Windows.Forms.ErrorProvider errorZipcode;
    }
}