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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;

            if (Int32.TryParse(textBox1.Text.Trim(), out num1) && Int32.TryParse(textBox2.Text.Trim(), out num2))
            {
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }

            else
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ 2 số!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên!");
                    textBox3.Clear();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
