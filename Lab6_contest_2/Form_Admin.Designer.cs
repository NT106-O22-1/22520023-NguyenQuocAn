namespace Lab6_Contest
{
    partial class Form_Admin
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Closed = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.nameClientTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(84, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 338);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button_Closed
            // 
            this.button_Closed.Location = new System.Drawing.Point(476, 159);
            this.button_Closed.Name = "button_Closed";
            this.button_Closed.Size = new System.Drawing.Size(108, 38);
            this.button_Closed.TabIndex = 1;
            this.button_Closed.Text = "Đóng quầy";
            this.button_Closed.UseVisualStyleBackColor = true;
            this.button_Closed.Click += new System.EventHandler(this.button_Closed_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(476, 231);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(108, 38);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "Mở quầy";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Danh sách Client";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(442, 51);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(173, 23);
            this.button_Connect.TabIndex = 4;
            this.button_Connect.Text = "Connect to server";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // nameClientTb
            // 
            this.nameClientTb.Location = new System.Drawing.Point(441, 131);
            this.nameClientTb.Name = "nameClientTb";
            this.nameClientTb.Size = new System.Drawing.Size(174, 22);
            this.nameClientTb.TabIndex = 5;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.nameClientTb);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Closed);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form_Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Closed;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox nameClientTb;
    }
}