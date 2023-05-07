namespace Restaurant
{
    partial class Login
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
            this.grBLogin = new System.Windows.Forms.GroupBox();
            this.lbSignUp = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ckRemember = new System.Windows.Forms.CheckBox();
            this.llbForgot = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDanger = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenEye = new System.Windows.Forms.Button();
            this.btnCloseEye = new System.Windows.Forms.Button();
            this.grBLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grBLogin
            // 
            this.grBLogin.Controls.Add(this.pictureBox1);
            this.grBLogin.Controls.Add(this.lbSignUp);
            this.grBLogin.Controls.Add(this.btnLogin);
            this.grBLogin.Controls.Add(this.ckRemember);
            this.grBLogin.Controls.Add(this.llbForgot);
            this.grBLogin.Controls.Add(this.btnOpenEye);
            this.grBLogin.Controls.Add(this.btnCloseEye);
            this.grBLogin.Controls.Add(this.txtPassword);
            this.grBLogin.Controls.Add(this.txtEmail);
            this.grBLogin.Controls.Add(this.label4);
            this.grBLogin.Controls.Add(this.lbDanger);
            this.grBLogin.Controls.Add(this.lbPassword);
            this.grBLogin.Controls.Add(this.label1);
            this.grBLogin.Location = new System.Drawing.Point(22, 13);
            this.grBLogin.Name = "grBLogin";
            this.grBLogin.Size = new System.Drawing.Size(719, 436);
            this.grBLogin.TabIndex = 0;
            this.grBLogin.TabStop = false;
            this.grBLogin.Text = "Login";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Location = new System.Drawing.Point(164, 373);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(140, 20);
            this.lbSignUp.TabIndex = 13;
            this.lbSignUp.TabStop = true;
            this.lbSignUp.Text = "Create an account";
            this.lbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSignUp_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(206, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 38);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ckRemember
            // 
            this.ckRemember.AutoSize = true;
            this.ckRemember.Location = new System.Drawing.Point(33, 303);
            this.ckRemember.Name = "ckRemember";
            this.ckRemember.Size = new System.Drawing.Size(140, 24);
            this.ckRemember.TabIndex = 11;
            this.ckRemember.Text = "Remember me";
            this.ckRemember.UseVisualStyleBackColor = true;
            // 
            // llbForgot
            // 
            this.llbForgot.AutoSize = true;
            this.llbForgot.Location = new System.Drawing.Point(198, 167);
            this.llbForgot.Name = "llbForgot";
            this.llbForgot.Size = new System.Drawing.Size(137, 20);
            this.llbForgot.TabIndex = 10;
            this.llbForgot.TabStop = true;
            this.llbForgot.Text = "Forgot password?";
            this.llbForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgot_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(24, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Don\'t a member";
            // 
            // lbDanger
            // 
            this.lbDanger.AutoSize = true;
            this.lbDanger.Location = new System.Drawing.Point(26, 240);
            this.lbDanger.Name = "lbDanger";
            this.lbDanger.Size = new System.Drawing.Size(0, 20);
            this.lbDanger.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(26, 169);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(78, 20);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant.Properties.Resources._20944201;
            this.pictureBox1.Location = new System.Drawing.Point(360, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenEye
            // 
            this.btnOpenEye.Image = global::Restaurant.Properties.Resources.OpenEye4;
            this.btnOpenEye.Location = new System.Drawing.Point(303, 193);
            this.btnOpenEye.Name = "btnOpenEye";
            this.btnOpenEye.Size = new System.Drawing.Size(33, 33);
            this.btnOpenEye.TabIndex = 9;
            this.btnOpenEye.UseVisualStyleBackColor = true;
            this.btnOpenEye.Click += new System.EventHandler(this.btnOpenEye_Click);
            // 
            // btnCloseEye
            // 
            this.btnCloseEye.Image = global::Restaurant.Properties.Resources.CloseEye;
            this.btnCloseEye.Location = new System.Drawing.Point(303, 192);
            this.btnCloseEye.Name = "btnCloseEye";
            this.btnCloseEye.Size = new System.Drawing.Size(33, 33);
            this.btnCloseEye.TabIndex = 8;
            this.btnCloseEye.UseVisualStyleBackColor = true;
            this.btnCloseEye.Click += new System.EventHandler(this.btnCloseEye_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 466);
            this.Controls.Add(this.grBLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grBLogin.ResumeLayout(false);
            this.grBLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDanger;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox ckRemember;
        private System.Windows.Forms.LinkLabel llbForgot;
        private System.Windows.Forms.Button btnOpenEye;
        private System.Windows.Forms.Button btnCloseEye;
    }
}