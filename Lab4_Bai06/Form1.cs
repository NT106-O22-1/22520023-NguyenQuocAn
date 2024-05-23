using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Lab4_Bai06
{
    public partial class Form1 : Form
    {
        private string tokentype;
        private string accesstoken;
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        public Form1()
        {
            InitializeComponent();
            urlTb.Text = "https://nt106.uitiot.vn/auth/token";
            getURLTb.Text = "https://nt106.uitiot.vn/api/v1/user/me";
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passTb.Text;

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            HttpResponseMessage response = await httpClient.PostAsync("auth/token", formData);
            using (response)
            {
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    JObject jsonResponse = JObject.Parse(res);
                    if (jsonResponse["access_token"] != null)
                    {
                        tokentype = jsonResponse["token_type"].ToString();
                        accesstoken = jsonResponse["access_token"].ToString();
                    }

                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accesstoken);
                    var getUserUrl = getURLTb.Text;
                    var getUserResponse = await httpClient.GetAsync(getUserUrl);
                    var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                    richTextBox1.Clear();
                    richTextBox1.AppendText(getUserResponseString);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
