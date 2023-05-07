namespace Restaurant
{
    partial class VerifyEmail
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
            this.lbNotice = new System.Windows.Forms.Label();
            this.lbValid = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDanger = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.RichTextBox();
            this.btnResend = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Location = new System.Drawing.Point(38, 43);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(137, 20);
            this.lbNotice.TabIndex = 0;
            this.lbNotice.Text = "OTP was send to: ";
            // 
            // lbValid
            // 
            this.lbValid.AutoSize = true;
            this.lbValid.Location = new System.Drawing.Point(38, 89);
            this.lbValid.Name = "lbValid";
            this.lbValid.Size = new System.Drawing.Size(153, 20);
            this.lbValid.TabIndex = 1;
            this.lbValid.Text = "OTP code is valid in: ";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(200, 89);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 20);
            this.lbCount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Haven\'t received OTP yet?";
            // 
            // lbDanger
            // 
            this.lbDanger.AutoSize = true;
            this.lbDanger.Location = new System.Drawing.Point(38, 268);
            this.lbDanger.Name = "lbDanger";
            this.lbDanger.Size = new System.Drawing.Size(0, 20);
            this.lbDanger.TabIndex = 4;
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(38, 135);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(415, 64);
            this.txtOTP.TabIndex = 5;
            this.txtOTP.Text = "";
            // 
            // btnResend
            // 
            this.btnResend.Location = new System.Drawing.Point(341, 205);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(112, 39);
            this.btnResend.TabIndex = 6;
            this.btnResend.Text = "&Resend";
            this.btnResend.UseVisualStyleBackColor = true;
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(330, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 43);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // VerifyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 359);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnResend);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.lbDanger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbValid);
            this.Controls.Add(this.lbNotice);
            this.Name = "VerifyEmail";
            this.Text = "Verify";
            this.Load += new System.EventHandler(this.VerifyEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Label lbValid;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDanger;
        private System.Windows.Forms.RichTextBox txtOTP;
        private System.Windows.Forms.Button btnResend;
        private System.Windows.Forms.Button btnSubmit;
    }
}