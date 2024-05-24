namespace Lab4_Bai07
{
    partial class DishInfoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costLb = new System.Windows.Forms.Label();
            this.addressLb = new System.Windows.Forms.Label();
            this.contributeLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(125, 125);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.ForeColor = System.Drawing.Color.Tomato;
            this.nameLb.Location = new System.Drawing.Point(149, 13);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(127, 25);
            this.nameLb.TabIndex = 1;
            this.nameLb.Text = "Tên món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đóng góp:";
            // 
            // costLb
            // 
            this.costLb.AutoSize = true;
            this.costLb.Location = new System.Drawing.Point(235, 47);
            this.costLb.Name = "costLb";
            this.costLb.Size = new System.Drawing.Size(47, 16);
            this.costLb.TabIndex = 5;
            this.costLb.Text = "costLb";
            // 
            // addressLb
            // 
            this.addressLb.AutoSize = true;
            this.addressLb.Location = new System.Drawing.Point(235, 76);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(72, 16);
            this.addressLb.TabIndex = 6;
            this.addressLb.Text = "addressLb";
            // 
            // contributeLb
            // 
            this.contributeLb.AutoSize = true;
            this.contributeLb.ForeColor = System.Drawing.Color.LimeGreen;
            this.contributeLb.Location = new System.Drawing.Point(235, 102);
            this.contributeLb.Name = "contributeLb";
            this.contributeLb.Size = new System.Drawing.Size(80, 16);
            this.contributeLb.TabIndex = 7;
            this.contributeLb.Text = "contributeLb";
            // 
            // DishInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.contributeLb);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.costLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.pictureBox);
            this.Name = "DishInfoUC";
            this.Size = new System.Drawing.Size(703, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costLb;
        private System.Windows.Forms.Label addressLb;
        private System.Windows.Forms.Label contributeLb;
    }
}
