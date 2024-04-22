namespace Lab3_Bai06
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
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(654, 270);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(93, 47);
            this.button_Send.TabIndex = 0;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(318, 125);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(159, 26);
            this.textBox_Username.TabIndex = 1;
            // 
            // richTextBox_Message
            // 
            this.richTextBox_Message.Location = new System.Drawing.Point(230, 270);
            this.richTextBox_Message.Name = "richTextBox_Message";
            this.richTextBox_Message.Size = new System.Drawing.Size(306, 47);
            this.richTextBox_Message.TabIndex = 2;
            this.richTextBox_Message.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(654, 184);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(93, 36);
            this.button_Connect.TabIndex = 5;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Message);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.button_Send);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.RichTextBox richTextBox_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Connect;
    }
}