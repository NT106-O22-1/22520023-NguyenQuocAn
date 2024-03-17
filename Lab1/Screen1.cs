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
    public partial class Screen1 : UserControl
    {
        public Screen1()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int gia_ve = 0;
            if (moviePickerCb.Text == "Đào, phở và piano" )
            {
                gia_ve = 45000;
            }
            else if (moviePickerCb.Text == "Gặp lại chị bầu")
            {
                gia_ve = 70000;
            }

            List<string> checkedValues = new List<string>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                checkedValues.Add(item.ToString());
            }

            int so_ve_vot = 0, so_ve_thuong = 0, so_ve_vip = 0;
            string picked = "";
            foreach (var item in checkedValues)
            {
                if (item == "A1" || item == "A5" || item == "C1" || item == "C5") 
                {
                    picked += item + ", ";
                    so_ve_vot++; 
                }
                else if (item == "B2" || item == "B3" || item == "B4") 
                {
                    picked += item + ", ";
                    so_ve_vip++; 
                }
                else 
                {
                    picked += item + ", ";
                    so_ve_thuong++;
                }
            }

            int res = (so_ve_vot * gia_ve/4) + (so_ve_thuong * gia_ve) + (so_ve_vip * gia_ve * 2);
            MessageBox.Show(string.Format(
                "Phòng chiếu: 1\n" +
                "Tên phim: {0}\n" +
                "Những ghế đã chọn là: {1}\n" +
                "Số tiền cần phải thanh toán: {2}\n",
                moviePickerCb.Text, picked, res));
        }
    }
}
