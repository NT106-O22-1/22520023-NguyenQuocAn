namespace Lab1
{
    partial class Lab01_Bai07
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
            label1 = new Label();
            inputTb = new TextBox();
            label2 = new Label();
            showBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            nameTb = new TextBox();
            avgTb = new TextBox();
            maxTb = new TextBox();
            minTb = new TextBox();
            passTb = new TextBox();
            failTb = new TextBox();
            typeTb = new TextBox();
            scoreListTb = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(309, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ tên và danh sách điểm của sinh viên:";
            // 
            // inputTb
            // 
            inputTb.Location = new Point(334, 19);
            inputTb.Name = "inputTb";
            inputTb.Size = new Size(449, 27);
            inputTb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 58);
            label2.Name = "label2";
            label2.Size = new Size(308, 20);
            label2.TabIndex = 2;
            label2.Text = "(VD: Nguyễn Thị A, 10, 7.5, 8, 9, 10, 5, 6, 7, 3.5)";
            // 
            // showBtn
            // 
            showBtn.Location = new Point(441, 58);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(186, 29);
            showBtn.TabIndex = 3;
            showBtn.Text = "Hiển thị thông tin";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 273);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 109);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 5;
            label4.Text = "Danh sách điểm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 318);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 6;
            label5.Text = "Điểm trung bình";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 358);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 7;
            label6.Text = "Điểm cao nhất";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 398);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 8;
            label7.Text = "Điểm thấp nhất";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(467, 270);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 9;
            label8.Text = "Số môn đậu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(426, 322);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 10;
            label9.Text = "Số môn không đậu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(477, 379);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 11;
            label10.Text = "Xếp loại:";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(118, 269);
            nameTb.Name = "nameTb";
            nameTb.ReadOnly = true;
            nameTb.Size = new Size(179, 27);
            nameTb.TabIndex = 12;
            // 
            // avgTb
            // 
            avgTb.Location = new Point(162, 315);
            avgTb.Name = "avgTb";
            avgTb.ReadOnly = true;
            avgTb.Size = new Size(125, 27);
            avgTb.TabIndex = 14;
            // 
            // maxTb
            // 
            maxTb.Location = new Point(162, 358);
            maxTb.Name = "maxTb";
            maxTb.ReadOnly = true;
            maxTb.Size = new Size(125, 27);
            maxTb.TabIndex = 15;
            // 
            // minTb
            // 
            minTb.Location = new Point(172, 398);
            minTb.Name = "minTb";
            minTb.ReadOnly = true;
            minTb.Size = new Size(125, 27);
            minTb.TabIndex = 16;
            // 
            // passTb
            // 
            passTb.Location = new Point(568, 270);
            passTb.Name = "passTb";
            passTb.ReadOnly = true;
            passTb.Size = new Size(125, 27);
            passTb.TabIndex = 17;
            // 
            // failTb
            // 
            failTb.Location = new Point(566, 315);
            failTb.Name = "failTb";
            failTb.ReadOnly = true;
            failTb.Size = new Size(125, 27);
            failTb.TabIndex = 18;
            // 
            // typeTb
            // 
            typeTb.Location = new Point(565, 379);
            typeTb.Name = "typeTb";
            typeTb.ReadOnly = true;
            typeTb.Size = new Size(125, 27);
            typeTb.TabIndex = 19;
            // 
            // scoreListTb
            // 
            scoreListTb.Location = new Point(19, 144);
            scoreListTb.Name = "scoreListTb";
            scoreListTb.ReadOnly = true;
            scoreListTb.Size = new Size(764, 93);
            scoreListTb.TabIndex = 20;
            scoreListTb.Text = "";
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreListTb);
            Controls.Add(typeTb);
            Controls.Add(failTb);
            Controls.Add(passTb);
            Controls.Add(minTb);
            Controls.Add(maxTb);
            Controls.Add(avgTb);
            Controls.Add(nameTb);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(showBtn);
            Controls.Add(label2);
            Controls.Add(inputTb);
            Controls.Add(label1);
            Name = "Lab01_Bai07";
            Text = "Lab01_Bai07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTb;
        private Label label2;
        private Button showBtn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox nameTb;
        private TextBox avgTb;
        private TextBox maxTb;
        private TextBox minTb;
        private TextBox passTb;
        private TextBox failTb;
        private TextBox typeTb;
        private RichTextBox scoreListTb;
    }
}