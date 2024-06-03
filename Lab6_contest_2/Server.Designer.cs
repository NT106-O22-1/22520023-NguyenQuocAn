namespace Lab6_contest_2
{
    partial class Server
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
            this.button_start_server = new System.Windows.Forms.Button();
            this.readJsonBtn = new System.Windows.Forms.Button();
            this.movieCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_start_server
            // 
            this.button_start_server.Location = new System.Drawing.Point(574, 98);
            this.button_start_server.Name = "button_start_server";
            this.button_start_server.Size = new System.Drawing.Size(75, 23);
            this.button_start_server.TabIndex = 0;
            this.button_start_server.Text = "Listen";
            this.button_start_server.UseVisualStyleBackColor = true;
            this.button_start_server.Click += new System.EventHandler(this.button_start_server_Click);
            // 
            // readJsonBtn
            // 
            this.readJsonBtn.Location = new System.Drawing.Point(574, 178);
            this.readJsonBtn.Name = "readJsonBtn";
            this.readJsonBtn.Size = new System.Drawing.Size(75, 23);
            this.readJsonBtn.TabIndex = 1;
            this.readJsonBtn.Text = "read";
            this.readJsonBtn.UseVisualStyleBackColor = true;
            this.readJsonBtn.Click += new System.EventHandler(this.readJsonBtn_Click);
            // 
            // movieCb
            // 
            this.movieCb.FormattingEnabled = true;
            this.movieCb.Location = new System.Drawing.Point(127, 65);
            this.movieCb.Name = "movieCb";
            this.movieCb.Size = new System.Drawing.Size(121, 24);
            this.movieCb.TabIndex = 2;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.movieCb);
            this.Controls.Add(this.readJsonBtn);
            this.Controls.Add(this.button_start_server);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start_server;
        private System.Windows.Forms.Button readJsonBtn;
        private System.Windows.Forms.ComboBox movieCb;
    }
}