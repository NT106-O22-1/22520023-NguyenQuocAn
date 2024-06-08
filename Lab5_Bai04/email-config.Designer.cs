namespace Lab5_Bai04
{
    partial class email_config
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Labellllll = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imapTb = new System.Windows.Forms.TextBox();
            this.smtpTb = new System.Windows.Forms.TextBox();
            this.imapNum = new System.Windows.Forms.NumericUpDown();
            this.smtpNum = new System.Windows.Forms.NumericUpDown();
            this.imapSslCb = new System.Windows.Forms.CheckBox();
            this.smtpSslCb = new System.Windows.Forms.CheckBox();
            this.nicknameTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.pwTb = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imapNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "IMAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "IMAP Port";
            // 
            // Labellllll
            // 
            this.Labellllll.AutoSize = true;
            this.Labellllll.Location = new System.Drawing.Point(275, 79);
            this.Labellllll.Name = "Labellllll";
            this.Labellllll.Size = new System.Drawing.Size(45, 16);
            this.Labellllll.TabIndex = 10;
            this.Labellllll.Text = "SMTP";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(275, 111);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(72, 16);
            this.Label.TabIndex = 11;
            this.Label.Text = "SMTP Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nickname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password";
            // 
            // imapTb
            // 
            this.imapTb.Location = new System.Drawing.Point(110, 76);
            this.imapTb.Name = "imapTb";
            this.imapTb.Size = new System.Drawing.Size(140, 22);
            this.imapTb.TabIndex = 15;
            // 
            // smtpTb
            // 
            this.smtpTb.Location = new System.Drawing.Point(361, 76);
            this.smtpTb.Name = "smtpTb";
            this.smtpTb.Size = new System.Drawing.Size(140, 22);
            this.smtpTb.TabIndex = 16;
            // 
            // imapNum
            // 
            this.imapNum.Location = new System.Drawing.Point(110, 109);
            this.imapNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.imapNum.Name = "imapNum";
            this.imapNum.Size = new System.Drawing.Size(140, 22);
            this.imapNum.TabIndex = 17;
            // 
            // smtpNum
            // 
            this.smtpNum.Location = new System.Drawing.Point(361, 109);
            this.smtpNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.smtpNum.Name = "smtpNum";
            this.smtpNum.Size = new System.Drawing.Size(140, 22);
            this.smtpNum.TabIndex = 18;
            // 
            // imapSslCb
            // 
            this.imapSslCb.AutoSize = true;
            this.imapSslCb.Location = new System.Drawing.Point(110, 149);
            this.imapSslCb.Name = "imapSslCb";
            this.imapSslCb.Size = new System.Drawing.Size(105, 20);
            this.imapSslCb.TabIndex = 19;
            this.imapSslCb.Text = "Require SSL";
            this.imapSslCb.UseVisualStyleBackColor = true;
            // 
            // smtpSslCb
            // 
            this.smtpSslCb.AutoSize = true;
            this.smtpSslCb.Location = new System.Drawing.Point(361, 149);
            this.smtpSslCb.Name = "smtpSslCb";
            this.smtpSslCb.Size = new System.Drawing.Size(105, 20);
            this.smtpSslCb.TabIndex = 20;
            this.smtpSslCb.Text = "Require SSL";
            this.smtpSslCb.UseVisualStyleBackColor = true;
            // 
            // nicknameTb
            // 
            this.nicknameTb.Location = new System.Drawing.Point(116, 220);
            this.nicknameTb.Name = "nicknameTb";
            this.nicknameTb.Size = new System.Drawing.Size(198, 22);
            this.nicknameTb.TabIndex = 21;
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(116, 254);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(198, 22);
            this.usernameTb.TabIndex = 22;
            // 
            // pwTb
            // 
            this.pwTb.Location = new System.Drawing.Point(116, 290);
            this.pwTb.Name = "pwTb";
            this.pwTb.Size = new System.Drawing.Size(198, 22);
            this.pwTb.TabIndex = 23;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(340, 223);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(182, 33);
            this.testBtn.TabIndex = 24;
            this.testBtn.Text = "Test connection";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(340, 262);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(182, 65);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save Exit";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 134);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email server configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 133);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account";
            // 
            // email_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 343);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.pwTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.nicknameTb);
            this.Controls.Add(this.smtpSslCb);
            this.Controls.Add(this.imapSslCb);
            this.Controls.Add(this.smtpNum);
            this.Controls.Add(this.imapNum);
            this.Controls.Add(this.smtpTb);
            this.Controls.Add(this.imapTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Labellllll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "email_config";
            this.Text = "Email Setting";
            ((System.ComponentModel.ISupportInitialize)(this.imapNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Labellllll;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox imapTb;
        private System.Windows.Forms.TextBox smtpTb;
        private System.Windows.Forms.NumericUpDown imapNum;
        private System.Windows.Forms.NumericUpDown smtpNum;
        private System.Windows.Forms.CheckBox imapSslCb;
        private System.Windows.Forms.CheckBox smtpSslCb;
        private System.Windows.Forms.TextBox nicknameTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox pwTb;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}