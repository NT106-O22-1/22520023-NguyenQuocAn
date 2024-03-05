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

            string[] p = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            resTxt.Text = p[num];
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
