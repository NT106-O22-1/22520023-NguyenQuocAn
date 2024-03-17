namespace Lab1
{
    partial class Lab01_Bai08
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
            addBtn = new Button();
            inputTb = new TextBox();
            listView = new ListView();
            label1 = new Label();
            label2 = new Label();
            findBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            outputTb = new TextBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(305, 114);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 0;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // inputTb
            // 
            inputTb.Location = new Point(238, 68);
            inputTb.Name = "inputTb";
            inputTb.Size = new Size(161, 27);
            inputTb.TabIndex = 1;
            // 
            // listView
            // 
            listView.Location = new Point(420, 68);
            listView.Name = "listView";
            listView.Size = new Size(269, 151);
            listView.TabIndex = 2;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 71);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "Nhập món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 321);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 4;
            label2.Text = "Món ăn hôm nay là";
            // 
            // findBtn
            // 
            findBtn.Location = new Point(159, 251);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(154, 29);
            findBtn.TabIndex = 5;
            findBtn.Text = "Tìm món ăn";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(379, 251);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Xoá";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(546, 251);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // outputTb
            // 
            outputTb.Location = new Point(223, 353);
            outputTb.Name = "outputTb";
            outputTb.Size = new Size(285, 27);
            outputTb.TabIndex = 8;
            // 
            // Lab01_Bai08
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputTb);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(findBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView);
            Controls.Add(inputTb);
            Controls.Add(addBtn);
            Name = "Lab01_Bai08";
            Text = "Lab01_Bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox inputTb;
        private ListView listView;
        private Label label1;
        private Label label2;
        private Button findBtn;
        private Button clearBtn;
        private Button exitBtn;
        private TextBox outputTb;
    }
}