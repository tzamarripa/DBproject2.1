namespace DBproject2._1
{
    partial class Checkout
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
            this.checkoutlabel = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.btnContinueMemberId = new System.Windows.Forms.Button();
            this.groupMemberId = new System.Windows.Forms.GroupBox();
            this.lblMemberIdError = new System.Windows.Forms.Label();
            this.groupMemberId.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkoutlabel
            // 
            this.checkoutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutlabel.Location = new System.Drawing.Point(417, 46);
            this.checkoutlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkoutlabel.Name = "checkoutlabel";
            this.checkoutlabel.Size = new System.Drawing.Size(229, 33);
            this.checkoutlabel.TabIndex = 0;
            this.checkoutlabel.Text = "Library checkout";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(35, 90);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(97, 20);
            this.lblMemberId.TabIndex = 1;
            this.lblMemberId.Text = "Member ID:";
            // 
            // txtMemberId
            // 
            this.txtMemberId.AllowDrop = true;
            this.txtMemberId.Location = new System.Drawing.Point(184, 88);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ShortcutsEnabled = false;
            this.txtMemberId.Size = new System.Drawing.Size(255, 22);
            this.txtMemberId.TabIndex = 2;
            // 
            // btnContinueMemberId
            // 
            this.btnContinueMemberId.Location = new System.Drawing.Point(151, 185);
            this.btnContinueMemberId.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinueMemberId.Name = "btnContinueMemberId";
            this.btnContinueMemberId.Size = new System.Drawing.Size(159, 42);
            this.btnContinueMemberId.TabIndex = 3;
            this.btnContinueMemberId.Text = "Continue";
            this.btnContinueMemberId.UseVisualStyleBackColor = true;
            this.btnContinueMemberId.Click += new System.EventHandler(this.btnContinueMemberId_Click);
            // 
            // groupMemberId
            // 
            this.groupMemberId.Controls.Add(this.lblMemberIdError);
            this.groupMemberId.Controls.Add(this.txtMemberId);
            this.groupMemberId.Controls.Add(this.btnContinueMemberId);
            this.groupMemberId.Controls.Add(this.lblMemberId);
            this.groupMemberId.Location = new System.Drawing.Point(296, 97);
            this.groupMemberId.Name = "groupMemberId";
            this.groupMemberId.Size = new System.Drawing.Size(458, 296);
            this.groupMemberId.TabIndex = 4;
            this.groupMemberId.TabStop = false;
            // 
            // lblMemberIdError
            // 
            this.lblMemberIdError.AutoSize = true;
            this.lblMemberIdError.ForeColor = System.Drawing.Color.Red;
            this.lblMemberIdError.Location = new System.Drawing.Point(165, 136);
            this.lblMemberIdError.Name = "lblMemberIdError";
            this.lblMemberIdError.Size = new System.Drawing.Size(0, 17);
            this.lblMemberIdError.TabIndex = 4;
            this.lblMemberIdError.Visible = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupMemberId);
            this.Controls.Add(this.checkoutlabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Checkout_FormClosed);
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.groupMemberId.ResumeLayout(false);
            this.groupMemberId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label checkoutlabel;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Button btnContinueMemberId;
        private System.Windows.Forms.GroupBox groupMemberId;
        private System.Windows.Forms.Label lblMemberIdError;
    }
}