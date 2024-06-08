using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Bai05
{
    public partial class EmailContentForm : Form
    {
        private string html;
        public EmailContentForm(string subject, string from, string date, string body)
        {
            InitializeComponent();

            fromLb.Text = from;
            dateLb.Text = date;
            subjectLb.Text = subject;
            html = body;
            this.Text = subject;
        }
        private async void EmailContentForm_Load(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async();
            webView.NavigateToString(html);
        }
    }
}
