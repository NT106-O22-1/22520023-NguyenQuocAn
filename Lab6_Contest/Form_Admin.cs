using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab6_Contest
{
    public partial class Form_Admin : Form
    {
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

        //admin = client
        private Socket adminSocket;

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                adminSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                adminSocket.Connect(IPAddress.Parse("127.0.0.1"), 8080);
                MessageBox.Show("Đã kết nối đến server");
 
                button_Closed.Enabled = true;
                button_Open.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
