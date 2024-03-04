using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            int num;
            bool valid = false;

            if (Int32.TryParse(numTxt.Text.Trim(), out num))
            {
                if (num >= 0 && num <= 9)
                {
                    valid = true;
                }
            }

            if (!valid)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!");
                resTxt.Clear();
                return;
            }

            switch (num)
            {
                case 0:
                    resTxt.Text = "Không";
                    break;
                case 1:
                    resTxt.Text = "Một";
                    break;
                case 2:
                    resTxt.Text = "Hai";
                    break;
                case 3:
                    resTxt.Text = "Ba";
                    break;
                case 4:
                    resTxt.Text = "Bốn";
                    break;
                case 5:
                    resTxt.Text = "Năm";
                    break;
                case 6:
                    resTxt.Text = "Sáu";
                    break;
                case 7:
                    resTxt.Text = "Bảy";
                    break;
                case 8:
                    resTxt.Text = "Tám";
                    break;
                case 9:
                    resTxt.Text = "Chín";
                    break;
            }

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
