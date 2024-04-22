using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            Form client = new Client();
            client.Show();
        }

        private void button_Server_Click(object sender, EventArgs e)
        {
            Form server = new Server();
            server.Show();
        }
    }
}
