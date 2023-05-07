namespace Restaurant
{
    partial class Home
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelNavBooking = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plMenu = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.plHead = new System.Windows.Forms.Panel();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnInsta = new System.Windows.Forms.Button();
            this.btnFace = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelNavBooking.SuspendLayout();
            this.plMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.plHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 67);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(0, 168);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(200, 67);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 366);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 67);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // panelNavBooking
            // 
            this.panelNavBooking.Controls.Add(this.button3);
            this.panelNavBooking.Controls.Add(this.button1);
            this.panelNavBooking.Location = new System.Drawing.Point(0, 233);
            this.panelNavBooking.Name = "panelNavBooking";
            this.panelNavBooking.Size = new System.Drawing.Size(200, 134);
            this.panelNavBooking.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 67);
            this.button3.TabIndex = 10;
            this.button3.Text = "History Booking";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 67);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quick Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnQuickBook_Click);
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.plMenu.Controls.Add(this.panelNavBooking);
            this.plMenu.Controls.Add(this.btnMenu);
            this.plMenu.Controls.Add(this.btnBooking);
            this.plMenu.Controls.Add(this.btnHome);
            this.plMenu.Controls.Add(this.pictureBox5);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(200, 823);
            this.plMenu.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Restaurant.Properties.Resources.Logo;
            this.pictureBox5.Location = new System.Drawing.Point(62, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // panelBooking
            // 
            this.panelBooking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooking.Location = new System.Drawing.Point(200, 103);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(950, 720);
            this.panelBooking.TabIndex = 2;
            // 
            // plHead
            // 
            this.plHead.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.plHead.Controls.Add(this.btnTwitter);
            this.plHead.Controls.Add(this.btnInsta);
            this.plHead.Controls.Add(this.btnFace);
            this.plHead.Controls.Add(this.btnProfile);
            this.plHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.plHead.Location = new System.Drawing.Point(200, 0);
            this.plHead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plHead.Name = "plHead";
            this.plHead.Size = new System.Drawing.Size(950, 103);
            this.plHead.TabIndex = 1;
            // 
            // btnTwitter
            // 
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Image = global::Restaurant.Properties.Resources.twitter;
            this.btnTwitter.Location = new System.Drawing.Point(294, 26);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(57, 53);
            this.btnTwitter.TabIndex = 7;
            this.btnTwitter.UseVisualStyleBackColor = true;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnInsta
            // 
            this.btnInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsta.Image = global::Restaurant.Properties.Resources.instagram;
            this.btnInsta.Location = new System.Drawing.Point(209, 26);
            this.btnInsta.Name = "btnInsta";
            this.btnInsta.Size = new System.Drawing.Size(57, 53);
            this.btnInsta.TabIndex = 6;
            this.btnInsta.UseVisualStyleBackColor = true;
            this.btnInsta.Click += new System.EventHandler(this.btnInsta_Click);
            // 
            // btnFace
            // 
            this.btnFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFace.Image = global::Restaurant.Properties.Resources.facebook;
            this.btnFace.Location = new System.Drawing.Point(131, 25);
            this.btnFace.Name = "btnFace";
            this.btnFace.Size = new System.Drawing.Size(57, 53);
            this.btnFace.TabIndex = 5;
            this.btnFace.UseVisualStyleBackColor = true;
            this.btnFace.Click += new System.EventHandler(this.btnFace_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Image = global::Restaurant.Properties.Resources.profile;
            this.btnProfile.Location = new System.Drawing.Point(862, 26);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(57, 53);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1150, 823);
            this.Controls.Add(this.panelBooking);
            this.Controls.Add(this.plHead);
            this.Controls.Add(this.plMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelNavBooking.ResumeLayout(false);
            this.plMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.plHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelNavBooking;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Panel plHead;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnInsta;
        private System.Windows.Forms.Button btnFace;
    }
}