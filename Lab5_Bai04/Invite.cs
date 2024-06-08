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
using MailKit.Net.Smtp;

namespace Lab5_Bai04
{
    public partial class Invite : Form
    {
        private string dishInfo;

        public Invite(Control invitingDishes, string inf)
        {
            InitializeComponent();
            flowLayoutPanel.Controls.Add(invitingDishes);
            dishInfo = inf;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string content = emailTb.Text;
            if (!string.IsNullOrEmpty(content))
            {
                ListViewItem item = new ListViewItem(content);
                listView.Items.Add(item);
                emailTb.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập email của người bạn muốn mời.");
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            bool requireSSL = false;
            Config config = ConfigManager.GetConfig();
            if (config.SSL == "true")
            {
                requireSSL = true;
            }
            string mailServer = config.MailServer;
            int port = config.Port;

            string[] str = dishInfo.Split(',');
            string monan = str[0];
            string gia = str[1];
            string diachi = str[2];
            string imgurl = str[4];

            for (int i = 0; i < listView.Items.Count; i++)
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Connect(mailServer, port, requireSSL);

                try
                {
                    smtpClient.Authenticate(config.Username, config.Password);
                    MimeMessage mimeMessage = new MimeMessage();
                    mimeMessage.From.Add(new MailboxAddress("", config.Username));
                    mimeMessage.To.Add(new MailboxAddress("", listView.Items[i].Text));
                    mimeMessage.Subject = "Bạn có một lời mời đi ăn";
                    mimeMessage.Body = new TextPart("html")
                    {
                        Text = $@"<body>
                                    <img src=""{imgurl}"" alt=""embedded img"">
                                    <h1>{monan}</h1>
                                    <p>{gia}</p>
                                    <p>{diachi}</p>
                                </body>"
                    };
                    smtpClient.Send(mimeMessage);
                    MessageBox.Show($"Đã gửi thư cho thành công cho {listView.Items[i].Text}");
                }
                catch
                {
                    MessageBox.Show($"Không thể gửi thư cho {listView.Items[i].Text}");
                }
            }
        }
    }
}
