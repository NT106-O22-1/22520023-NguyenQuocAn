using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_Bai02
{
    public partial class Bai02 : Form
    {
        private Socket socket;
        private Socket client;

        public Bai02()
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
                    StringBuilder dataBuilder = new StringBuilder();

                    while (true)
                    {
                        byte[] buffer = new byte[1024];
                        int bytesReceive = client.Receive(buffer);
                        string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesReceive);
                        dataBuilder.Append(receivedData);

                        if (receivedData.EndsWith(Environment.NewLine))
                        {
                            break;
                        }
                    }

                    string data = dataBuilder.ToString();

                    listView_Message.Invoke(new Action(() =>
                    {
                        ListViewItem item = new ListViewItem(data);
                        listView_Message.Items.Add(item);
                    }));
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