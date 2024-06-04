namespace Lab6_Contest
{
    partial class Form_Admin
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
            this.button_Closed = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.nameClientTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Closed
            // 
            this.button_Closed.Location = new System.Drawing.Point(323, 218);
            this.button_Closed.Name = "button_Closed";
            this.button_Closed.Size = new System.Drawing.Size(108, 38);
            this.button_Closed.TabIndex = 1;
            this.button_Closed.Text = "Đóng quầy";
            this.button_Closed.UseVisualStyleBackColor = true;
            this.button_Closed.Click += new System.EventHandler(this.button_Closed_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(458, 218);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(108, 38);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "Mở quầy";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(84, 159);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(171, 97);
            this.button_Connect.TabIndex = 4;
            this.button_Connect.Text = "Connect to server";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // nameClientTb
            // 
            this.nameClientTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameClientTb.Location = new System.Drawing.Point(323, 159);
            this.nameClientTb.Name = "nameClientTb";
            this.nameClientTb.Size = new System.Drawing.Size(243, 30);
            this.nameClientTb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập tên quầy muốn thao tác:";
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameClientTb);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Closed);
            this.Name = "Form_Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Closed;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox nameClientTb;
        private System.Windows.Forms.Label label1;
    }
}