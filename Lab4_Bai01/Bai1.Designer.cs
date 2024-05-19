namespace Lab4_Bai01
{
    partial class Bai1
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
            this.szURLtb = new System.Windows.Forms.TextBox();
            this.getBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // szURLtb
            // 
            this.szURLtb.Location = new System.Drawing.Point(12, 12);
            this.szURLtb.Name = "szURLtb";
            this.szURLtb.Size = new System.Drawing.Size(647, 22);
            this.szURLtb.TabIndex = 0;
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(698, 12);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(75, 23);
            this.getBtn.TabIndex = 1;
            this.getBtn.Text = "GET";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 398);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.szURLtb);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox szURLtb;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

