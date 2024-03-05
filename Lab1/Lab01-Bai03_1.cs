using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1
{
    public partial class Lab01_Bai03_1 : Form
    {
        public Lab01_Bai03_1()
        {
            InitializeComponent();
        }

        static string str = "";
        public static void ReadNum(long num)
        {
            string[] e = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            str = e[num];
        }
        private void readBtn_Click(object sender, EventArgs e)
        {
            string numr = numTxt.Text.Trim();
            int cnt0 = (numr.Length - numr.TrimEnd('0').Length) / 3;

            // validate

            long num;
            bool valid = false;

            if (Int64.TryParse(numr, out num))
            {
                if (num >= 0 && num <= 999999999999) valid = true;
            }

            if (!valid)
            {
                MessageBox.Show("Vui lòng nhập số nguyên có tối đa 12 chữ số!");
                resTxt.Clear();
                return;
            }

            // handle

            if (num == 0)
            {
                resTxt.Text = "không";
                return;
            }

            int cnt = 0;

            Stack Res = new Stack();
            string res = "";

            string[] a = { "", "mươi", "trăm", "nghìn", "mươi", "trăm", "triệu", "mươi", "trăm", "tỷ", "mươi", "trăm" };

            while (num > 0)
            {
                long tmp = num % 10;
                ReadNum(tmp);
                Res.Push(" " + a[cnt]);
                Res.Push(" " + str);
                str = "";
                num /= 10;

                cnt++;
            }

            int index = Res.ToArray().Length - (cnt0 * 6); // * 2 * 3

            while (index > 0)
            {
                res += Res.Pop();
                index--;
            }

            // "10", "11"
            res = res.Replace("một mươi không", "mười");
            res = res.Replace("một mươi", "mười");

            // "000"
            res = res.Replace("không trăm không mươi không triệu", "");
            res = res.Replace("không trăm không mươi không nghìn", "");
            res = res.Replace("không mươi không", "");
            res = res.Replace("không mươi", "lẻ");

            // "20"
            res = res.Replace("mươi không", "mươi");

            // "15", "25"
            res = res.Replace("mươi năm", "mươi lăm");
            res = res.Replace("mười năm", "mười lăm");

            // "21"
            res = res.Replace("mươi một", "mươi mốt");

            //
            res = res.Replace("   ", " ");
            res = res.Replace("  ", " ");

            resTxt.Text = res.Trim();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            numTxt.Clear();
            resTxt.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}