using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lab5_Bai04
{
    public partial class email_config : Form
    {
        public email_config()
        {
            InitializeComponent();

            imapTb.Text = "imap.gmail.com";
            imapNum.Value = 993;
            imapSslCb.Checked = true;

            smtpTb.Text = "smtp.gmail.com";
            smtpNum.Value = 465;
            smtpSslCb.Checked = true;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (smtpSslCb.Checked) b = true;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect(smtpTb.Text, (int)smtpNum.Value, b);

            try
            {
                smtpClient.Authenticate(usernameTb.Text, pwTb.Text);
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(nicknameTb.Text, usernameTb.Text));
                mimeMessage.To.Add(new MailboxAddress("", "nqan69@gmail.com"));
                mimeMessage.Body = new TextPart("plain")
                {
                    Text = "Test",
                };
                smtpClient.Send(mimeMessage);
                MessageBox.Show("Connection successful");
            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string a = "false";
            if (smtpSslCb.Checked) a = "true";

            string mailServer = smtpTb.Text;
            int port = (int)smtpNum.Value;
            string nickname = nicknameTb.Text;
            string username = usernameTb.Text;
            string password = pwTb.Text;

            // Save config to SQLite
            ConfigManager.SaveConfig(mailServer, port, username, password, a, nickname);
            MessageBox.Show("Config saved successfully!");
            this.Close();
        }
    }
}
