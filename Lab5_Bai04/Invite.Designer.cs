namespace Lab5_Bai04
{
    partial class Invite
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(611, 132);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(15, 188);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(339, 22);
            this.emailTb.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(360, 187);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 216);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(444, 191);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(462, 286);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(161, 53);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // Invite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 419);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "Invite";
            this.Text = "Invite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button sendBtn;
    }
}