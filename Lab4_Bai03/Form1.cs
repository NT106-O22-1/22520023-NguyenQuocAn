using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

       
        private void loadBtn_Click(object sender, EventArgs e)
        {
            string url = urlTb.Text;
            webView.Source = new Uri(url);
        }


        private void downloadBtn_Click(object sender, EventArgs e)
        {
            string url = urlTb.Text;
            string fileName = "DownloadedHtml.html";
            string fileurl = desktopPath + "/" + fileName;

            try
            {
                WebClient myClient = new WebClient();
                Stream response = myClient.OpenRead(url);
                myClient.DownloadFile(url, fileurl);

                MessageBox.Show("Html source downloaded successfully to Desktop.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void downrscBtn_Click(object sender, EventArgs e)
        {
            string url = urlTb.Text;
            string downloadFolder = Path.Combine(desktopPath, "DownloadedImages");

            if (!Directory.Exists(downloadFolder))
            {
                Directory.CreateDirectory(downloadFolder);
            }

            try
            {
                var imageUrls = GetImageUrlsFromWebsite(url);

                foreach (var imageUrl in imageUrls)
                {
                    DownloadImage(imageUrl, downloadFolder);
                }

                MessageBox.Show("All images downloaded successfully to Desktop.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetImageUrlsFromWebsite(string url)
        {
            var imageUrls = new List<string>();

            try
            {
                using (var webClient = new WebClient())
                {
                    var response = webClient.DownloadString(url);
                    var document = new HtmlAgilityPack.HtmlDocument();
                    document.LoadHtml(response);

                    var imageNodes = document.DocumentNode.SelectNodes("//img[@src]");

                    if (imageNodes != null)
                    {
                        foreach (var node in imageNodes)
                        {
                            var src = node.GetAttributeValue("src", null);
                            if (!string.IsNullOrEmpty(src))
                            {
                                var imageUrl = new Uri(new Uri(url), src).ToString();
                                imageUrls.Add(imageUrl);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return imageUrls;
        }

        private void DownloadImage(string imageUrl, string downloadFolder)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    var fileName = Path.GetFileName(new Uri(imageUrl).LocalPath);
                    var filePath = Path.Combine(downloadFolder, fileName);
                    webClient.DownloadFile(imageUrl, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download image {imageUrl}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
