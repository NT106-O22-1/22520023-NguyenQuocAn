namespace Lab1
{
    partial class Screen3
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
            label2 = new Label();
            label1 = new Label();
            checkedListBox = new CheckedListBox();
            okBtn = new Button();
            moviePickerCb = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 127);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 10;
            label2.Text = "Chọn chỗ ngồi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 9;
            label1.Text = "Chọn phim:";
            // 
            // checkedListBox
            // 
            checkedListBox.ColumnWidth = 60;
            checkedListBox.Font = new Font("Segoe UI", 10F);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Items.AddRange(new object[] { "A1", "B1", "C1", "A2", "B2", "C2", "A3", "B3", "C3", "A4", "B4", "C4", "A5", "B5", "C5" });
            checkedListBox.Location = new Point(128, 173);
            checkedListBox.MultiColumn = true;
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(327, 79);
            checkedListBox.TabIndex = 8;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(219, 301);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(147, 38);
            okBtn.TabIndex = 7;
            okBtn.Text = "Mua vé";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // moviePickerCb
            // 
            moviePickerCb.FormattingEnabled = true;
            moviePickerCb.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Tarot" });
            moviePickerCb.Location = new Point(128, 41);
            moviePickerCb.Name = "moviePickerCb";
            moviePickerCb.Size = new Size(151, 28);
            moviePickerCb.TabIndex = 6;
            // 
            // Screen3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkedListBox);
            Controls.Add(okBtn);
            Controls.Add(moviePickerCb);
            Name = "Screen3";
            Size = new Size(573, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private CheckedListBox checkedListBox;
        private Button okBtn;
        private ComboBox moviePickerCb;
    }
}
