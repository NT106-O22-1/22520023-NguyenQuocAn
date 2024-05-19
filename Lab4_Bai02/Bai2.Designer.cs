namespace Lab4_Bai02
{
    partial class Bai2
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
            this.downloadBtn = new System.Windows.Forms.Button();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.pathTb = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(648, 40);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(106, 23);
            this.downloadBtn.TabIndex = 0;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(44, 29);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(432, 22);
            this.urlTb.TabIndex = 1;
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(44, 68);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(391, 22);
            this.pathTb.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(602, 274);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pathTb);
            this.Controls.Add(this.urlTb);
            this.Controls.Add(this.downloadBtn);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.TextBox urlTb;
        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}