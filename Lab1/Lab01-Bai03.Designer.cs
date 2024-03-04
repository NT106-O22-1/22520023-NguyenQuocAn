namespace Lab1
{
    partial class Lab01_Bai03
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
            numLabel = new Label();
            resLabel = new Label();
            numTxt = new TextBox();
            resTxt = new TextBox();
            readBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new Point(99, 118);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(224, 20);
            numLabel.TabIndex = 0;
            numLabel.Text = "Nhập Vào Số Nguyên Từ 0 đến 9";
            // 
            // resLabel
            // 
            resLabel.AutoSize = true;
            resLabel.Location = new Point(99, 198);
            resLabel.Name = "resLabel";
            resLabel.Size = new Size(60, 20);
            resLabel.TabIndex = 1;
            resLabel.Text = "Kết quả";
            // 
            // numTxt
            // 
            numTxt.BorderStyle = BorderStyle.FixedSingle;
            numTxt.Location = new Point(357, 116);
            numTxt.Name = "numTxt";
            numTxt.Size = new Size(125, 27);
            numTxt.TabIndex = 2;
            // 
            // resTxt
            // 
            resTxt.BorderStyle = BorderStyle.FixedSingle;
            resTxt.Location = new Point(99, 236);
            resTxt.Name = "resTxt";
            resTxt.ReadOnly = true;
            resTxt.Size = new Size(383, 27);
            resTxt.TabIndex = 3;
            // 
            // readBtn
            // 
            readBtn.Location = new Point(590, 118);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(94, 29);
            readBtn.TabIndex = 4;
            readBtn.Text = "Đọc";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(590, 179);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Xoá";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(590, 236);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Lab01_Bai03
            // 
            AcceptButton = readBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(readBtn);
            Controls.Add(resTxt);
            Controls.Add(numTxt);
            Controls.Add(resLabel);
            Controls.Add(numLabel);
            Name = "Lab01_Bai03";
            Text = "Lab01_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numLabel;
        private Label resLabel;
        private TextBox numTxt;
        private TextBox resTxt;
        private Button readBtn;
        private Button clearBtn;
        private Button exitBtn;
    }
}