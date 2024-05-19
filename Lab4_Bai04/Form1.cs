using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.IO;

namespace Lab4_Bai04
{
    public partial class Form1 : UserControl
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetchMovies_Click(object sender, EventArgs e)
        {
            string url = "https://betacinemas.vn/phim.htm";
            flowLayoutPanelMovies.Controls.Clear();
            progressBar.Value = 0;

            try
            {
                var movieInfos = GetMovieInfos(url);

                int totalMovies = movieInfos.Count;
                int fetchedMovies = 0;

                foreach (var movieInfo in movieInfos)
                {
                    var moviePanel = CreateMoviePanel(movieInfo);
                    flowLayoutPanelMovies.Controls.Add(moviePanel);

                    fetchedMovies++;
                    UpdateProgressBar(totalMovies, fetchedMovies);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar(int totalMovies, int fetchedMovies)
        {
            // Calculate progress percentage
            int progressPercentage = (int)((double)fetchedMovies / totalMovies * 100);

            // Ensure progress bar value doesn't exceed its maximum value
            if (progressPercentage > progressBar.Maximum)
            {
                progressPercentage = progressBar.Maximum;
            }

            // Update progress bar value
            progressBar.Value = progressPercentage;
        }

        private List<MovieInfo> GetMovieInfos(string url)
        {
            var movieInfos = new List<MovieInfo>();

            using (var webClient = new WebClient())
            {
                HtmlWeb web = new HtmlWeb();
                web.OverrideEncoding = Encoding.UTF8; // Or the appropriate encoding for your document
                HtmlAgilityPack.HtmlDocument document = web.Load(url);

                var movieNodes = document.DocumentNode.SelectNodes("//div[@class='col-lg-4 col-md-4 col-sm-8 col-xs-16 padding-right-30 padding-left-30 padding-bottom-30']");
                if (movieNodes != null)
                {
                    foreach (var node in movieNodes)
                    {
                        var movieInfo = new MovieInfo();

                        var titleNode = node.SelectSingleNode(".//h3/a");
                        if (titleNode != null)
                        {
                            movieInfo.Title = titleNode.InnerText.Trim();
                            movieInfo.MovieLink = "https://betacinemas.vn" + titleNode.GetAttributeValue("href", "");

                            movieInfo2s.Add(new MovieInfo2(movieInfo.Title));
                        }

                        var imageNode = node.SelectSingleNode(".//img[@class='img-responsive border-radius-20']");
                        if (imageNode != null)
                        {
                            movieInfo.ImageUrl = imageNode.GetAttributeValue("src", "");
                        }

                        movieInfos.Add(movieInfo);
                    }
                }
            }

            return movieInfos;
        }

        private PictureBox CreateMovieBanner(MovieInfo movieInfo)
        {
            var pictureBox = new PictureBox
            {
                ImageLocation = movieInfo.ImageUrl,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 60,
                Height = 60,
                Cursor = Cursors.Hand,
                Tag = movieInfo
            };
            pictureBox.Click += (s, e) => ShowMovieLink(movieInfo);
            return pictureBox;
        }

        private Label CreateMovieLinkLabel(MovieInfo movieInfo)
        {
            var linkLabel = new Label
            {
                Text = movieInfo.Title,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Cursor = Cursors.Hand,
                Font = new Font("Arial", 10, FontStyle.Bold), // Change font and size here
                ForeColor = Color.Coral, // Change color here
                Tag = movieInfo
            };
            linkLabel.Click += (s, e) => ShowMovieLink(movieInfo);
            return linkLabel;
        }

        private Panel CreateMoviePanel(MovieInfo movieInfo)
        {
            var panel = new Panel();
            panel.Size = new Size(280, 70); // Set the size according to your preference

            var flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            var pictureBox = CreateMovieBanner(movieInfo);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            flowLayoutPanel.Controls.Add(pictureBox);

            var label = CreateMovieLinkLabel(movieInfo);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.AutoSize = true;
            flowLayoutPanel.Controls.Add(label);

            panel.Controls.Add(flowLayoutPanel);
            panel.BackColor = Color.Gainsboro;

            return panel;
        }


        private void ShowMovieLink(MovieInfo movieInfo)
        {
            if (!string.IsNullOrEmpty(movieInfo.MovieLink))
            {
                // Open movie link in default web browser
                System.Diagnostics.Process.Start(movieInfo.MovieLink);
            }
        }

        public class MovieInfo
        {
            public string Title { get; set; }
            public string ImageUrl { get; set; }
            public string MovieLink { get; set; }
        }

        List<MovieInfo2> movieInfo2s = new List<MovieInfo2>();

        public class MovieInfo2
        {
            public string ten { get; set; }
            public int giavechuan { get; set; }
            public int[] phongchieu { get; set; }

            public MovieInfo2(string name)
            {
                ten = name;
                giavechuan = 40000;
                phongchieu = new int[] { 1, 2, 3 };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(movieInfo2s, Formatting.Indented);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("input5.json"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file input5.json");
                return;
            }

            try { File.WriteAllText(ofd.FileName, string.Empty); }
            catch { MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
            MessageBox.Show("Đã ghi thành công vào input5.json");

            fs.Close();
        }
    }
}
