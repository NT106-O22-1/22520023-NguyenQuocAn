namespace Lab1
{
    partial class Lab01_Bai04
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
            panel1 = new Panel();
            changeBtn = new Button();
            label1 = new Label();
            screen3Btn = new Button();
            screen2Btn = new Button();
            screen1Btn = new Button();
            screen1Uc = new Screen1();
            screen2Uc = new Screen2();
            screen3Uc = new Screen3();
            blankScr = new Screen();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(changeBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(screen3Btn);
            panel1.Controls.Add(screen2Btn);
            panel1.Controls.Add(screen1Btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 450);
            panel1.TabIndex = 0;
            // 
            // changeBtn
            // 
            changeBtn.Enabled = false;
            changeBtn.Location = new Point(37, 321);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(144, 29);
            changeBtn.TabIndex = 4;
            changeBtn.Text = "Đổi phòng chiếu";
            changeBtn.UseVisualStyleBackColor = true;
            changeBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 110);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Chọn phòng chiếu:";
            // 
            // screen3Btn
            // 
            screen3Btn.Location = new Point(47, 254);
            screen3Btn.Name = "screen3Btn";
            screen3Btn.Size = new Size(122, 29);
            screen3Btn.TabIndex = 2;
            screen3Btn.Text = "Phòng chiếu 3";
            screen3Btn.UseVisualStyleBackColor = true;
            screen3Btn.Click += screen3Btn_Click;
            // 
            // screen2Btn
            // 
            screen2Btn.Location = new Point(47, 200);
            screen2Btn.Name = "screen2Btn";
            screen2Btn.Size = new Size(122, 29);
            screen2Btn.TabIndex = 1;
            screen2Btn.Text = "Phòng chiếu 2";
            screen2Btn.UseVisualStyleBackColor = true;
            screen2Btn.Click += screen2Btn_Click;
            // 
            // screen1Btn
            // 
            screen1Btn.Location = new Point(47, 150);
            screen1Btn.Name = "screen1Btn";
            screen1Btn.Size = new Size(122, 29);
            screen1Btn.TabIndex = 0;
            screen1Btn.Text = "Phòng chiếu 1";
            screen1Btn.UseVisualStyleBackColor = true;
            screen1Btn.Click += screen1Btn_Click;
            // 
            // screen1Uc
            // 
            screen1Uc.Location = new Point(215, 12);
            screen1Uc.Name = "screen1Uc";
            screen1Uc.Size = new Size(573, 426);
            screen1Uc.TabIndex = 1;
            // 
            // screen2Uc
            // 
            screen2Uc.Location = new Point(215, 12);
            screen2Uc.Name = "screen2Uc";
            screen2Uc.Size = new Size(573, 426);
            screen2Uc.TabIndex = 2;
            // 
            // screen3Uc
            // 
            screen3Uc.Location = new Point(215, 12);
            screen3Uc.Name = "screen3Uc";
            screen3Uc.Size = new Size(573, 426);
            screen3Uc.TabIndex = 3;
            // 
            // blankScr
            // 
            blankScr.Location = new Point(215, 12);
            blankScr.Name = "blankScr";
            blankScr.Size = new Size(573, 426);
            blankScr.TabIndex = 4;
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blankScr);
            Controls.Add(screen3Uc);
            Controls.Add(screen2Uc);
            Controls.Add(screen1Uc);
            Controls.Add(panel1);
            Name = "Lab01_Bai04";
            Text = "Lab01_Bai04";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button screen3Btn;
        private Button screen2Btn;
        private Button screen1Btn;
        private Screen1 screen1Uc;
        private Screen2 screen2Uc;
        private Screen3 screen3Uc;
        private Button changeBtn;
        private Label label1;
        private Screen blankScr;
    }
}