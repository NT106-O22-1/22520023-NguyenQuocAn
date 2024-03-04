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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;

            bool valid = float.TryParse(num1Txt.Text.ToString(), out num1)
                && float.TryParse(num2Txt.Text.ToString(), out num2)
                && float.TryParse(num3Txt.Text.ToString(), out num3);

            if (!valid)
            {
                if (string.IsNullOrEmpty(num1Txt.Text)
                    || string.IsNullOrEmpty(num2Txt.Text)
                    || string.IsNullOrEmpty(num3Txt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ 3 số!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!");
                    maxTxt.Clear();
                    minTxt.Clear();
                }
                return;
            }

            num1 = (float)Convert.ToDouble(num1Txt.Text.Trim());
            num2 = (float)Convert.ToDouble(num2Txt.Text.Trim());
            num3 = (float)Convert.ToDouble(num3Txt.Text.Trim());


            float max = Math.Max(num1, Math.Max(num2, num3));
            float min = Math.Min(num1, Math.Min(num2, num3));

            maxTxt.Text = max.ToString();
            minTxt.Text = min.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            num1Txt.Clear();
            num2Txt.Clear();
            num3Txt.Clear();
            maxTxt.Clear();
            minTxt.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
