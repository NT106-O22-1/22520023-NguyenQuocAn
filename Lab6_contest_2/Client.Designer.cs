﻿namespace Lab2
{
    partial class Client
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
            this.writeBtn = new System.Windows.Forms.Button();
            this.screenCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movieCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // writeBtn
            // 
            this.writeBtn.Location = new System.Drawing.Point(38, 281);
            this.writeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(162, 52);
            this.writeBtn.TabIndex = 1;
            this.writeBtn.Text = "Xuất ouput5.json";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // screenCb
            // 
            this.screenCb.FormattingEnabled = true;
            this.screenCb.Location = new System.Drawing.Point(636, 43);
            this.screenCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.screenCb.Name = "screenCb";
            this.screenCb.Size = new System.Drawing.Size(121, 24);
            this.screenCb.TabIndex = 2;
            this.screenCb.SelectedValueChanged += new System.EventHandler(this.screenCb_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn phòng chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn phim";
            // 
            // movieCb
            // 
            this.movieCb.FormattingEnabled = true;
            this.movieCb.Location = new System.Drawing.Point(364, 43);
            this.movieCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieCb.Name = "movieCb";
            this.movieCb.Size = new System.Drawing.Size(121, 24);
            this.movieCb.TabIndex = 5;
            this.movieCb.SelectedValueChanged += new System.EventHandler(this.movieCb_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn chỗ ngồi";
            this.label3.Visible = false;
            // 
            // checkedListBox
            // 
            this.checkedListBox.ColumnWidth = 81;
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "A1",
            "B1",
            "C1",
            "A2",
            "B2",
            "C2",
            "A3",
            "B3",
            "C3",
            "A4",
            "B4",
            "C4",
            "A5",
            "B5",
            "C5"});
            this.checkedListBox.Location = new System.Drawing.Point(333, 160);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox.MultiColumn = true;
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(400, 109);
            this.checkedListBox.TabIndex = 7;
            this.checkedListBox.Visible = false;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Enabled = false;
            this.purchaseBtn.Location = new System.Drawing.Point(451, 298);
            this.purchaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(167, 52);
            this.purchaseBtn.TabIndex = 8;
            this.purchaseBtn.Text = "Mua vé";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lưu ý: \"sold\" là những ghế đã bán.\r\nCố tình chọn những ghế này có thể hiện \"Đặt v" +
    "é thành công\"\r\nTuy nhiên sẽ không được tính.";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(38, 176);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(162, 49);
            this.connectBtn.TabIndex = 10;
            this.connectBtn.Text = "Connect to server";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(38, 143);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(162, 27);
            this.nameTb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập tên quầy:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 469);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 493);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movieCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screenCb);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client";
            this.Text = "Lab02_Bai05";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.ComboBox screenCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox movieCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}