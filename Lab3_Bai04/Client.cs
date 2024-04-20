using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Newtonsoft.Json;

namespace Lab3_Bai04
{
    public partial class Client : Form
    {
        private Socket clientSocket;

        List<Phim> DanhSachPhim = new List<Phim>();

        class Phim
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public int[] PhongChieu { get; set; }
        }
        public Client()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "TenPhim";
            comboBox2.DisplayMember = "ToString";
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);


                Invoke(new Action(() => MessageBox.Show("Đã kết nối đến server")));
                byte[] buffer = new byte[1024];
                int bytesReceived = clientSocket.Receive(buffer);
                string jsonData = Encoding.UTF8.GetString(buffer, 0, bytesReceived);

                // Chuyển dữ liệu JSON sang danh sách phim
                List<Phim> danhSachPhim = JsonConvert.DeserializeObject<List<Phim>>(jsonData);

                // Hiển thị danh sách phim trong comboBox
                comboBox1.Invoke(new Action(() =>
                {
                    comboBox1.DataSource = danhSachPhim;
                    comboBox1.DisplayMember = "TenPhim";
                }));

                clientSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phim selectedPhim = (Phim)comboBox1.SelectedItem;
            comboBox2.DataSource = selectedPhim.PhongChieu;
        }

        private void button_DatVe_Click(object sender, EventArgs e)
        {
            richTextBox_Ve.Visible = true;
            richTextBox_Ve.Text = string.Empty;
            Phim selectedPhim = (Phim)comboBox1.SelectedItem;
            List<string> listcb = new List<string>();
            int vevip = 0;
            int vethuong = 0;
            int vevot = 0;
            long giave = 0;
            //tạo danh sách chỗ ngồi cho từng loại vé
            string[] VeVip = { "GheB2", "GheB3", "GheB4" };
            string[] VeVot = { "GheA1", "GheA5", "GheB1", "GheB5", "GheC1", "GheC5" };
            string[] VeThuong = { "GheA2", "GheA3", "GheA4", "GheC2", "GheC3", "GheC4" };

            int giavechuan = selectedPhim.GiaVeChuan;
            long giavevip = giavechuan * 2;
            long giavevot = giavechuan / 4;
            long giavethuong = giavechuan;
            //Hiển thị tên, tên phim, phòng chiếu
            richTextBox_Ve.AppendText($"Họ và tên: {textBox_HoVaTen.Text}\n");
            richTextBox_Ve.AppendText($"Phim: {comboBox1.Text}\n");
            richTextBox_Ve.AppendText($"Phòng chiếu: {comboBox2.Text}\n");
            //hiển thị chỗ ngồi đã đặt
            richTextBox_Ve.AppendText("Chỗ ngồi: \n");

            foreach (System.Windows.Forms.CheckBox checkbox in groupBox.Controls)
            {
                if (checkbox.Checked)
                {

                    listcb.Add(checkbox.Text);
                    if (VeVip.Contains(checkbox.Name))
                    {
                        vevip += 1;
                        richTextBox_Ve.AppendText(checkbox.Name.Substring(checkbox.Name.Length - 2) + "\n");
                    }

                    if (VeVot.Contains(checkbox.Name))
                    {
                        vevot += 1;
                        richTextBox_Ve.AppendText(checkbox.Name.Substring(checkbox.Name.Length - 2) + "\n");
                    }

                    if (VeThuong.Contains(checkbox.Name))
                    {
                        vethuong += 1;
                        richTextBox_Ve.AppendText(checkbox.Name.Substring(checkbox.Name.Length - 2) + "\n");
                    }
                }
            }
            //tính tiền
            giave = (vevip * giavevip) + (vethuong * giavethuong) + (vevot * giavevot);
            richTextBox_Ve.AppendText($"Tổng tiền: {giave} đồng");
        }
    }
}
