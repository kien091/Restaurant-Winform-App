namespace Restaurant
{
    partial class quickBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBook = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.lbDanger = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panelChildren = new System.Windows.Forms.Panel();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMinus2 = new System.Windows.Forms.Button();
            this.btnDown2 = new System.Windows.Forms.Button();
            this.panelAdults = new System.Windows.Forms.Panel();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.btnDown1 = new System.Windows.Forms.Button();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.panelBook.SuspendLayout();
            this.panelChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAdults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBook
            // 
            this.panelBook.Controls.Add(this.btnContinue);
            this.panelBook.Controls.Add(this.dtpHour);
            this.panelBook.Controls.Add(this.lbDanger);
            this.panelBook.Controls.Add(this.dtpDate);
            this.panelBook.Controls.Add(this.panelChildren);
            this.panelBook.Controls.Add(this.btnDown2);
            this.panelBook.Controls.Add(this.panelAdults);
            this.panelBook.Controls.Add(this.txtChildren);
            this.panelBook.Controls.Add(this.btnDown1);
            this.panelBook.Controls.Add(this.txtAdults);
            this.panelBook.Controls.Add(this.label5);
            this.panelBook.Controls.Add(this.label4);
            this.panelBook.Controls.Add(this.label3);
            this.panelBook.Controls.Add(this.label2);
            this.panelBook.Controls.Add(this.label1);
            this.panelBook.Location = new System.Drawing.Point(120, 100);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(700, 500);
            this.panelBook.TabIndex = 1;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(528, 429);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(112, 45);
            this.btnContinue.TabIndex = 19;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // dtpHour
            // 
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHour.Location = new System.Drawing.Point(375, 293);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.Size = new System.Drawing.Size(219, 26);
            this.dtpHour.TabIndex = 18;
            this.dtpHour.ValueChanged += new System.EventHandler(this.dtpHour_ValueChanged);
            // 
            // lbDanger
            // 
            this.lbDanger.AutoSize = true;
            this.lbDanger.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbDanger.Location = new System.Drawing.Point(50, 351);
            this.lbDanger.Name = "lbDanger";
            this.lbDanger.Size = new System.Drawing.Size(0, 23);
            this.lbDanger.TabIndex = 17;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(54, 293);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 26);
            this.dtpDate.TabIndex = 16;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // panelChildren
            // 
            this.panelChildren.Controls.Add(this.btnAdd2);
            this.panelChildren.Controls.Add(this.txtNum2);
            this.panelChildren.Controls.Add(this.pictureBox2);
            this.panelChildren.Controls.Add(this.label7);
            this.panelChildren.Controls.Add(this.btnMinus2);
            this.panelChildren.Location = new System.Drawing.Point(376, 195);
            this.panelChildren.Name = "panelChildren";
            this.panelChildren.Size = new System.Drawing.Size(265, 44);
            this.panelChildren.TabIndex = 15;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(232, 10);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(30, 26);
            this.btnAdd2.TabIndex = 11;
            this.btnAdd2.Text = "+";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(178, 9);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(51, 26);
            this.txtNum2.TabIndex = 12;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurant.Properties.Resources.children;
            this.pictureBox2.Location = new System.Drawing.Point(0, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 31);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "(less than 12)";
            // 
            // btnMinus2
            // 
            this.btnMinus2.Location = new System.Drawing.Point(145, 9);
            this.btnMinus2.Name = "btnMinus2";
            this.btnMinus2.Size = new System.Drawing.Size(30, 26);
            this.btnMinus2.TabIndex = 10;
            this.btnMinus2.Text = "-";
            this.btnMinus2.UseVisualStyleBackColor = true;
            this.btnMinus2.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDown2
            // 
            this.btnDown2.Image = global::Restaurant.Properties.Resources.down1;
            this.btnDown2.Location = new System.Drawing.Point(617, 166);
            this.btnDown2.Name = "btnDown2";
            this.btnDown2.Size = new System.Drawing.Size(27, 26);
            this.btnDown2.TabIndex = 14;
            this.btnDown2.UseVisualStyleBackColor = true;
            this.btnDown2.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // panelAdults
            // 
            this.panelAdults.Controls.Add(this.btnAdd1);
            this.panelAdults.Controls.Add(this.txtNum1);
            this.panelAdults.Controls.Add(this.pictureBox1);
            this.panelAdults.Controls.Add(this.label6);
            this.panelAdults.Controls.Add(this.btnMinus1);
            this.panelAdults.Location = new System.Drawing.Point(54, 195);
            this.panelAdults.Name = "panelAdults";
            this.panelAdults.Size = new System.Drawing.Size(265, 44);
            this.panelAdults.TabIndex = 7;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(232, 10);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(30, 26);
            this.btnAdd1.TabIndex = 11;
            this.btnAdd1.Text = "+";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(178, 9);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(51, 26);
            this.txtNum1.TabIndex = 12;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant.Properties.Resources.adults;
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 31);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "(over 12)";
            // 
            // btnMinus1
            // 
            this.btnMinus1.Location = new System.Drawing.Point(145, 9);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(30, 26);
            this.btnMinus1.TabIndex = 10;
            this.btnMinus1.Text = "-";
            this.btnMinus1.UseVisualStyleBackColor = true;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtChildren
            // 
            this.txtChildren.Location = new System.Drawing.Point(375, 166);
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(265, 26);
            this.txtChildren.TabIndex = 13;
            this.txtChildren.Text = "0 person";
            // 
            // btnDown1
            // 
            this.btnDown1.Image = global::Restaurant.Properties.Resources.down1;
            this.btnDown1.Location = new System.Drawing.Point(292, 166);
            this.btnDown1.Name = "btnDown1";
            this.btnDown1.Size = new System.Drawing.Size(27, 26);
            this.btnDown1.TabIndex = 6;
            this.btnDown1.UseVisualStyleBackColor = true;
            this.btnDown1.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtAdults
            // 
            this.txtAdults.Location = new System.Drawing.Point(54, 166);
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.Size = new System.Drawing.Size(265, 26);
            this.txtAdults.TabIndex = 5;
            this.txtAdults.Text = "1 person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(375, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Booking Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(54, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Booking Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(375, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Children";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(54, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Adults";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Online";
            // 
            // pbPic
            // 
            this.pbPic.Image = global::Restaurant.Properties.Resources.booking;
            this.pbPic.Location = new System.Drawing.Point(0, 0);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(950, 720);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 0;
            this.pbPic.TabStop = false;
            // 
            // quickBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBook);
            this.Controls.Add(this.pbPic);
            this.Name = "quickBooking";
            this.Size = new System.Drawing.Size(950, 720);
            this.Load += new System.EventHandler(this.quickBooking_Load);
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            this.panelChildren.ResumeLayout(false);
            this.panelChildren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAdults.ResumeLayout(false);
            this.panelAdults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnMinus1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelAdults;
        private System.Windows.Forms.Button btnDown1;
        private System.Windows.Forms.TextBox txtAdults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChildren;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMinus2;
        private System.Windows.Forms.Button btnDown2;
        private System.Windows.Forms.TextBox txtChildren;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.DateTimePicker dtpHour;
        private System.Windows.Forms.Label lbDanger;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
