using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Server : Form
    {
        private UdpClient udpServer;

        public Server()
        {
            InitializeComponent();
        }

        private void ReceiveData()
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                byte[] receiveBytes = udpServer.Receive(ref clientEndPoint);
                string receivedMessage = Encoding.UTF8.GetString(receiveBytes);

                if (listView_Message.InvokeRequired)
                {
                    listView_Message.Invoke((MethodInvoker)delegate
                    {
                        listView_Message.Items.Add(receivedMessage);
                    });
                }
            }
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            udpServer = new UdpClient(8080);
            Thread receiveThread = new Thread(new ThreadStart(ReceiveData));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }
    }
}
