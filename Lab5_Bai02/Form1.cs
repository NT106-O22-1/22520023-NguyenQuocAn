using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab5_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }
        private void InitializeListView()
        {
            listView_Message.View = View.Details;

            listView_Message.FullRowSelect = true;

            listView_Message.Columns.Clear();

            listView_Message.Columns.Add("Subject", 200);
            listView_Message.Columns.Add("From", 200);
            listView_Message.Columns.Add("Date", 150);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                try
                {
                    using (var imapClient = new ImapClient())
                    {
                        imapClient.Connect("imap.gmail.com", 993, true);
                        imapClient.Authenticate(textBox_Email.Text, textBox_Password.Text);

                        var inbox = imapClient.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);

                        Invoke(new Action(() => listView_Message.Items.Clear()));

                        for (int i = inbox.Count - 1; i >= 0; i--)
                        {
                            var message = inbox.GetMessage(i);
                            var item = new ListViewItem(new[]
                            {
                        message.Subject,
                        message.From.ToString(),
                        message.Date.DateTime.ToString()
                    });

                            Invoke(new Action(() => listView_Message.Items.Add(item)));
                        }

                        imapClient.Disconnect(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không đăng nhập thành công: " + ex.Message);
                }
            });
        }
    }
}
