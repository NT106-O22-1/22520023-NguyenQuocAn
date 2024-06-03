using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace Lab3_Bai04
{
    public partial class Client : Form
    {
        private Socket client;

        List<Phim> DanhSachPhim = new List<Phim>();

        class Phim
        {
            public string ten { get; set; }
            public int giavechuan { get; set; }
            public int[] phongchieu { get; set; }
        }
        public Client()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "ten";
            comboBox2.DisplayMember = "ToString";
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (clientNameTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên của quầy");
                return;
            }

            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                client.Connect(IPAddress.Parse("127.0.0.1"), 9999);

                MessageBox.Show("Đã kết nối đến server");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        // nhan tin
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesReceived = client.Receive(buffer);
                    string jsonData = Encoding.UTF8.GetString(buffer, 0, bytesReceived);

                    List<Phim> danhSachPhim = JsonConvert.DeserializeObject<List<Phim>>(jsonData);

                    if (danhSachPhim[0].ten == clientNameTb.Text && danhSachPhim[0].giavechuan == 1)
                    {
                        button_DatVe.Enabled = false;
                        MessageBox.Show("Quầy đã bị khoá!");
                    }
                    else if (danhSachPhim[0].ten == clientNameTb.Text && danhSachPhim[0].giavechuan == 2)
                    {
                        button_DatVe.Enabled = true;
                        MessageBox.Show("Quầy đã được mở khoá!");
                    }
                    else
                    {
                        foreach (Phim phim in danhSachPhim)
                        {
                            if (comboBox1.InvokeRequired)
                            {
                                comboBox1.Invoke(new Action(() => {
                                    comboBox1.Items.Add(phim.ten.ToString());
                                }));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                client.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phim selectedPhim = (Phim)comboBox1.SelectedItem;
            comboBox2.DataSource = selectedPhim.phongchieu;
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

            int giavechuan = selectedPhim.giavechuan;
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

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
    }
}
