using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Lab4_Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            urlTb.Text = "https://nt106.uitiot.vn/auth/token";
        }
        private async void loginBtn_Click(object sender, EventArgs e)
        {
            var url = urlTb.Text;
            var username = usernameTb.Text;
            var password = passTb.Text;

            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };

                try
                {
                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JObject.Parse(responseString);

                    var tokenType = responseObject["token_type"].ToString();
                    var accessToken = responseObject["access_token"].ToString();
                    richTextBox1.AppendText(tokenType + '\n');
                    richTextBox1.AppendText(accessToken + '\n');
                    richTextBox1.AppendText("\nĐăng nhập thành công");
                    
                }
                catch (HttpRequestException httpExp)
                {
                    richTextBox1.AppendText($"Lỗi kết nối: {httpExp.Message}\n\n");
                }
            }
        }
    }
}

