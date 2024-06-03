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
        private List<User> userList = new List<User>();
        private TcpListener listener;
        public Server()
        {
            InitializeComponent();
        }

        private void button_start_server_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 9999);
            listener.Start();

            Thread clientListener = new Thread(Listen);
            clientListener.IsBackground = true;
            clientListener.Start();

            WriteToLog("Listening...");

            this.button_start_server.Enabled = false;
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

            try
            {
                string requestInJson = string.Empty;
                while (true)
                {
                    requestInJson = user.Reader.ReadLine();

                    Packet request = JsonConvert.DeserializeObject<Packet>(requestInJson);

                    switch (request.Code)
                    {
                        case 0:
                            send_movie_list(user, request);
                            break;
                        case 1:
                            lock_client(user, request);
                            break;
                        case 2:
                            unlock_client(user, request);
                            break;
                    }

                }
            }
            catch (Exception e)
            {
                client.Close();
                MessageBox.Show(e.ToString());
            }
        }

        private void send_movie_list(User user, Packet request)
        {
            request.movieList = items;

            foreach (User usr in userList)
            {
                sendSpecific(usr, request);
            }

            WriteToLog($"{request.Name} joined");
        }

        private void lock_client(User user, Packet request)
        {
            foreach (User usr in userList)
            {
                if (usr != user)
                {
                    sendSpecific(usr, request);
                }
            }
        }

        private void unlock_client(User user, Packet request)
        {
            foreach (User usr in userList)
            {
                if (usr != user)
                {
                    sendSpecific(usr, request);
                }
            }
        }
        private void sendSpecific(User user, Object message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                user.Writer.WriteLine(messageInJson);
                user.Writer.Flush();
            }
            catch
            {
                MessageBox.Show("Cannot send data to user: " + user.Username);
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

        static List<Item> items = new List<Item>();

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

    }
}