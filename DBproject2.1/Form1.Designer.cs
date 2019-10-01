namespace DBproject2._1
{
    partial class Form1
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
            this.custbutton = new System.Windows.Forms.Button();
            this.Checkoutbutton = new System.Windows.Forms.Button();
            this.Librarianbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // custbutton
            // 
            this.custbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.custbutton.AutoSize = true;
            this.custbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.custbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custbutton.Location = new System.Drawing.Point(285, 123);
            this.custbutton.Name = "custbutton";
            this.custbutton.Size = new System.Drawing.Size(192, 36);
            this.custbutton.TabIndex = 0;
            this.custbutton.Text = "Customer";
            this.custbutton.UseVisualStyleBackColor = true;
            this.custbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Checkoutbutton
            // 
            this.Checkoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkoutbutton.Location = new System.Drawing.Point(285, 206);
            this.Checkoutbutton.Name = "Checkoutbutton";
            this.Checkoutbutton.Size = new System.Drawing.Size(192, 36);
            this.Checkoutbutton.TabIndex = 1;
            this.Checkoutbutton.Text = "Checkout";
            this.Checkoutbutton.UseVisualStyleBackColor = true;
            this.Checkoutbutton.Click += new System.EventHandler(this.Checkoutbutton_Click);
            // 
            // Librarianbutton
            // 
            this.Librarianbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Librarianbutton.Location = new System.Drawing.Point(285, 308);
            this.Librarianbutton.Name = "Librarianbutton";
            this.Librarianbutton.Size = new System.Drawing.Size(192, 36);
            this.Librarianbutton.TabIndex = 2;
            this.Librarianbutton.Text = "Librarian";
            this.Librarianbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please choose interface";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Librarianbutton);
            this.Controls.Add(this.Checkoutbutton);
            this.Controls.Add(this.custbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button custbutton;
        private System.Windows.Forms.Button Checkoutbutton;
        private System.Windows.Forms.Button Librarianbutton;
        private System.Windows.Forms.Label label1;
    }
}

