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
using System.Xml.Linq;

namespace Lab4_Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            urlTb.Text = "https://nt106.uitiot.vn/auth/token";
            getURLTb.Text = "https://nt106.uitiot.vn/api/v1/user/me";
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            var url = urlTb.Text;
            var url2 = getURLTb.Text;
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

                    var accessToken = responseObject["access_token"].ToString();

                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                    var getUserUrl = url2;
                    var getUserResponse = await client.GetAsync(getUserUrl);
                    var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                    richTextBox1.AppendText(getUserResponseString);
                }
                catch (HttpRequestException httpExp)
                {
                    richTextBox1.AppendText($"Lỗi kết nối: {httpExp.Message}\n\n");
                }
            }
        }
    }
}
