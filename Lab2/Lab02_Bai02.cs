using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if(!ofd.FileName.Contains(".txt"))
            {
                MessageBox.Show("Vui lòng chọn file .txt");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            richTextBox.Clear();
            richTextBox.AppendText(sr.ReadToEnd());

            long length = new FileInfo(ofd.FileName).Length;

            string content = richTextBox.Text.Trim();
            char[] del = new char[] { ' ', '\r', '\n', '\t' };
            long wordsCnt = content.Split(del, StringSplitOptions.RemoveEmptyEntries).Length;
            
            fs.Close();

            nameTxb.Text = ofd.SafeFileName.ToString();
            sizeTxb.Text = string.Format("{0} bytes", length);
            urlTxb.Text = fs.Name.ToString();
            lineCountTxb.Text = File.ReadLines(ofd.FileName).Count().ToString();
            wordsCountTxb.Text = wordsCnt.ToString();
            charCountTxb.Text = content.Length.ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
