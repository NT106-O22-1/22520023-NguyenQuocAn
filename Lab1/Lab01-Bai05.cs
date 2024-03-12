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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void multiplication_table_handler(int num)
        {
            richTextBox.Clear();
            if (num <= 0 || num > 9)
            {
                MessageBox.Show("Vui lòng nhập B lớn hơn A không quá 9 đơn vị");
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                string tmp = string.Format("{0} x {1} = {2}\n", num, i, num * i);
                richTextBox.AppendText(tmp);
            }
        }

        private void value_calculation_handler(int a, int b)
        {
            richTextBox.Clear();

            int n = a - b;
            double res = 1;
            if (n < 0)
            {
                MessageBox.Show("Vui lòng nhập A lớn hơn B");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            string tmp = string.Format("(A-B)! = {0}\n", res);
            richTextBox.AppendText(tmp);

            res = 0;
            for (int i = 1; i <= b; i++)
            {
                res += Math.Pow(a, i);
            }
            tmp = string.Format("S = {0}", res);
            richTextBox.AppendText(tmp);
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            // valid

            if (string.IsNullOrEmpty(inputATxt.Text) || string.IsNullOrEmpty(inputBTxt.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!");
                return;
            }

            int num1 = 0, num2 = 0;
            bool valid = Int32.TryParse(inputATxt.Text.Trim(), out num1) && Int32.TryParse(inputBTxt.Text.Trim(), out num2);

            if (!valid)
            {
                MessageBox.Show("Vui lòng nhập 2 số!");
                return;
            }

            // handle

            if (comboBox.Text == "Bảng cửu chương")
            {
                multiplication_table_handler(num2 - num1);
            }
            else if (comboBox.Text == "Tính toán giá trị")
            {
                value_calculation_handler(num1, num2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 tuỳ chọn");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputATxt.Clear();
            inputBTxt.Clear();
            richTextBox.Clear();
            comboBox.SelectedItem = null;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
