namespace Lab2
{
    partial class Lab02_Bai06
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxb = new System.Windows.Forms.TextBox();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.idma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resTxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDMA";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idma,
            this.tenmonan});
            this.dataGridView.Location = new System.Drawing.Point(326, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(426, 254);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TenMonAn";
            // 
            // idTxb
            // 
            this.idTxb.Location = new System.Drawing.Point(139, 49);
            this.idTxb.Name = "idTxb";
            this.idTxb.Size = new System.Drawing.Size(127, 22);
            this.idTxb.TabIndex = 5;
            // 
            // nameTxb
            // 
            this.nameTxb.Location = new System.Drawing.Point(139, 90);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(127, 22);
            this.nameTxb.TabIndex = 6;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(52, 212);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(214, 39);
            this.insertBtn.TabIndex = 8;
            this.insertBtn.Text = "Thêm";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(52, 267);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(214, 36);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // idma
            // 
            this.idma.HeaderText = "IDMA";
            this.idma.MinimumWidth = 6;
            this.idma.Name = "idma";
            this.idma.ReadOnly = true;
            this.idma.Width = 125;
            // 
            // tenmonan
            // 
            this.tenmonan.HeaderText = "TenMonAn";
            this.tenmonan.MinimumWidth = 6;
            this.tenmonan.Name = "tenmonan";
            this.tenmonan.ReadOnly = true;
            this.tenmonan.Width = 125;
            // 
            // randBtn
            // 
            this.randBtn.Location = new System.Drawing.Point(178, 364);
            this.randBtn.Name = "randBtn";
            this.randBtn.Size = new System.Drawing.Size(122, 40);
            this.randBtn.TabIndex = 11;
            this.randBtn.Text = "Quay";
            this.randBtn.UseVisualStyleBackColor = true;
            this.randBtn.Click += new System.EventHandler(this.randBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Món ăn hôm nay là: ";
            // 
            // resTxb
            // 
            this.resTxb.Location = new System.Drawing.Point(454, 373);
            this.resTxb.Name = "resTxb";
            this.resTxb.ReadOnly = true;
            this.resTxb.Size = new System.Drawing.Size(185, 22);
            this.resTxb.TabIndex = 13;
            // 
            // Lab02_Bai06
            // 
            this.AcceptButton = this.insertBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.randBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.nameTxb);
            this.Controls.Add(this.idTxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Lab02_Bai06";
            this.Text = "Lab02_Bai06";
            this.Load += new System.EventHandler(this.Lab02_Bai06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxb;
        private System.Windows.Forms.TextBox nameTxb;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idma;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonan;
        private System.Windows.Forms.Button randBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resTxb;
    }
}