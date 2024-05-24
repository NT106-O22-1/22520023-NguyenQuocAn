namespace Lab4_Bai03
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.downrscBtn = new System.Windows.Forms.Button();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 11);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 32);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(640, 12);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(75, 32);
            this.reloadBtn.TabIndex = 1;
            this.reloadBtn.Text = "reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(428, 52);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(128, 32);
            this.downloadBtn.TabIndex = 2;
            this.downloadBtn.Text = "Down Files";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // downrscBtn
            // 
            this.downrscBtn.Location = new System.Drawing.Point(562, 52);
            this.downrscBtn.Name = "downrscBtn";
            this.downrscBtn.Size = new System.Drawing.Size(153, 32);
            this.downrscBtn.TabIndex = 3;
            this.downrscBtn.Text = "Down Resources";
            this.downrscBtn.UseVisualStyleBackColor = true;
            this.downrscBtn.Click += new System.EventHandler(this.downrscBtn_Click);
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(93, 12);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(530, 22);
            this.urlTb.TabIndex = 4;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 90);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(703, 401);
            this.webView.TabIndex = 5;
            this.webView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 503);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.urlTb);
            this.Controls.Add(this.downrscBtn);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.loadBtn);
            this.Name = "Form1";
            this.Text = "Bài 3";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button downrscBtn;
        private System.Windows.Forms.TextBox urlTb;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

