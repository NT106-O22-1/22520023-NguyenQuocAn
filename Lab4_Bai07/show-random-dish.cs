using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai07
{
    public partial class show_random_dish : Form
    {
        public show_random_dish(Control control)
        {
            InitializeComponent();
            flowLayoutPanel.Controls.Add(control);
        }
    }
}
