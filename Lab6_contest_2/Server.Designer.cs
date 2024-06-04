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
            this.Log = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start_server
            // 
            this.button_start_server.Location = new System.Drawing.Point(110, 292);
            this.button_start_server.Name = "button_start_server";
            this.button_start_server.Size = new System.Drawing.Size(221, 51);
            this.button_start_server.TabIndex = 0;
            this.button_start_server.Text = "Listen";
            this.button_start_server.UseVisualStyleBackColor = true;
            this.button_start_server.Click += new System.EventHandler(this.button_start_server_Click);
            // 
            // readJsonBtn
            // 
            this.readJsonBtn.Location = new System.Drawing.Point(46, 64);
            this.readJsonBtn.Name = "readJsonBtn";
            this.readJsonBtn.Size = new System.Drawing.Size(148, 52);
            this.readJsonBtn.TabIndex = 1;
            this.readJsonBtn.Text = "Đọc input5.json";
            this.readJsonBtn.UseVisualStyleBackColor = true;
            this.readJsonBtn.Click += new System.EventHandler(this.readJsonBtn_Click);
            // 
            // movieCb
            // 
            this.movieCb.FormattingEnabled = true;
            this.movieCb.Location = new System.Drawing.Point(247, 92);
            this.movieCb.Name = "movieCb";
            this.movieCb.Size = new System.Drawing.Size(121, 24);
            this.movieCb.TabIndex = 2;
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.HideSelection = false;
            this.Log.Location = new System.Drawing.Point(471, 12);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(317, 426);
            this.Log.TabIndex = 3;
            this.Log.UseCompatibleStateImageBehavior = false;
            this.Log.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách phim:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.movieCb);
            this.groupBox1.Controls.Add(this.readJsonBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.button_start_server);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start_server;
        private System.Windows.Forms.Button readJsonBtn;
        private System.Windows.Forms.ComboBox movieCb;
        private System.Windows.Forms.ListView Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}