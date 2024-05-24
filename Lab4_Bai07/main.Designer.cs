namespace Lab4_Bai07
{
    partial class main
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
            this.authLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.randomBtn = new System.Windows.Forms.Button();
            this.addDishBtn = new System.Windows.Forms.Button();
            this.getAllDishesBtn = new System.Windows.Forms.Button();
            this.getMyDishesBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pageCb = new System.Windows.Forms.ComboBox();
            this.pageSizeCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // authLb
            // 
            this.authLb.AutoSize = true;
            this.authLb.ForeColor = System.Drawing.Color.Firebrick;
            this.authLb.Location = new System.Drawing.Point(15, 687);
            this.authLb.Name = "authLb";
            this.authLb.Size = new System.Drawing.Size(104, 16);
            this.authLb.TabIndex = 0;
            this.authLb.Text = "Unauthenticated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // randomBtn
            // 
            this.randomBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.randomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomBtn.Location = new System.Drawing.Point(462, 49);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(146, 48);
            this.randomBtn.TabIndex = 7;
            this.randomBtn.Text = "Ăn gì giờ?";
            this.randomBtn.UseVisualStyleBackColor = false;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // addDishBtn
            // 
            this.addDishBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addDishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDishBtn.Location = new System.Drawing.Point(310, 49);
            this.addDishBtn.Name = "addDishBtn";
            this.addDishBtn.Size = new System.Drawing.Size(146, 48);
            this.addDishBtn.TabIndex = 8;
            this.addDishBtn.Text = "Thêm món ăn";
            this.addDishBtn.UseVisualStyleBackColor = false;
            this.addDishBtn.Click += new System.EventHandler(this.addDishBtn_Click);
            // 
            // getAllDishesBtn
            // 
            this.getAllDishesBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.getAllDishesBtn.Location = new System.Drawing.Point(18, 79);
            this.getAllDishesBtn.Name = "getAllDishesBtn";
            this.getAllDishesBtn.Size = new System.Drawing.Size(71, 40);
            this.getAllDishesBtn.TabIndex = 9;
            this.getAllDishesBtn.Text = "All";
            this.getAllDishesBtn.UseVisualStyleBackColor = false;
            this.getAllDishesBtn.Click += new System.EventHandler(this.getAllDishesBtn_Click);
            // 
            // getMyDishesBtn
            // 
            this.getMyDishesBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.getMyDishesBtn.Location = new System.Drawing.Point(87, 79);
            this.getMyDishesBtn.Name = "getMyDishesBtn";
            this.getMyDishesBtn.Size = new System.Drawing.Size(117, 40);
            this.getMyDishesBtn.TabIndex = 10;
            this.getMyDishesBtn.Text = "Tôi đóng góp";
            this.getMyDishesBtn.UseVisualStyleBackColor = false;
            this.getMyDishesBtn.Click += new System.EventHandler(this.getMyDishesBtn_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(18, 114);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(590, 545);
            this.flowLayoutPanel.TabIndex = 11;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // pageCb
            // 
            this.pageCb.FormattingEnabled = true;
            this.pageCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.pageCb.Location = new System.Drawing.Point(400, 679);
            this.pageCb.Name = "pageCb";
            this.pageCb.Size = new System.Drawing.Size(56, 24);
            this.pageCb.TabIndex = 12;
            // 
            // pageSizeCb
            // 
            this.pageSizeCb.FormattingEnabled = true;
            this.pageSizeCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.pageSizeCb.Location = new System.Drawing.Point(552, 679);
            this.pageSizeCb.Name = "pageSizeCb";
            this.pageSizeCb.Size = new System.Drawing.Size(56, 24);
            this.pageSizeCb.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Page Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Page";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(170, 680);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(151, 23);
            this.progressBar.TabIndex = 16;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(620, 715);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pageSizeCb);
            this.Controls.Add(this.pageCb);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.getMyDishesBtn);
            this.Controls.Add(this.getAllDishesBtn);
            this.Controls.Add(this.addDishBtn);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authLb);
            this.Enabled = false;
            this.Name = "main";
            this.Text = "Hôm nay ăn gì?";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.EnabledChanged += new System.EventHandler(this.getAllDishesBtn_Click);
            this.Click += new System.EventHandler(this.main_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button addDishBtn;
        private System.Windows.Forms.Button getAllDishesBtn;
        private System.Windows.Forms.Button getMyDishesBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ComboBox pageCb;
        private System.Windows.Forms.ComboBox pageSizeCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

