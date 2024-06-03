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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            sendToServer(new Packet(0));

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        private void Receive()
        {
            try
            {
                string responseInJson = string.Empty;
                while (true)
                {
                    responseInJson = reader.ReadLine();

                    Packet response = JsonConvert.DeserializeObject<Packet>(responseInJson);
                }
            }
            catch
            {
                client.Close();
            }
        }

        private void button_Closed_Click(object sender, EventArgs e)
        {
            sendToServer(new Packet(1)
            {
                Name = nameClientTb.Text,
            });
        }
        private void sendToServer(Packet message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                writer.WriteLine(messageInJson);
                writer.Flush();
            }
            catch
            {
                MessageBox.Show("Failed to send data to server!");
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            sendToServer(new Packet(2)
            {
                Name = nameClientTb.Text,
            });
        }
    }
}
