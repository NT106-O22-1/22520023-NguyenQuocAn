using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5_Bai04
{
    public partial class add_dish : Form
    {
        private string receivedTokenType;
        private string receivedAccessToken;
        public add_dish(string TokenType, string AccessToken)
        {
            InitializeComponent();
            receivedTokenType = TokenType;
            receivedAccessToken = AccessToken;

        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        private async void addBtn_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/add";
            var requestData = new
            {
                ten_mon_an = nameTb.Text,
                gia = costTb.Text,
                mo_ta = desRTb.Text,
                hinh_anh = imgTb.Text,
                dia_chi = addressTb.Text
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                MessageBox.Show("Bạn đã thêm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
            costTb.Clear();
            desRTb.Clear();
            imgTb.Clear();
            addressTb.Clear();
        }
    }
}
