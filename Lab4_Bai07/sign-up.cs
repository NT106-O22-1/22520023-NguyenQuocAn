using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Net.Http;

namespace Lab4_Bai07
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
            maleRadio.Checked = true;
            languageCb.SelectedIndex = 0;
        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text == "" || passwdTb.Text == "" || emailTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các trường: username, password, email");
                return;
            }
            string s = "";
            if (maleRadio.Checked) s = "1";
            if (femaleRadio.Checked) s = "0";
            var userData = new
            {
                username = usernameTb.Text,
                email = emailTb.Text,
                password = passwdTb.Text,
                first_name = firstnameTb.Text,
                last_name = lastnameTb.Text,
                sex = s,
                birthday = dateTimePicker.Text,
                language = languageCb.SelectedItem.ToString(),
                phone = phoneTb.Text
            };

            string jsonData = JsonConvert.SerializeObject(userData);

            string apiUrl = "https://nt106.uitiot.vn/api/v1/user/signup";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(apiUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();
                    
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Tạo tài khoản thành công!" + response.StatusCode);
                    }
                    else
                    {
                        MessageBox.Show($"Status code: {response.StatusCode}\nLỗi xác thực");
                    }
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTb.Clear();
            passwdTb.Clear();
            emailTb.Clear();
            firstnameTb.Clear(); 
            lastnameTb.Clear();
            phoneTb.Clear();
        }
    }
}
