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
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Newtonsoft.Json;

namespace Lab3_Bai04
{
    public partial class Server : Form
    {
        private Socket socket;
        private Socket client;
        List<Phim> DanhSachPhim = new List<Phim>();
        class Phim
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public int[] PhongChieu { get; set; }
           
        }

        class Message
        {
            public string message { get; set; }
            public List<Phim> DanhSachPhim { get; set; }
        }

        public Server()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "TenPhim";
            comboBox2.DisplayMember = "ToString";
        }

        private void button_DocFile_Click(object sender, EventArgs e)
        {
            //Đọc file json
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string file = sr.ReadToEnd();
                    List<Phim> PhimInfo = JsonConvert.DeserializeObject<List<Phim>>(file);
                    foreach (var phimInfo in PhimInfo)
                    {
                        DanhSachPhim.Add(phimInfo);
                    }
                    comboBox1.DataSource = null;
                    comboBox1.DataSource = PhimInfo;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phim selectedPhim = (Phim)comboBox1.SelectedItem;
            comboBox2.DataSource = selectedPhim.PhongChieu;
        }
        private void button_Listen_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(IPAddress.Any, 8080));
                socket.Listen(5);
                button_Listen.Enabled = false;
                listView_Message.Invoke(new Action(() =>
                {
                    listView_Message.Items.Add("Đang lắng nghe...");
                }));
                socket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SendMovieData(Socket clientSocket)
        {
            Message message = new Message()
            {
                message = "init",
                DanhSachPhim = DanhSachPhim
            };

            // Chuyển danh sách phim sang dạng JSON
            string jsonData = JsonConvert.SerializeObject(message);

            // Chuyển dữ liệu sang mảng byte
            byte[] data = Encoding.UTF8.GetBytes(jsonData);
            // Gửi dữ liệu đến client
            clientSocket.Send(data);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                client = socket.EndAccept(ar);
                listView_Message.Invoke(new Action(() =>
                {
                    listView_Message.Items.Add("Kết nối thành công!");
                }));

                SendMovieData(client);

                Thread thread = new Thread(HandleClient);
                thread.Start();

                socket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void HandleClient()
        {
            while (true)
            {
                try
                {
                    while (true)
                    {
                        byte[] buffer = new byte[1024];
                        int bytesReceive = client.Receive(buffer);
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesReceive);
                        ListViewItem item = new ListViewItem(message);
                        listView_Message.Invoke(new Action(() =>
                        {
                            listView_Message.Items.Add(item);
                        }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    break;
                }
            }
            client.Close();
        }
    }
}
