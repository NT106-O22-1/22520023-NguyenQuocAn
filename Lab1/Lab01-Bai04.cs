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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void screen1Btn_Click(object sender, EventArgs e)
        {
            blankScr.Hide();
            screen2Uc.Hide();
            screen3Uc.Hide();
            screen1Uc.Show();
            screen1Uc.BringToFront();

            changeBtn.Enabled = true;
            screen2Btn.Enabled = false;
            screen3Btn.Enabled = false;
        }

        private void screen2Btn_Click(object sender, EventArgs e)
        {
            blankScr.Hide();
            screen1Uc.Hide();
            screen3Uc.Hide();
            screen2Uc.Show();
            screen2Uc.BringToFront();

            changeBtn.Enabled = true;
            screen1Btn.Enabled = false;
            screen3Btn.Enabled = false;
        }

        private void screen3Btn_Click(object sender, EventArgs e)
        {
            blankScr.Hide();
            screen1Uc.Hide();
            screen2Uc.Hide();
            screen3Uc.Show();
            screen3Uc.BringToFront();

            changeBtn.Enabled = true;
            screen1Btn.Enabled = false;
            screen2Btn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blankScr.Show();
            blankScr.BringToFront();
            screen1Uc.Hide();
            screen2Uc.Hide();
            screen3Uc.Hide();

            screen1Btn.Enabled = true;
            screen2Btn.Enabled = true;
            screen3Btn.Enabled = true;
        }
    }
}
