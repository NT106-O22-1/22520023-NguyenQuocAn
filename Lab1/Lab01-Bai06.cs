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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int d, m;
            Int32.TryParse(dateTimePicker1.Value.Day.ToString(), out d);
            Int32.TryParse(dateTimePicker1.Value.Month.ToString(), out m);

            string res = "";

            switch (m)
            {
                case 3:
                    if (d >= 21) res = "cung Bạch Dương";
                    else res = "cung Song Ngư";
                    break;
                case 4:
                    if (d >= 21) res = "cung Kim Ngưu";
                    else res = "cung Bạch Dương";
                    break;
                case 5:
                    if (d >= 22) res = "cung Song Tử";
                    else res = "cung Kim Ngưu";
                    break;
                case 6:
                    if (d >= 22) res = "cung Cự Giải";
                    else res = "cung Song Tử";
                    break;
                case 7:
                    if (d >= 23) res = "cung Sư Tử";
                    else res = "cung Cự Giải";
                    break;
                case 8:
                    if (d >= 23) res = "cung Xử Nữ";
                    else res = "cung Sư Tử";
                    break;
                case 9:
                    if (d >= 24) res = "cung Thiên Bình";
                    else res = "cung Xử Nữ";
                    break;
                case 10:
                    if (d >= 24) res = "cung Thần Nông";
                    else res = "cung Thiên Bình";
                    break;
                case 11:
                    if (d >= 23) res = "cung Nhân Mã";
                    else res = "cung Thần Nông";
                    break;
                case 12:
                    if (d >= 22) res = "cung Ma Kết";
                    else res = "cung Nhân Mã";
                    break;
                case 1:
                    if (d >= 21) res = "cung Bảo Bình";
                    else res = "cung Ma Kết";
                    break;
                case 2:
                    if (d >= 20) res = "cung Song Ngư";
                    else res = "cung Bảo Bình";
                    break;

            }
            label2.Text = "Bạn thuộc cung " + res;
        }

    }
}
