using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6_Contest
{
    public partial class Form_Admin : Form
    {
        private Socket client;
        class Phim
        {
            public string ten { get; set; }
            public int giavechuan { get; set; }
            public int[] phongchieu { get; set; }
        }

        public Form_Admin(string text)
        {
            InitializeComponent();
            button_Closed.Enabled = false;
            button_Open.Enabled = false;
        }
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
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

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesReceived = client.Receive(buffer);
                    string jsonData = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                client.Close();
            }
        }

        private void button_Closed_Click(object sender, EventArgs e)
        {
            if (toControlTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên quầy muốn khoá/mở");
                return;
            }
            Phim req = new Phim()
            {
                ten = toControlTb.Text,
                giavechuan = 1,
                phongchieu = new int[] {0}
            };
            
            List<Phim> message = new List<Phim>();
            message.Add(req);
            client.Send(Serialize(JsonConvert.SerializeObject(message)));
        }
        

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (toControlTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên quầy muốn khoá/mở");
                return;
            }
            Phim req = new Phim()
            {
                ten = toControlTb.Text,
                giavechuan = 2,
                phongchieu = new int[] { 0 }
            };

            List<Phim> message = new List<Phim>();
            message.Add(req);
            client.Send(Serialize(JsonConvert.SerializeObject(message)));
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
    }
}
