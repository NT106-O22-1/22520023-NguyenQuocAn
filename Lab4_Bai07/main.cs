using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai07
{
    public partial class main : Form
    {
        public static main instance;
        public Label welcomeLb;
        public string receivedTokenType;
        public string receivedAccessToken;
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        public main()
        {
            InitializeComponent();
            instance = this;
            welcomeLb = authLb;
            pageCb.SelectedIndex = 0;
            pageSizeCb.SelectedIndex = 5;
        }

        private void AddToPanel(string monan, string gia, string diachi, string nguoidonggop, PictureBox pictureBox)
        {
            DishInfoUC dishInfoControl = new DishInfoUC();
            dishInfoControl.Settenmonan(monan);
            dishInfoControl.Setgiamonan(gia);
            dishInfoControl.Setdiachi(diachi);
            dishInfoControl.Setnguoidonggop(nguoidonggop);
            dishInfoControl.SetPictureBox(pictureBox);
            flowLayoutPanel.Controls.Add(dishInfoControl);
        }

        private async void getAllDishesBtn_Click(object sender, EventArgs e)
        {
            getAllDishesBtn.BackColor = Color.White;
            getMyDishesBtn.BackColor = Color.WhiteSmoke;

            int currentPage = pageCb.SelectedIndex + 1;
            int pageSize = pageSizeCb.SelectedIndex + 1;
            await RequestDishesList("https://nt106.uitiot.vn/api/v1/monan/all", currentPage, pageSize);
        }

        private async void getMyDishesBtn_Click(object sender, EventArgs e)
        {
            getAllDishesBtn.BackColor = Color.WhiteSmoke;
            getMyDishesBtn.BackColor = Color.White;

            int currentPage = pageCb.SelectedIndex + 1;
            int pageSize = pageSizeCb.SelectedIndex + 1;
            await RequestDishesList("https://nt106.uitiot.vn/api/v1/monan/my-dishes", currentPage, pageSize);
        }

        private async Task RequestDishesList(string url, int currentPage, int pageSize)
        {
            string apiUrl = url;
            var requestData = new
            {
                current = currentPage,
                pageSize = pageSize,
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                ResponseDishes responseObject = JsonConvert.DeserializeObject<ResponseDishes>(responseContent);

                flowLayoutPanel.Controls.Clear();

                int fetchedDishes = 0;
                int totalDishesReceived = responseObject.Data.Count;
                foreach (var monAn in responseObject.Data)
                {
                    string monan = monAn.TenMonAn;
                    string gia = monAn.Gia.ToString();
                    string diachi = monAn.DiaChi;
                    string nguoidonggop = monAn.NguoiDongGop;
                    string imgurl = monAn.HinhAnh;
                    PictureBox pictureBox = new PictureBox();
                    try { pictureBox.Load(imgurl); }
                    catch { }
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    fetchedDishes++;
                    AddToPanel(monan, gia, diachi, nguoidonggop, pictureBox);
                    UpdateProgressBar(fetchedDishes, totalDishesReceived);
                }
            }
        }

        private void UpdateProgressBar(int fetchedDishes, int total)
        {
            int progressPercentage = (int)((double)fetchedDishes / total * 100);

            if (progressPercentage > progressBar.Maximum)
            {
                progressPercentage = progressBar.Maximum;
            }
            progressBar.Value = progressPercentage;
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            Control control = null;
            List<Control> list = flowLayoutPanel.Controls.Cast<Control>().ToList();

            if (list.Count > 0)
            {
                Random random = new Random();
                int idx = random.Next(0, list.Count);
                control = list[idx];
            }

            if (control != null)
            {
                show_random_dish form = new show_random_dish(control);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có món ăn nào để hiển thị.");
            }
        }

        private void addDishBtn_Click(object sender, EventArgs e)
        {
            add_dish add_Dish = new add_dish(receivedTokenType, receivedAccessToken);
            add_Dish.ShowDialog();
        }

        private void main_Click(object sender, EventArgs e)
        {
            if (authLb.Text == "Unauthenticated")
            {
                MessageBox.Show("Vui lòng đăng nhập!");
            }
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["log_in"].Close();
        }
    }
}
