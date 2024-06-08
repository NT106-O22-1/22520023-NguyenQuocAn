using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MailKit.Net.Smtp;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using System.IO;

namespace Lab5_Bai05
{
    public partial class SendEmail : Form
    {
        private string Username;
        private string Password;
        private string MailServer;
        private int Port;

        public SendEmail(string userEmail, string userPassword, string mailServer, int port)
        {
            InitializeComponent();
            
            Username = userEmail;
            Password = userPassword;
            MailServer = mailServer;
            Port = port;

            fromTb.Text = userEmail;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toTb.Text))
            {
                MessageBox.Show("Vui lòng nhập email người nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect(MailServer, Port, true);

            try
            {
                smtpClient.Authenticate(Username, Password);
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(nameTb.Text, Username));
                mimeMessage.To.Add(new MailboxAddress("", toTb.Text));
                mimeMessage.Subject = subjectTb.Text;

                Multipart multipart = new Multipart("mixed");

                BodyBuilder bodyBuilder = new BodyBuilder();
                if (htmlCb.Checked)
                {
                    bodyBuilder.HtmlBody = richTextBox.Text;
                }
                else
                {
                    bodyBuilder.TextBody = richTextBox.Text;
                }
                multipart.Add(bodyBuilder.ToMessageBody());

                if (!string.IsNullOrEmpty(pathTb.Text))
                {
                    MimePart attachment = new MimePart()
                    {
                        Content = new MimeContent(File.OpenRead(pathTb.Text), ContentEncoding.Default),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(pathTb.Text)
                    };

                    multipart.Add(attachment);
                }

                mimeMessage.Body = multipart;

                smtpClient.Send(mimeMessage);
                MessageBox.Show($"Đã gửi thư thành công cho {toTb.Text}");
            }
            catch
            {
                MessageBox.Show($"Không thể gửi thư cho {toTb.Text}");
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTb.Text = openFileDialog.FileName;
            }
        }
    }
}
