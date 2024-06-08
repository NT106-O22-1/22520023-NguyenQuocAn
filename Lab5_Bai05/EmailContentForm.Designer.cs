namespace Lab5_Bai05
{
    partial class EmailContentForm
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
            this.fromLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.subjectLb = new System.Windows.Forms.Label();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // fromLb
            // 
            this.fromLb.AutoSize = true;
            this.fromLb.Location = new System.Drawing.Point(61, 9);
            this.fromLb.Name = "fromLb";
            this.fromLb.Size = new System.Drawing.Size(44, 16);
            this.fromLb.TabIndex = 2;
            this.fromLb.Text = "label3";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(61, 38);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(44, 16);
            this.dateLb.TabIndex = 3;
            this.dateLb.Text = "label3";
            // 
            // subjectLb
            // 
            this.subjectLb.AutoSize = true;
            this.subjectLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLb.Location = new System.Drawing.Point(12, 71);
            this.subjectLb.Name = "subjectLb";
            this.subjectLb.Size = new System.Drawing.Size(72, 20);
            this.subjectLb.TabIndex = 4;
            this.subjectLb.Text = "Subject";
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(16, 110);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(888, 416);
            this.webView.TabIndex = 5;
            this.webView.ZoomFactor = 1D;
            // 
            // EmailContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 538);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.subjectLb);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.fromLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmailContentForm";
            this.Text = "EmailContentForm";
            this.Load += new System.EventHandler(this.EmailContentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fromLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label subjectLb;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}