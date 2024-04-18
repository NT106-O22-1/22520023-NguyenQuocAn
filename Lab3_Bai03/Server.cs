using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai03
{
    public partial class Server : Form
    {
        private Socket socket;
        private Socket client;
        public Server()
        {
            InitializeComponent();
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(IPAddress.Any, 8080));
                socket.Listen(5);
                button_Listen.Enabled = false;
                listView_Message.Items.Add("Đang lắng nghe...");

                socket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                client = socket.EndAccept(ar);
                listView_Message.Items.Add("Kết nối thành công!");

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
                        listView_Message.Invoke(new Action(() =>
                        {
                            ListViewItem item = new ListViewItem(message);
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
