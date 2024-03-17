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
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listView.Items.Add(new ListViewItem(inputTb.Text));
            inputTb.Clear();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string[] meals = new string[listView.Items.Count];
            int i = 0;
            foreach (ListViewItem item in listView.Items)
            {
                meals[i] = item.Text;
                i++;
            }

            Random random = new Random();
            int r = random.Next(0, meals.Length);
            outputTb.Text = meals[r];
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputTb.Clear();
            listView.Clear();
            outputTb.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
