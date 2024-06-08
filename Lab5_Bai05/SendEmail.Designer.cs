namespace Lab5_Bai05
{
    partial class SendEmail
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.htmlCb = new System.Windows.Forms.CheckBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.fromTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.toTb = new System.Windows.Forms.TextBox();
            this.subjectTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pathTb = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body";
            // 
            // htmlCb
            // 
            this.htmlCb.AutoSize = true;
            this.htmlCb.Location = new System.Drawing.Point(113, 145);
            this.htmlCb.Name = "htmlCb";
            this.htmlCb.Size = new System.Drawing.Size(66, 20);
            this.htmlCb.TabIndex = 5;
            this.htmlCb.Text = "HTML";
            this.htmlCb.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(113, 171);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(367, 270);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // fromTb
            // 
            this.fromTb.Location = new System.Drawing.Point(113, 16);
            this.fromTb.Name = "fromTb";
            this.fromTb.ReadOnly = true;
            this.fromTb.Size = new System.Drawing.Size(367, 22);
            this.fromTb.TabIndex = 7;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(113, 47);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(367, 22);
            this.nameTb.TabIndex = 8;
            // 
            // toTb
            // 
            this.toTb.Location = new System.Drawing.Point(113, 78);
            this.toTb.Name = "toTb";
            this.toTb.Size = new System.Drawing.Size(367, 22);
            this.toTb.TabIndex = 9;
            // 
            // subjectTb
            // 
            this.subjectTb.Location = new System.Drawing.Point(113, 111);
            this.subjectTb.Name = "subjectTb";
            this.subjectTb.Size = new System.Drawing.Size(367, 22);
            this.subjectTb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Attachment";
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(113, 454);
            this.pathTb.Name = "pathTb";
            this.pathTb.ReadOnly = true;
            this.pathTb.Size = new System.Drawing.Size(286, 22);
            this.pathTb.TabIndex = 12;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(405, 453);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 13;
            this.browseBtn.Text = "Browse...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(342, 502);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(138, 37);
            this.sendBtn.TabIndex = 14;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 565);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subjectTb);
            this.Controls.Add(this.toTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.fromTb);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.htmlCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendEmail";
            this.Text = "Send Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox htmlCb;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox fromTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox toTb;
        private System.Windows.Forms.TextBox subjectTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button sendBtn;
    }
}