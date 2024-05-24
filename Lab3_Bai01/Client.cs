using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private void button_Send_Click(object sender, EventArgs e)
        {
            if (richTextBox_Message.Text != string.Empty)
            {
                string Ip = textBox_IPHost.Text;
                int Port = int.Parse(textBox_Port.Text);
                string Message = textBox_IPHost.Text + ": " + richTextBox_Message.Text;

                UdpClient udpClient = new UdpClient();
                Byte[] bytesSend = Encoding.UTF8.GetBytes(Message);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(Ip), Port);
                udpClient.Send(bytesSend, bytesSend.Length, endPoint);
                udpClient.Close();
                richTextBox_Message.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tin nhắn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
