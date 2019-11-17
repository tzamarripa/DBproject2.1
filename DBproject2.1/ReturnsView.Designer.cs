namespace DBproject2._1
{
    partial class ReturnsView
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
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.errorBarcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.richLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorBarcode)).BeginInit();
            this.groupLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(565, 69);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(173, 82);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBarcode.Location = new System.Drawing.Point(373, 105);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(174, 22);
            this.txtBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(227, 94);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(126, 36);
            this.lblBarcode.TabIndex = 3;
            this.lblBarcode.Text = "Barcode";
            // 
            // errorBarcode
            // 
            this.errorBarcode.ContainerControl = this;
            // 
            // groupLog
            // 
            this.groupLog.Controls.Add(this.richLog);
            this.groupLog.Location = new System.Drawing.Point(100, 175);
            this.groupLog.Name = "groupLog";
            this.groupLog.Size = new System.Drawing.Size(852, 334);
            this.groupLog.TabIndex = 4;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Activity Log";
            // 
            // richLog
            // 
            this.richLog.CausesValidation = false;
            this.richLog.DetectUrls = false;
            this.richLog.Location = new System.Drawing.Point(7, 22);
            this.richLog.Name = "richLog";
            this.richLog.ReadOnly = true;
            this.richLog.Size = new System.Drawing.Size(839, 306);
            this.richLog.TabIndex = 0;
            this.richLog.Text = "";
            this.richLog.WordWrap = false;
            // 
            // ReturnsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupLog);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnReceive);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReturnsView";
            this.Text = "Process Returns";
            this.Load += new System.EventHandler(this.ReturnsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorBarcode)).EndInit();
            this.groupLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.ErrorProvider errorBarcode;
        private System.Windows.Forms.GroupBox groupLog;
        private System.Windows.Forms.RichTextBox richLog;
    }
}