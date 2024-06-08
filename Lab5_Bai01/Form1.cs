using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("duckhang281004@gmail.com", "kfqz heuo auub xdjn");
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Khang", "duckhang281004@gmail.com"));
                message.To.Add(new MailboxAddress("", textBox1.Text));
                message.Subject = textBox_Subject.Text;
                message.Body = new TextPart("html")
                {
                    Text = richTextBox_Body.Text
                };
                smtpClient.Send(message);
                MessageBox.Show("Da gui mail thanh cong");
            }
            catch
            {
                MessageBox.Show("Gui khong thanh cong");
            }
        }
    }
}
