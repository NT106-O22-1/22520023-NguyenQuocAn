namespace Lab5_Bai04
{
    partial class log_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwdTb = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(123, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(129, 98);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(208, 22);
            this.usernameTb.TabIndex = 3;
            // 
            // passwdTb
            // 
            this.passwdTb.Location = new System.Drawing.Point(129, 133);
            this.passwdTb.Name = "passwdTb";
            this.passwdTb.PasswordChar = '*';
            this.passwdTb.Size = new System.Drawing.Size(208, 22);
            this.passwdTb.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(385, 98);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(118, 57);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Don\'t have an account yet?";
            // 
            // signUpLb
            // 
            this.signUpLb.AutoSize = true;
            this.signUpLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLb.ForeColor = System.Drawing.Color.SteelBlue;
            this.signUpLb.Location = new System.Drawing.Point(296, 187);
            this.signUpLb.Name = "signUpLb";
            this.signUpLb.Size = new System.Drawing.Size(52, 16);
            this.signUpLb.TabIndex = 7;
            this.signUpLb.Text = "Sign up";
            this.signUpLb.Click += new System.EventHandler(this.signUpLb_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 274);
            this.Controls.Add(this.signUpLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwdTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "log_in";
            this.Text = "Hôm nay ăn gì? Login";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwdTb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label signUpLb;
    }
}