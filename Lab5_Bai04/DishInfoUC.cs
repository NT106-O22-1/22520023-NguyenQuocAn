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
    public partial class DishInfoUC : UserControl
    {
        public DishInfoUC()
        {
            InitializeComponent();
        }
        public void Settenmonan(string s)
        {
            nameLb.Text = s;
        }
        public void Setgiamonan(string s)
        {
            costLb.Text = s;
        }
        public void Setdiachi(string s)
        {
            addressLb.Text = s;
        }
        public void Setnguoidonggop(string s)
        {
            contributeLb.Text = s;
        }
        public void SetPictureBox(PictureBox picturebox)
        {
            if (picturebox.Image != null)
            {
                pictureBox.Image = (Image)picturebox.Image.Clone();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Visible = true;
            }
        }
    }
}
