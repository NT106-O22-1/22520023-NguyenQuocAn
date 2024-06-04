using Lab6_contest_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Contest
{
    public partial class Form_Admin : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private IPEndPoint serverIP;
        
        public Form_Admin()
        {
            InitializeComponent();
            button_Closed.Enabled = false;
            button_Open.Enabled = false;
            serverIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(serverIP);
                button_Closed.Enabled = true;
                button_Open.Enabled = true;
                button_Connect.Text = "Connected to server";
                button_Connect.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Can not connect to the server!");
                this.Close();
                return;
            }

            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        private void Receive()
        {
            //try
            //{
            //    string responseInJson = string.Empty;
            //    while (true)
            //    {
            //        responseInJson = reader.ReadLine();
            //    }
            //}
            //catch
            //{
            //    client.Close();
            //}
        }

        private void button_Closed_Click(object sender, EventArgs e)
        {
            if (nameClientTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên quầy muốn thao tác");
                return;
            }
            List<Item> req = new List<Item>();
            req.Add(new Item
            {
                ten = nameClientTb.Text,
                giavechuan = 1,
                phongchieu = new List<int> { 1 }
            });

            sendToServer(req);
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (nameClientTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên quầy muốn thao tác");
                return;
            }
            List<Item> req = new List<Item>();
            req.Add(new Item
            {
                ten = nameClientTb.Text,
                giavechuan = 2,
                phongchieu = new List<int> { 1 }
            });

            sendToServer(req);
        }

        private void sendToServer(List<Item> message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                writer.WriteLine(messageInJson);
                writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
