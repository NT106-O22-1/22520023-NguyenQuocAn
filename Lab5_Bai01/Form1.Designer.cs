namespace Lab5_Bai01
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.richTextBox_Body = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.Location = new System.Drawing.Point(332, 216);
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(530, 31);
            this.textBox_Subject.TabIndex = 1;
            // 
            // richTextBox_Body
            // 
            this.richTextBox_Body.Location = new System.Drawing.Point(332, 291);
            this.richTextBox_Body.Name = "richTextBox_Body";
            this.richTextBox_Body.Size = new System.Drawing.Size(530, 100);
            this.richTextBox_Body.TabIndex = 2;
            this.richTextBox_Body.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body:";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(736, 123);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(125, 71);
            this.button_Send.TabIndex = 6;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 618);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Body);
            this.Controls.Add(this.textBox_Subject);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.RichTextBox richTextBox_Body;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Send;
    }
}

