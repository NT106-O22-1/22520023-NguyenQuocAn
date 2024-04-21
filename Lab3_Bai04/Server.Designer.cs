namespace Lab3_Bai04
{
    partial class Server
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
            this.listView_Message = new System.Windows.Forms.ListView();
            this.button_Listen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_DocFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_Message
            // 
            this.listView_Message.HideSelection = false;
            this.listView_Message.Location = new System.Drawing.Point(215, 199);
            this.listView_Message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Message.Name = "listView_Message";
            this.listView_Message.Size = new System.Drawing.Size(371, 202);
            this.listView_Message.TabIndex = 0;
            this.listView_Message.UseCompatibleStateImageBehavior = false;
            this.listView_Message.View = System.Windows.Forms.View.List;
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(493, 61);
            this.button_Listen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(93, 38);
            this.button_Listen.TabIndex = 1;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(295, 131);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // button_DocFile
            // 
            this.button_DocFile.Location = new System.Drawing.Point(493, 123);
            this.button_DocFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DocFile.Name = "button_DocFile";
            this.button_DocFile.Size = new System.Drawing.Size(93, 36);
            this.button_DocFile.TabIndex = 4;
            this.button_DocFile.Text = "Đọc file";
            this.button_DocFile.UseVisualStyleBackColor = true;
            this.button_DocFile.Click += new System.EventHandler(this.button_DocFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phim";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_DocFile);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.listView_Message);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Message;
        private System.Windows.Forms.Button button_Listen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button_DocFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}