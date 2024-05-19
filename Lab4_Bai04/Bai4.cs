using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai04
{
    public partial class Bai4 : Form
    {
        Form1 form1 = new Form1();
        Lab02_Bai05 form2 = new Lab02_Bai05();
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
        }

        private void fetchBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Dock = DockStyle.Fill;
        }
    }
}
