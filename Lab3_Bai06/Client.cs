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
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab3_Bai06
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập username", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Username.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tin nhắn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Send();
                textBox_Username.Enabled = false;
                AddMessage("[" + textBox_Username.Text + "]: " + richTextBox_Message.Text + "\n");
            }
        }

        IPEndPoint IP;
        Socket client;

        private void button_Connect_Click(object sender, EventArgs e)
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
                Invoke(new Action(() => MessageBox.Show("Đã kết nối đến server")));
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Close()
        {
            client.Close();
        }

        void Send()
        {
            if (richTextBox_Message.Text != string.Empty)
            {
                client.Send(Serialize("[" + textBox_Username.Text + "]: " + richTextBox_Message.Text + "\n"));
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        void AddMessage(string s)
        {
            richTextBox_Message.Text = "";
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        
    }
}
