using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                if (string.IsNullOrEmpty(urlTb.Text))
                {
                    MessageBox.Show("Vui lòng nhập link website", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(pathTb.Text))
                {
                    MessageBox.Show("Vui lòng nhập đường dẫn tải xuống", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Stream response = webClient.OpenRead(urlTb.Text);
                    webClient.DownloadFile(urlTb.Text, pathTb.Text);
                    string result = File.ReadAllText(pathTb.Text);

                    richTextBox1.Text = result;
                    MessageBox.Show("Download thành công", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    response.Close();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}