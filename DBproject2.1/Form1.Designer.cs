using System;
using System.Windows.Forms;

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
            this.btnMember = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnLibrarian = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMember.AutoSize = true;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(380, 151);
            this.btnMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(256, 44);
            this.btnMember.TabIndex = 0;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(380, 254);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(256, 44);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.Checkoutbutton_Click);
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.Location = new System.Drawing.Point(380, 379);
            this.btnLibrarian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Size = new System.Drawing.Size(256, 44);
            this.btnLibrarian.TabIndex = 2;
            this.btnLibrarian.Text = "Librarian";
            this.btnLibrarian.UseVisualStyleBackColor = true;
            this.btnLibrarian.Click += new System.EventHandler(this.Librarianbutton_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please choose interface";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLibrarian);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnMember);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Library App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.Label label1;
    }
}

