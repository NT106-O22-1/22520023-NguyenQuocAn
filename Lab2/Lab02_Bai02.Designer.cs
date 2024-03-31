namespace Lab2
{
    partial class Lab02_Bai02
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.sizeTxb = new System.Windows.Forms.TextBox();
            this.urlTxb = new System.Windows.Forms.TextBox();
            this.lineCountTxb = new System.Windows.Forms.TextBox();
            this.wordsCountTxb = new System.Windows.Forms.TextBox();
            this.charCountTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(322, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(466, 426);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(56, 12);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(196, 42);
            this.readBtn.TabIndex = 1;
            this.readBtn.Text = "Read from File";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Words count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Character count";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(27, 407);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(268, 31);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // nameTxb
            // 
            this.nameTxb.BackColor = System.Drawing.SystemColors.Window;
            this.nameTxb.Location = new System.Drawing.Point(138, 137);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.ReadOnly = true;
            this.nameTxb.Size = new System.Drawing.Size(157, 22);
            this.nameTxb.TabIndex = 9;
            // 
            // sizeTxb
            // 
            this.sizeTxb.BackColor = System.Drawing.SystemColors.Window;
            this.sizeTxb.Location = new System.Drawing.Point(138, 178);
            this.sizeTxb.Name = "sizeTxb";
            this.sizeTxb.ReadOnly = true;
            this.sizeTxb.Size = new System.Drawing.Size(157, 22);
            this.sizeTxb.TabIndex = 10;
            // 
            // urlTxb
            // 
            this.urlTxb.BackColor = System.Drawing.SystemColors.Window;
            this.urlTxb.Location = new System.Drawing.Point(138, 221);
            this.urlTxb.Name = "urlTxb";
            this.urlTxb.ReadOnly = true;
            this.urlTxb.Size = new System.Drawing.Size(157, 22);
            this.urlTxb.TabIndex = 11;
            // 
            // lineCountTxb
            // 
            this.lineCountTxb.BackColor = System.Drawing.SystemColors.Window;
            this.lineCountTxb.Location = new System.Drawing.Point(138, 255);
            this.lineCountTxb.Name = "lineCountTxb";
            this.lineCountTxb.ReadOnly = true;
            this.lineCountTxb.Size = new System.Drawing.Size(157, 22);
            this.lineCountTxb.TabIndex = 12;
            // 
            // wordsCountTxb
            // 
            this.wordsCountTxb.BackColor = System.Drawing.SystemColors.Window;
            this.wordsCountTxb.Location = new System.Drawing.Point(138, 296);
            this.wordsCountTxb.Name = "wordsCountTxb";
            this.wordsCountTxb.ReadOnly = true;
            this.wordsCountTxb.Size = new System.Drawing.Size(157, 22);
            this.wordsCountTxb.TabIndex = 13;
            // 
            // charCountTxb
            // 
            this.charCountTxb.BackColor = System.Drawing.SystemColors.Window;
            this.charCountTxb.Location = new System.Drawing.Point(138, 337);
            this.charCountTxb.Name = "charCountTxb";
            this.charCountTxb.ReadOnly = true;
            this.charCountTxb.Size = new System.Drawing.Size(157, 22);
            this.charCountTxb.TabIndex = 14;
            // 
            // Lab02_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charCountTxb);
            this.Controls.Add(this.wordsCountTxb);
            this.Controls.Add(this.lineCountTxb);
            this.Controls.Add(this.urlTxb);
            this.Controls.Add(this.sizeTxb);
            this.Controls.Add(this.nameTxb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.richTextBox);
            this.Name = "Lab02_Bai02";
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox nameTxb;
        private System.Windows.Forms.TextBox sizeTxb;
        private System.Windows.Forms.TextBox urlTxb;
        private System.Windows.Forms.TextBox lineCountTxb;
        private System.Windows.Forms.TextBox wordsCountTxb;
        private System.Windows.Forms.TextBox charCountTxb;
    }
}