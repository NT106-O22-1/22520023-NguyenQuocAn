using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.NetworkInformation;
using System.IO;
using System.Linq;

namespace Lab6_contest_2
{
    public partial class Server : Form
    {
        private TcpListener listener;
        private List<User> userList = new List<User>();
        private List<Item> items = new List<Item>();

        public Server()
        {
            InitializeComponent();
            button_start_server.Enabled = false;
        }

        private void button_start_server_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 9999);
            listener.Start();

            Thread clientListener = new Thread(Listen);
            clientListener.IsBackground = true;
            clientListener.Start();

            WriteToLog("Listening...");
            button_start_server.Enabled = false;
            button_start_server.Text = "Listening...";
        }
        private void Listen()
        {
            try
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();

                    Thread receiver = new Thread(Receive);
                    receiver.IsBackground = true;
                    receiver.Start(client);
                }
            }
            catch
            {
                listener = new TcpListener(IPAddress.Any, 9999);
                listener.Start();
            }
        }

        private void Receive(object obj)
        {
            TcpClient client = obj as TcpClient;
            User user = new User(client);
            userList.Add(user);
            WriteToLog("A client joined.");
            sendSpecific(user, items);

            try
            {
                string requestInJson = string.Empty;
                while (true)
                {
                    requestInJson = user.Reader.ReadLine();

                    if (requestInJson != null)
                    {
                        List<Item> request = JsonConvert.DeserializeObject<List<Item>>(requestInJson);
                        sendAll(userList, request);
                    }
                }
            }
            catch
            {
                client.Close();
            }
        }
        
        private void readJsonBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("input5.json"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file input5.json");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string json = sr.ReadToEnd();
            items = JsonConvert.DeserializeObject<List<Item>>(json);

            button_start_server.Enabled = true;

            List<int> tmp = new List<int>();
            int so_phim = 0;

            foreach (Item item in items)
            {
                try
                {
                    movieCb.Items.Add(item.ten);
                    tmp.Add(item.phongchieu.Count);
                    so_phim++;
                }
                catch
                {
                    MessageBox.Show("Kiểm tra định dạng file JSON!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void sendSpecific(User usr, Object message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            if (usr != null)
            {
                usr.Writer.WriteLine(messageInJson);
                usr.Writer.Flush();
            }
        }

        private void sendAll(List<User> userList, Object message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            foreach (User usr in userList)
            {
                if (usr != null)
                {
                    usr.Writer.WriteLine(messageInJson);
                    usr.Writer.Flush();
                }
            }
        }

        public void WriteToLog(string line)
        {
            if (Log.InvokeRequired)
            {
                Log.Invoke(new Action(() =>
                {
                    Log.Items.Add(string.Format("{0}: {1}", DateTime.Now.ToString("HH:mm"), line));
                }));
            }
            else
            {
                Log.Items.Add(string.Format("{0}: {1}", DateTime.Now.ToString("HH:mm"), line));
            }
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (User user in userList)
            {
                user.Client.Close();
            }
            if (listener != null)
            {
                listener.Stop();
            }
        }
    }
}