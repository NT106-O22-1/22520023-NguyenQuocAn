namespace Lab1
{
    partial class Lab01_Bai02
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
            num1Label = new Label();
            num2Label = new Label();
            num3Label = new Label();
            maxLabel = new Label();
            minLabel = new Label();
            num1Txt = new TextBox();
            num2Txt = new TextBox();
            num3Txt = new TextBox();
            maxTxt = new TextBox();
            minTxt = new TextBox();
            findBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // num1Label
            // 
            num1Label.AutoSize = true;
            num1Label.Location = new Point(44, 91);
            num1Label.Name = "num1Label";
            num1Label.Size = new Size(91, 20);
            num1Label.TabIndex = 0;
            num1Label.Text = "Số Thứ Nhất";
            // 
            // num2Label
            // 
            num2Label.AutoSize = true;
            num2Label.Location = new Point(305, 95);
            num2Label.Name = "num2Label";
            num2Label.Size = new Size(82, 20);
            num2Label.TabIndex = 1;
            num2Label.Text = "Số Thứ Hai";
            // 
            // num3Label
            // 
            num3Label.AutoSize = true;
            num3Label.Location = new Point(552, 95);
            num3Label.Name = "num3Label";
            num3Label.Size = new Size(76, 20);
            num3Label.TabIndex = 2;
            num3Label.Text = "Số Thứ Ba";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(141, 293);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(90, 20);
            maxLabel.TabIndex = 3;
            maxLabel.Text = "Số Lớn Nhất";
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(436, 297);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(94, 20);
            minLabel.TabIndex = 4;
            minLabel.Text = "Số Nhỏ Nhất";
            // 
            // num1Txt
            // 
            num1Txt.Location = new Point(141, 88);
            num1Txt.Name = "num1Txt";
            num1Txt.Size = new Size(125, 27);
            num1Txt.TabIndex = 5;
            // 
            // num2Txt
            // 
            num2Txt.Location = new Point(393, 91);
            num2Txt.Name = "num2Txt";
            num2Txt.Size = new Size(125, 27);
            num2Txt.TabIndex = 6;
            // 
            // num3Txt
            // 
            num3Txt.Location = new Point(634, 92);
            num3Txt.Name = "num3Txt";
            num3Txt.Size = new Size(125, 27);
            num3Txt.TabIndex = 7;
            // 
            // maxTxt
            // 
            maxTxt.Location = new Point(248, 290);
            maxTxt.Name = "maxTxt";
            maxTxt.ReadOnly = true;
            maxTxt.Size = new Size(125, 27);
            maxTxt.TabIndex = 8;
            // 
            // minTxt
            // 
            minTxt.Location = new Point(552, 290);
            minTxt.Name = "minTxt";
            minTxt.ReadOnly = true;
            minTxt.Size = new Size(125, 27);
            minTxt.TabIndex = 9;
            // 
            // findBtn
            // 
            findBtn.Location = new Point(202, 184);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(94, 29);
            findBtn.TabIndex = 10;
            findBtn.Text = "Tìm";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(351, 184);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 11;
            clearBtn.Text = "Xoá";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(508, 184);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 12;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Lab01_Bai02
            // 
            AcceptButton = findBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(findBtn);
            Controls.Add(minTxt);
            Controls.Add(maxTxt);
            Controls.Add(num3Txt);
            Controls.Add(num2Txt);
            Controls.Add(num1Txt);
            Controls.Add(minLabel);
            Controls.Add(maxLabel);
            Controls.Add(num3Label);
            Controls.Add(num2Label);
            Controls.Add(num1Label);
            Name = "Lab01_Bai02";
            Text = "Lab01_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1Label;
        private Label num2Label;
        private Label num3Label;
        private Label maxLabel;
        private Label minLabel;
        private TextBox num1Txt;
        private TextBox num2Txt;
        private TextBox num3Txt;
        private TextBox maxTxt;
        private TextBox minTxt;
        private Button findBtn;
        private Button clearBtn;
        private Button exitBtn;
    }
}