namespace Lab5_Bai05
{
    partial class main
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imapTb = new System.Windows.Forms.TextBox();
            this.smtpTb = new System.Windows.Forms.TextBox();
            this.imapNum = new System.Windows.Forms.NumericUpDown();
            this.smtpNum = new System.Windows.Forms.NumericUpDown();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.pwTb = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.sendEmailBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadingLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imapNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "IMAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "IMAP Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "SMTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "SMTP Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password";
            // 
            // imapTb
            // 
            this.imapTb.Location = new System.Drawing.Point(463, 34);
            this.imapTb.Name = "imapTb";
            this.imapTb.Size = new System.Drawing.Size(140, 22);
            this.imapTb.TabIndex = 15;
            // 
            // smtpTb
            // 
            this.smtpTb.Location = new System.Drawing.Point(714, 34);
            this.smtpTb.Name = "smtpTb";
            this.smtpTb.Size = new System.Drawing.Size(140, 22);
            this.smtpTb.TabIndex = 16;
            // 
            // imapNum
            // 
            this.imapNum.Location = new System.Drawing.Point(463, 67);
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
            this.smtpNum.Location = new System.Drawing.Point(714, 67);
            this.smtpNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.smtpNum.Name = "smtpNum";
            this.smtpNum.Size = new System.Drawing.Size(140, 22);
            this.smtpNum.TabIndex = 18;
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(104, 21);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(223, 22);
            this.usernameTb.TabIndex = 22;
            // 
            // pwTb
            // 
            this.pwTb.Location = new System.Drawing.Point(104, 52);
            this.pwTb.Name = "pwTb";
            this.pwTb.Size = new System.Drawing.Size(223, 22);
            this.pwTb.TabIndex = 23;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(176, 80);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(151, 31);
            this.testBtn.TabIndex = 24;
            this.testBtn.Text = "Đăng nhập";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(365, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 124);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logoutBtn);
            this.groupBox2.Controls.Add(this.refreshBtn);
            this.groupBox2.Controls.Add(this.sendEmailBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.testBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pwTb);
            this.groupBox2.Controls.Add(this.usernameTb);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 124);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng nhập";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(228, 80);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(99, 31);
            this.logoutBtn.TabIndex = 28;
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Visible = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(121, 80);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(99, 31);
            this.refreshBtn.TabIndex = 26;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Visible = false;
            // 
            // sendEmailBtn
            // 
            this.sendEmailBtn.Location = new System.Drawing.Point(9, 80);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Size = new System.Drawing.Size(99, 31);
            this.sendEmailBtn.TabIndex = 25;
            this.sendEmailBtn.Text = "Gửi mail";
            this.sendEmailBtn.UseVisualStyleBackColor = true;
            this.sendEmailBtn.Visible = false;
            this.sendEmailBtn.Click += new System.EventHandler(this.sendEmailBtn_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderFrom,
            this.columnHeaderSubject});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 143);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(863, 330);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 120;
            // 
            // columnHeaderFrom
            // 
            this.columnHeaderFrom.Text = "From";
            this.columnHeaderFrom.Width = 220;
            // 
            // columnHeaderSubject
            // 
            this.columnHeaderSubject.Text = "Subject";
            this.columnHeaderSubject.Width = 600;
            // 
            // loadingLb
            // 
            this.loadingLb.AutoSize = true;
            this.loadingLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLb.Location = new System.Drawing.Point(408, 246);
            this.loadingLb.Name = "loadingLb";
            this.loadingLb.Size = new System.Drawing.Size(80, 20);
            this.loadingLb.TabIndex = 28;
            this.loadingLb.Text = "Loading...";
            this.loadingLb.Visible = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 485);
            this.Controls.Add(this.loadingLb);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.smtpNum);
            this.Controls.Add(this.imapNum);
            this.Controls.Add(this.smtpTb);
            this.Controls.Add(this.imapTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "main";
            this.Text = "Email Client";
            ((System.ComponentModel.ISupportInitialize)(this.imapNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox imapTb;
        private System.Windows.Forms.TextBox smtpTb;
        private System.Windows.Forms.NumericUpDown imapNum;
        private System.Windows.Forms.NumericUpDown smtpNum;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox pwTb;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button sendEmailBtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderFrom;
        private System.Windows.Forms.ColumnHeader columnHeaderSubject;
        private System.Windows.Forms.Label loadingLb;
    }
}