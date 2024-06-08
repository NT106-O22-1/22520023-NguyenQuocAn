using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Bai04
{
    public partial class show_random_dish : Form
    {
        private string inf = string.Empty;

        public show_random_dish(Control control, string dishInfo)
        {
            InitializeComponent();
            flowLayoutPanel.Controls.Add(control);
            inf = dishInfo;
        }

        private void inviteFriendsBtn_Click(object sender, EventArgs e)
        {
            Config config = ConfigManager.GetConfig();
            if (config.Username == null)
            {
                MessageBox.Show("Bạn cần cài đặt Email Server để sử dụng tính năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email_config email_Config = new email_config();
                email_Config.ShowDialog();
            }
            else
            {
                Control invitingDishes = flowLayoutPanel.Controls[0];
                Invite invite = new Invite(invitingDishes, inf);
                invite.ShowDialog();
            }
        }
    }
}
