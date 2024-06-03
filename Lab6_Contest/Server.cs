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
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab3_Bai04
{
    public partial class Server : Form
    {
        IPEndPoint IP;
        private Socket server;
        private List<Socket> clientList;

        List<Phim> DanhSachPhim = new List<Phim>();
        class Phim
        {
            public string ten { get; set; }
            public int giavechuan { get; set; }
            public int[] phongchieu { get; set; }
           
        }

        public Server()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "ten";
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
            comboBox2.DataSource = selectedPhim.phongchieu;
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            clientList = new List<Socket>();
            // IP: ip addr server
            IP = new IPEndPoint(IPAddress.Any, 9999);
            
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                server.Bind(IP);
                WriteToLog("Start listening...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        client.Send(Serialize(JsonConvert.SerializeObject(DanhSachPhim)));
                        WriteToLog("A client joined.");

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesReceived = client.Receive(buffer);
                    string jsonData = Encoding.UTF8.GetString(buffer, 0, bytesReceived);

                    List<Phim> danhSachPhim = JsonConvert.DeserializeObject<List<Phim>>(jsonData);

                    MemoryStream stream = new MemoryStream();
                    BinaryFormatter formatter = new BinaryFormatter();

                    foreach (Socket item in clientList)
                    {
                        if (item != null)
                        {
                            string mesage = JsonConvert.SerializeObject(danhSachPhim);
                            item.Send(Serialize(mesage));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                clientList.Remove(client);
                client.Close();
            }
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        private void WriteToLog(string msg)
        {
            if(listView_Message.InvokeRequired)
            {
                listView_Message.Invoke(new Action(() =>
                {
                    listView_Message.Items.Add(msg);
                }));
            }
        }
    }
}
