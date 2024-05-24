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

namespace Lab3_Bai03
{
    public partial class Client : Form
    {
        private Socket clientSocket;
        public Client()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);

                button_Send.Enabled = true;
                button_Disconnect.Enabled = true;

                Invoke(new Action(() => MessageBox.Show("Đã kết nối đến server")));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show("Lỗi: " + ex.Message)));
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (clientSocket == null || !clientSocket.Connected)
            {
                MessageBox.Show("Chưa kết nối với server");
                return;
            }

            string message = "Client: " + richTextBox_Message.Text;
            if (message.Length > 0)
            {
                try
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    clientSocket.Send(buffer);

                    richTextBox_Message.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            if (clientSocket != null && clientSocket.Connected)
            {
                try
                {
                    clientSocket.Close();

                    Invoke((Action)delegate
                    {
                        button_Send.Enabled = false;
                        button_Disconnect.Enabled = false;
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
