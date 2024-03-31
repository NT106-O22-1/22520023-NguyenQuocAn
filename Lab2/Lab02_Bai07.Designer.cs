namespace Lab2
{
    partial class Lab02_Bai07
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dirPathBtn = new System.Windows.Forms.Button();
            this.loadDirBtn = new System.Windows.Forms.Button();
            this.pathTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pathTxb);
            this.panel1.Controls.Add(this.loadDirBtn);
            this.panel1.Controls.Add(this.dirPathBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 450);
            this.panel1.TabIndex = 0;
            // 
            // dirPathBtn
            // 
            this.dirPathBtn.Location = new System.Drawing.Point(244, 9);
            this.dirPathBtn.Name = "dirPathBtn";
            this.dirPathBtn.Size = new System.Drawing.Size(50, 23);
            this.dirPathBtn.TabIndex = 0;
            this.dirPathBtn.Text = "...";
            this.dirPathBtn.UseVisualStyleBackColor = true;
            this.dirPathBtn.Click += new System.EventHandler(this.dirPathBtn_Click);
            // 
            // loadDirBtn
            // 
            this.loadDirBtn.Location = new System.Drawing.Point(15, 415);
            this.loadDirBtn.Name = "loadDirBtn";
            this.loadDirBtn.Size = new System.Drawing.Size(279, 23);
            this.loadDirBtn.TabIndex = 1;
            this.loadDirBtn.Text = "Load Directory";
            this.loadDirBtn.UseVisualStyleBackColor = true;
            this.loadDirBtn.Click += new System.EventHandler(this.loadDirBtn_Click);
            // 
            // pathTxb
            // 
            this.pathTxb.Location = new System.Drawing.Point(55, 9);
            this.pathTxb.Name = "pathTxb";
            this.pathTxb.Size = new System.Drawing.Size(183, 22);
            this.pathTxb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(15, 44);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(279, 365);
            this.treeView.TabIndex = 5;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseMove);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Content";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(329, 32);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(459, 406);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // Lab02_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Lab02_Bai07";
            this.Text = "Lab02_Bai07";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTxb;
        private System.Windows.Forms.Button loadDirBtn;
        private System.Windows.Forms.Button dirPathBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}