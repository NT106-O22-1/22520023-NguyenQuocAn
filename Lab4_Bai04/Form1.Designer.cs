namespace Lab4_Bai04
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
            this.btnFetchMovies = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFetchMovies
            // 
            this.btnFetchMovies.Location = new System.Drawing.Point(25, 99);
            this.btnFetchMovies.Name = "btnFetchMovies";
            this.btnFetchMovies.Size = new System.Drawing.Size(146, 45);
            this.btnFetchMovies.TabIndex = 0;
            this.btnFetchMovies.Text = "Lấy dữ liệu";
            this.btnFetchMovies.UseVisualStyleBackColor = true;
            this.btnFetchMovies.Click += new System.EventHandler(this.btnFetchMovies_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(195, 434);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(660, 23);
            this.progressBar.TabIndex = 1;
            // 
            // flowLayoutPanelMovies
            // 
            this.flowLayoutPanelMovies.AutoScroll = true;
            this.flowLayoutPanelMovies.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMovies.Location = new System.Drawing.Point(195, 58);
            this.flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            this.flowLayoutPanelMovies.Size = new System.Drawing.Size(660, 367);
            this.flowLayoutPanelMovies.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(407, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phim đang chiếu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tạo input5.json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelMovies);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnFetchMovies);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(858, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetchMovies;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

