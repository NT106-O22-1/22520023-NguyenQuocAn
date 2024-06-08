using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Linq;

namespace Lab5_Bai05
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            imapTb.Text = "imap.gmail.com";
            imapNum.Value = 993;

            smtpTb.Text = "smtp.gmail.com";
            smtpNum.Value = 465;
        }

        private async void testBtn_Click(object sender, EventArgs e)
        {
            string email = usernameTb.Text;
            string password = pwTb.Text;

            using (var client = new ImapClient())
            {
                try
                {
                    await client.ConnectAsync(imapTb.Text, (int)imapNum.Value, true);
                    await client.AuthenticateAsync(email, password);

                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    listView.Items.Clear();

                    var summaries = inbox.Fetch(0, -1, MessageSummaryItems.Full | MessageSummaryItems.UniqueId);

                    var sortedSummaries = summaries.OrderByDescending(s => s.Envelope.Date).ToList();

                    foreach (var summary in sortedSummaries)
                    {
                        var date = summary.Envelope.Date?.ToString("dd/MM/yyyy HH:mm:ss") ?? "No Date";
                        var from = summary.Envelope.From.ToString();
                        var subject = summary.Envelope.Subject ?? "No Subject";

                        var item = new ListViewItem(date);
                        item.SubItems.Add(from);
                        item.SubItems.Add(subject);
                        listView.Items.Add(item);
                    }

                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }

        private void UI_Handler()
        {
            usernameTb.Enabled = false;
            pwTb.Enabled = false;
            testBtn.Enabled = false;
            testBtn.Visible = false;
            sendEmailBtn.Visible = true;
            refreshBtn.Visible = true;
            logoutBtn.Visible = true;

            groupBox1.Enabled = false;
        }
    }
}
