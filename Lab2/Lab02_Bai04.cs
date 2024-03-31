using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai04 : Form
    {
        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private void eraseField()
        {
            iNameTxb.Clear();
            iIdTxb.Clear();
            iPhoneTxb.Clear();
            iC1Txb.Clear();
            iC2Txb.Clear();
            iC3Txb.Clear();

            oNameTxb.Clear();
            oIdTxb.Clear();
            oPhoneTxb.Clear();
            oC1Txb.Clear();
            oC2Txb.Clear();
            oC3Txb.Clear();
            oAvgTxb.Clear();
            pageNum.Text = 0.ToString();
        }
 
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("input4.txt"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file input4.txt");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            richTextBox.Clear();
            richTextBox.AppendText(sr.ReadToEnd().Trim());

            fs.Close();

            addBtn.Enabled = true;
            saveBtn.Enabled = true;
            backBtn.Enabled = false;
            nextBtn.Enabled = false;

            eraseField();
        }

        static bool inputValidator(string name, string id, string phone, float c1, float c2, float c3)
        {
            if (name == "" || name.Any(char.IsDigit)) { return false; }
            if (id.Length != 8 || id.Any(char.IsLetter)) { return false; }
            if (phone.Length != 10 || phone.Any(char.IsLetter) || phone[0].ToString() != "0") { return false; }
            if (c1 < 0 || c2 < 0 || c3 < 0 || c1 > 10 || c2 > 10 || c3 > 10) { return false; }

            return true;
        }

        class Student
        {
            public string name;
            public string id;
            public string phone;
            public float course1;
            public float course2;
            public float course3;
            public float avg;
            public bool IsCorrectlyCreated = true;

            public Student() { }

            public Student(string n, string i, string p, string p1, string p2, string p3)
            {
                float c1 = 0, c2 = 0, c3 = 0;
                try
                {
                    float.TryParse(p1, out c1);
                    float.TryParse(p2, out c2);
                    float.TryParse(p3, out c3);
                }
                catch { IsCorrectlyCreated = false; }

                if (!inputValidator(n, i, p, c1, c2, c3)) { IsCorrectlyCreated = false; }

                name = n;
                id = i;
                phone = p;
                course1 = c1;
                course2 = c2;
                course3 = c3;
                avg = (course1 + course2 + course3) / 3;
            }

            public string Print()
            {
                string info = string.Format("\n\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                    name, id, phone, course1, course2, course3);
                return info;
            }

            public string PrintWithAvg()
            {
                string info = string.Format("{0}\n{1:0.00}", Print(), avg);
                return info;
            }

            ~Student() { }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = iNameTxb.Text;
            string id = iIdTxb.Text;
            string phone = iPhoneTxb.Text;
            string c1 = iC1Txb.Text;
            string c2 = iC2Txb.Text;
            string c3 = iC3Txb.Text;

            Student student = new Student(name, id, phone, c1, c2, c3);

            if (!student.IsCorrectlyCreated)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường và đúng định dạng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            richTextBox.AppendText(student.Print());
            richTextBox.Text = richTextBox.Text.Trim();
        }

        private void errorMessage()
        {
            MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            eraseField();

            string[] s = richTextBox.Text.Split('\n');

            List<Student> students = new List<Student>();
            for (int i = 0; i < s.Length; i+=7)
            {
                Student student = new Student(s[i], s[i+1], s[i+2], s[i+3], s[i+4], s[i+5]);
                if (student.IsCorrectlyCreated)
                {
                    students.Add(student);
                }
            }

            hiddenTxb.Clear();
            foreach (Student student in students)
            {
                hiddenTxb.AppendText(student.PrintWithAvg());
            }
            hiddenTxb.Text = hiddenTxb.Text.Trim();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("output4.txt"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file output4.txt");
                return;
            }
            try { File.WriteAllText(ofd.FileName, string.Empty); }
            catch { errorMessage(); }

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            
            sw.Write(hiddenTxb.Text);
            sw.Close();
            MessageBox.Show("Đã ghi thành công vào output4.txt");

            fs.Close();

            richTextBox.Text = "Để thêm lại danh sách sinh viên: \nChọn \"Mở input4.txt\"\n\n" +
                "Để đọc danh sách sinh viên: \nChọn \"Đọc output4.txt\"";

            addBtn.Enabled = false;
            saveBtn.Enabled = false;
        }

        static int index = -1;
        static List<Student> students = new List<Student>();
        static List<string> studentAvg = new List<string>();

        private void showBtn_Click(object sender, EventArgs e)
        {
            eraseField();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!ofd.FileName.Contains("output4.txt"))
            {
                MessageBox.Show("Vui lòng tạo/chọn file output4.txt");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            richTextBox.Clear();
            richTextBox.AppendText(sr.ReadToEnd().Trim());

            fs.Close();

            index = -1;
            students.Clear();
            studentAvg.Clear();

            string[] s = richTextBox.Text.Split('\n');

            try
            {
                for (int i = 0; i < s.Length; i += 8)
                {
                    Student student = new Student(s[i], s[i + 1], s[i + 2], s[i + 3], s[i + 4], s[i + 5]);
                    if (student.IsCorrectlyCreated)
                    {
                        students.Add(student);
                        studentAvg.Add(s[i + 6]);
                    }
                    else errorMessage();
                }
            }
            catch { errorMessage(); }

           // nextBtn_Click(sender, e);
            nextBtn.Enabled = true;
            backBtn.Enabled = true;
        }

        private void ShowPrint(Student student)
        {
            oNameTxb.Text = student.name;
            oIdTxb.Text = student.id;
            oPhoneTxb.Text = student.phone;
            oC1Txb.Text = student.course1.ToString();
            oC2Txb.Text = student.course2.ToString();
            oC3Txb.Text = student.course3.ToString();
            oAvgTxb.Text = studentAvg[index];
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (index < studentAvg.ToArray().Length - 1) { index++; }
            pageNum.Text = (index + 1).ToString();

            ShowPrint(students[index]);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (index > 0) { index--; }
            pageNum.Text = (index + 1).ToString();

            ShowPrint(students[index]);
        }
    }
}
