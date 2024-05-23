using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace Lab4_Bai07
{
    public partial class log_in : Form
    {
        main Main;
        public static log_in instance;
        private string tokentype;
        private string accesstoken;
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        public log_in()
        {
            InitializeComponent();
            instance = this;
        }
        private void log_in_Load(object sender, EventArgs e)
        {
            Main = new main();
            Main.Show();
            //Main.Enabled = false;
        }

        private void signUpLb_Click(object sender, EventArgs e)
        {
            sign_up sign_Up = new sign_up();
            sign_Up.ShowDialog();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwdTb.Text;

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

                    main.instance.welcomeLb.Text = $"Welcome, {username}";
                    main.instance.welcomeLb.ForeColor = Color.Green;
                    main.instance.receivedTokenType = tokentype;
                    main.instance.receivedAccessToken = accesstoken;

                    Main.Enabled = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
