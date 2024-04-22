namespace Lab3_Bai03
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
            this.SuspendLayout();
            // 
            // listView_Message
            // 
            this.listView_Message.HideSelection = false;
            this.listView_Message.Location = new System.Drawing.Point(47, 55);
            this.listView_Message.Name = "listView_Message";
            this.listView_Message.Size = new System.Drawing.Size(698, 383);
            this.listView_Message.TabIndex = 0;
            this.listView_Message.UseCompatibleStateImageBehavior = false;
            this.listView_Message.View = System.Windows.Forms.View.List;
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(626, 13);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(119, 36);
            this.button_Listen.TabIndex = 1;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.listView_Message);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Message;
        private System.Windows.Forms.Button button_Listen;
    }
}