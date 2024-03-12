namespace Lab1
{
    partial class Lab01_Bai05
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
            inputALabel = new Label();
            inputBLabel = new Label();
            inputATxt = new TextBox();
            inputBTxt = new TextBox();
            comboBox = new ComboBox();
            enterBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // inputALabel
            // 
            inputALabel.AutoSize = true;
            inputALabel.Location = new Point(56, 42);
            inputALabel.Name = "inputALabel";
            inputALabel.Size = new Size(59, 20);
            inputALabel.TabIndex = 0;
            inputALabel.Text = "Nhập A";
            // 
            // inputBLabel
            // 
            inputBLabel.AutoSize = true;
            inputBLabel.Location = new Point(57, 93);
            inputBLabel.Name = "inputBLabel";
            inputBLabel.Size = new Size(58, 20);
            inputBLabel.TabIndex = 1;
            inputBLabel.Text = "Nhập B";
            // 
            // inputATxt
            // 
            inputATxt.Location = new Point(133, 39);
            inputATxt.Name = "inputATxt";
            inputATxt.Size = new Size(125, 27);
            inputATxt.TabIndex = 2;
            // 
            // inputBTxt
            // 
            inputBTxt.Location = new Point(133, 90);
            inputBTxt.Name = "inputBTxt";
            inputBTxt.Size = new Size(125, 27);
            inputBTxt.TabIndex = 3;
            // 
            // comboBox
            // 
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            comboBox.Location = new Point(57, 150);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(201, 28);
            comboBox.TabIndex = 4;
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(57, 319);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(201, 29);
            enterBtn.TabIndex = 5;
            enterBtn.Text = "Tính các giá trị";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(56, 368);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Xoá";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(164, 368);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(322, 40);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(409, 355);
            richTextBox.TabIndex = 8;
            richTextBox.Text = "";
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(enterBtn);
            Controls.Add(comboBox);
            Controls.Add(inputBTxt);
            Controls.Add(inputATxt);
            Controls.Add(inputBLabel);
            Controls.Add(inputALabel);
            Name = "Lab01_Bai05";
            Text = "Lab01_Bai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inputALabel;
        private Label inputBLabel;
        private TextBox inputATxt;
        private TextBox inputBTxt;
        private ComboBox comboBox;
        private Button enterBtn;
        private Button clearBtn;
        private Button exitBtn;
        private RichTextBox richTextBox;
    }
}