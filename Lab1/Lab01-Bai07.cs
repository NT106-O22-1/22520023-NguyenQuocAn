using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string[] elements = inputTb.Text.Split(',');

            bool valid1 = elements[0].Any(char.IsDigit);
            bool valid2 = valid1;
            nameTb.Text = elements[0];

            float[] val = new float[elements.Length - 1];
            for (int i = 1; i < elements.Length; i++)
            {
                valid2 = !float.TryParse(elements[i], out val[i - 1]);
            }

            if (inputTb.Text.Trim() == "" || valid1 || valid2)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!");
                return;
            }

            scoreListTb.Clear();
            int index = 1;
            foreach (float v in val)
            {
                scoreListTb.Text += string.Format("Môn {0}: {1}   ", index, v);
                index++;
            }

            float avg = Queryable.Average(val.AsQueryable());
            avgTb.Text = string.Format("{0:0.00}", avg);
            float max = Queryable.Max(val.AsQueryable());
            maxTb.Text = string.Format("{0}", max);
            float min = Queryable.Min(val.AsQueryable());
            minTb.Text = string.Format("{0}", min);

            int cnt = 0;
            foreach (float v in val)
            {
                if (v < 5) cnt++;
            }

            passTb.Text = (index - cnt - 1).ToString();
            failTb.Text = cnt.ToString();

            if (avg < 3.5 || min < 2)
            {
                typeTb.Text = "Kém";
            }
            else if (avg < 5 || min < 3.5) 
            {
                typeTb.Text = "Yếu";
            }
            else if (avg < 6.5 || min < 5) {
                typeTb.Text = "TB";
            }
            else if (avg < 8 || min < 6.5)
            {
                typeTb.Text = "Khá";
            }
            else 
            {
                typeTb.Text = "Giỏi";
            }
        }
    }
}
