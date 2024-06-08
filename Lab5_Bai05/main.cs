using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Linq;
using System.Threading.Tasks;

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
            loadingLb.Visible = true;

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
                        item.Tag = summary.UniqueId;

                        listView.Items.Add(item);
                    }

                    UI_Handler();
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
                finally
                {
                    loadingLb.Visible = false;
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
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            imapTb.Enabled = false;
            smtpTb.Enabled = false;
            imapNum.Enabled = false;
            smtpNum.Enabled = false;
        }

        private async void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;

            var selectedItem = listView.SelectedItems[0];
            var emailIndex = selectedItem.Tag as UniqueId?;

            if (emailIndex.HasValue)
            {
                await DisplayEmailContent(emailIndex.Value);
            }
        }

        private async Task DisplayEmailContent(UniqueId emailId)
        {
            var email = await FetchEmailById(emailId);
            if (email != null)
            {
                var subject = email.Subject;
                var from = string.Join(", ", email.From);
                var date = email.Date.ToString("dd/MM/yyyy HH:mm:ss");
                var body = email.HtmlBody ?? email.TextBody;

                var emailContentForm = new EmailContentForm(subject, from, date, body);
                emailContentForm.Show();
            }
        }

        private async Task<MimeMessage> FetchEmailById(UniqueId emailId)
        {
            using (var client = new ImapClient())
            {
                try
                {
                    string email = usernameTb.Text;
                    string password = pwTb.Text;

                    await client.ConnectAsync(imapTb.Text, (int)imapNum.Value, true);
                    await client.AuthenticateAsync(email, password);

                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);
                    var message = await inbox.GetMessageAsync(emailId);
                    await client.DisconnectAsync(true);

                    return message;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            SendEmail sendEmail = new SendEmail(usernameTb.Text, pwTb.Text, smtpTb.Text, (int)smtpNum.Value);
            sendEmail.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            main main_form = new main();
            main_form.Show();
            this.Hide();
        }
    }
}
