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
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        static string whole_text = "";
        private void readBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("input3.txt"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file input3.txt");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            richTextBox.Clear();
            richTextBox.AppendText(sr.ReadToEnd());

            whole_text = richTextBox.Text.Trim();

            fs.Close();
            calBtn.Enabled = true;
            writeBtn.Enabled = true;
        }

        static string Evaluate(string line)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(line, "");
            return v.ToString();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            var k = new[] { "–", "x", "÷", ":" };
            if(k.Any(whole_text.Contains))
            {
                MessageBox.Show("Đảm bảo sử dụng đúng dấu với các phép toán:\n"
                    + "Phép cộng: +\n"
                    + "Phép trừ: - (tránh nhầm với \"–\")\n"
                    + "Phép nhân: *\n"
                    + "Phép chia: /\n",
                    "Lỗi cú pháp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            char[] del = new char[] { '\n' };
            string[] lines = whole_text.Split(del, StringSplitOptions.RemoveEmptyEntries);

            string res = "";
            foreach (string line in lines)
            {
                try 
                { 
                    res += string.Format("{0} = {1}\n", line, Evaluate(line)); 
                }
                catch { 
                    MessageBox.Show("Có phép tính lỗi cú pháp!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            richTextBox.Clear();
            richTextBox.AppendText(res.Trim());
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("output3.txt"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file output3.txt");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(richTextBox.Text);
            sw.Close();
            MessageBox.Show("Đã ghi thành công vào output3.txt");

            fs.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
