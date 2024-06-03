namespace Lab3_Bai04
{
    partial class Bai04
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
            this.button_Client = new System.Windows.Forms.Button();
            this.button_Server = new System.Windows.Forms.Button();
            this.button_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Client
            // 
            this.button_Client.Location = new System.Drawing.Point(140, 112);
            this.button_Client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Client.Name = "button_Client";
            this.button_Client.Size = new System.Drawing.Size(135, 47);
            this.button_Client.TabIndex = 0;
            this.button_Client.Text = "Client";
            this.button_Client.UseVisualStyleBackColor = true;
            this.button_Client.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // button_Server
            // 
            this.button_Server.Location = new System.Drawing.Point(420, 112);
            this.button_Server.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Server.Name = "button_Server";
            this.button_Server.Size = new System.Drawing.Size(135, 47);
            this.button_Server.TabIndex = 1;
            this.button_Server.Text = "Server";
            this.button_Server.UseVisualStyleBackColor = true;
            this.button_Server.Click += new System.EventHandler(this.button_Server_Click);
            // 
            // button_Admin
            // 
            this.button_Admin.Location = new System.Drawing.Point(283, 172);
            this.button_Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(135, 47);
            this.button_Admin.TabIndex = 2;
            this.button_Admin.Text = "Admin";
            this.button_Admin.UseVisualStyleBackColor = true;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 306);
            this.Controls.Add(this.button_Admin);
            this.Controls.Add(this.button_Server);
            this.Controls.Add(this.button_Client);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai04";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Client;
        private System.Windows.Forms.Button button_Server;
        private System.Windows.Forms.Button button_Admin;
    }
}

