using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6_contest_2;
using Newtonsoft.Json;

namespace Lab2
{
    public partial class Client : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private IPEndPoint serverIP;

        public Client()
        {
            InitializeComponent();
            serverIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
        }

        List<Item> items = new List<Item>();

        #region logic đặt vé
        static List<List<string>> checkedValues = new List<List<string>>();
        static List<List<int>> checkedValuesIndex = new List<List<int>>();
        static long[] resStoring = new long[1001];

        private void movieCb_SelectedValueChanged(object sender, EventArgs e)
        {
            screenCb.Items.Clear();

            Item movie = new Item();
            foreach (Item item in items)
            {
                if (item.ten == movieCb.Text) { movie = item; break; }
            }

            for (int i = 0; i < movie.phongchieu.Count; i++)
            {
                movie.phongchieu.Sort();
                screenCb.Items.Add(string.Format("Phòng chiếu {0}", movie.phongchieu[i]));
            }

            label3.Visible = false;
            checkedListBox.Visible = false;
        }

        private void screenCb_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] str = new string[]
            {
                "A1", "B1", "C1",
                "A2", "B2", "C2",
                "A3", "B3", "C3",
                "A4", "B4", "C4",
                "A5", "B5", "C5"
            };
            bool state = false;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
                checkedListBox.Items[i] = str[i];
            }

            int idx = CantorPairing(movieCb.SelectedIndex, screenCb.SelectedIndex);

            foreach (var index in checkedValuesIndex[idx])
            {
                checkedListBox.Items[index] = "sold";
                checkedListBox.SetItemCheckState(index, CheckState.Indeterminate);
            }

            label3.Visible = true;
            checkedListBox.Visible = true;
        }

        public static int CantorPairing(int a, int b)
        {
            int res = (((a + b) * (a + b + 1)) / 2) + b;
            return res;
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            Item movie = new Item();
            foreach (Item item in items)
            {
                if (item.ten == movieCb.Text) { movie = item; break; }
            }

            long gia_ve = movie.giavechuan;
            int idx = CantorPairing(movieCb.SelectedIndex, screenCb.SelectedIndex);

            foreach (var item in checkedListBox.CheckedItems)
            {
                if (item.ToString() != "sold")
                {
                    checkedValues[idx].Add(item.ToString());
                    checkedValuesIndex[idx].Add(checkedListBox.Items.IndexOf(item));
                }
            }

            int so_ve_vot = 0, so_ve_thuong = 0, so_ve_vip = 0;
            string picked = "";
            foreach (var item in checkedValues[idx])
            {
                if (item == "A1" || item == "A5" || item == "C1" || item == "C5")
                {
                    picked += item + ", ";
                    so_ve_vot++;
                }
                else if (item == "B2" || item == "B3" || item == "B4")
                {
                    picked += item + ", ";
                    so_ve_vip++;
                }
                else
                {
                    picked += item + ", ";
                    so_ve_thuong++;
                }
            }

            long res = (so_ve_vot * gia_ve / 4) + (so_ve_thuong * gia_ve) + (so_ve_vip * gia_ve * 2);
            resStoring[idx] = res;

            if (res == 0)
            {
                MessageBox.Show(
                    "Đảm bảo chọn đầy đủ phim, phòng chiếu và ít nhất 1 ghế!",
                    "Đặt vé không thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                return;
            }

            MessageBox.Show(string.Format(
                "Tên phim: {0}\n" +
                "{1}\n" +
                "Những ghế đã chọn là: {2}\n" +
                "Số tiền cần phải thanh toán: {3}\n",
                movieCb.Text, screenCb.Text, picked, res),
                "Đặt vé thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

            foreach (var index in checkedValuesIndex[idx])
            {
                checkedListBox.Items[index] = "sold";
                checkedListBox.SetItemCheckState(index, CheckState.Indeterminate);
            }
        }

        class OutputItem
        {
            public string ten;
            public int sovebanra;
            public int soveton;
            public string tilevebanra;
            public long doanhthu;
            public int xephangdoanhthu;
        }
        private void writeBtn_Click(object sender, EventArgs e)
        {
            List<OutputItem> data = new List<OutputItem>();

            int i = 0;
            foreach (Item item in items)
            {
                OutputItem outputItem = new OutputItem();
                data.Add(outputItem);

                int sovebanra = 0;
                long doanhthu = 0;

                for (int j = 0; j < item.phongchieu.Count; j++)
                {
                    int idx = CantorPairing(i, j);
                    sovebanra += checkedValuesIndex[idx].Count;
                    doanhthu += resStoring[idx];
                }

                int soveton = 15 * item.phongchieu.Count - sovebanra;

                outputItem.ten = item.ten;
                outputItem.sovebanra = sovebanra;
                outputItem.soveton = soveton;
                outputItem.tilevebanra = string.Format("{0:0.00} %", sovebanra * 100.0 / (sovebanra + soveton));
                outputItem.doanhthu = doanhthu;
                i++;
            }

            List<long> ranking = new List<long>();

            foreach (OutputItem outputItem in data)
            {
                ranking.Add(outputItem.doanhthu);
            }

            ranking.Sort();
            ranking.Reverse();

            for (int k = 0; k < ranking.Count; k++)
            {
                foreach (OutputItem outputItem in data)
                {
                    if (outputItem.doanhthu == ranking[k])
                    {
                        outputItem.xephangdoanhthu = k + 1;
                        break;
                    }
                }
            }

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("output5.json"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file output5.json");
                return;
            }

            try { File.WriteAllText(ofd.FileName, string.Empty); }
            catch { MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
            MessageBox.Show("Đã ghi thành công vào output5.json");

            fs.Close();
        }

        #endregion

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên client!");
                return;
            }

            try
            {
                client = new TcpClient();
                client.Connect(serverIP);

                connectBtn.Enabled = false;
                connectBtn.Text = "Connected to server";
                nameTb.Enabled = false;
                groupBox1.Enabled = true;
                purchaseBtn.Enabled = true;
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

                    if (responseInJson != null)
                    {
                        List<Item> response = JsonConvert.DeserializeObject<List<Item>>(responseInJson);

                        if (response[0].giavechuan == 1 && response[0].ten == nameTb.Text)
                        {
                            MessageBox.Show("Quầy đã bị khoá");
                            purchaseBtn.Enabled = false;
                        }
                        else if (response[0].giavechuan == 2 && response[0].ten == nameTb.Text)
                        {
                            MessageBox.Show("Quầy đã được mở");
                            purchaseBtn.Enabled = true;
                        }
                        else
                        {
                            items = response;
                            List<int> tmp = new List<int>();
                            int so_phim = 0, so_phong_chieu;

                            foreach (Item item in items)
                            {
                                AddToMovieCb(item.ten);
                                tmp.Add(item.phongchieu.Count);
                                so_phim++;
                            }

                            so_phong_chieu = tmp.Max();
                            int n = CantorPairing(so_phim, so_phong_chieu) + 1;

                            for (int i = 0; i < n; i++)
                            {
                                checkedValues.Add(new List<string>());
                                checkedValuesIndex.Add(new List<int>());
                            }
                        }
                    }
                }
            }
            catch
            {
                client.Close();
            }
        }

        private void AddToMovieCb(string s)
        {
            if (movieCb.InvokeRequired)
            {
                movieCb.Invoke(new Action(() =>
                {
                    movieCb.Items.Add(s);
                }));
            }
            else
            {
                movieCb.Items.Add(s);
            }
        }
    }
}
