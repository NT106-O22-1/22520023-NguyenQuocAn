using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
        }

        private void dirPathBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = pathTxb.Text;
            DialogResult drResult = folderBrowserDialog.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                pathTxb.Text = folderBrowserDialog.SelectedPath;
        }

        private void loadDirBtn_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            toolTip.ShowAlways = true;
            if (pathTxb.Text != "" && Directory.Exists(pathTxb.Text))
                LoadDirectory(pathTxb.Text);
            else
                MessageBox.Show("Hãy chọn đường dẫn!");
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeView.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            try
            {
                string[] Files = Directory.GetFiles(dir, "*.*");
                foreach (string file in Files)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode tds = td.Nodes.Add(fi.Name);
                    tds.Tag = fi.FullName;
                    tds.StateImageIndex = 1;
                }
            }
            catch 
            {
                MessageBox.Show("Không có quyền truy cập!");
            }
        }

        private void treeView_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode theNode = this.treeView.GetNodeAt(e.X, e.Y);
            if (theNode != null && theNode.Tag != null)
            {
                if (theNode.Tag.ToString() != this.toolTip.GetToolTip(this.treeView))
                    this.toolTip.SetToolTip(this.treeView, theNode.Tag.ToString());
            }
            else 
            {
                this.toolTip.SetToolTip(this.treeView, "");
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;

            // mở file
            // chưa hoàn thiện
        }
    }
}
