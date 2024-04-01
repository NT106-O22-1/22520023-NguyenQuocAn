using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Lab2
{
    public partial class Lab02_Bai06 : Form
    {

        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        //SQLiteConnection con;
        //SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Lab02_Bai06()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM data";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                dataGridView.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table data(IDMA varchar(12) NOT NULL, TenMonAn varchar(30) NOT NULL, UNIQUE (IDMA))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Không thể tạo Database");
                return;
            }
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO data(IDMA, TenMonAn) VALUES(@IDMA, @TenMonAn)";

                string IDMA = idTxb.Text;
                string TenMonAn = nameTxb.Text;

                cmd.Parameters.AddWithValue("@IDMA", IDMA);
                cmd.Parameters.AddWithValue("@TenMonAn", TenMonAn);

                dataGridView.ColumnCount = 2;
                dataGridView.Columns[0].Name = "IDMA";
                dataGridView.Columns[1].Name = "TenMonAn";
                string[] row = new string[] { IDMA, TenMonAn };
                dataGridView.Rows.Add(row);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể Insert data");
                return;
            }
        }
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM data where IDMA=@IDMA";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@IDMA", idTxb.Text);

                cmd.ExecuteNonQuery();
                dataGridView.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể Delete data");
                return;
            }
        }

        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView.CurrentRow.Selected = true;
                idTxb.Text = dataGridView.Rows[e.RowIndex].Cells["IDMA"].FormattedValue.ToString();
                nameTxb.Text = dataGridView.Rows[e.RowIndex].Cells["TenMonAn"].FormattedValue.ToString();
            }
        }

        private void randBtn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string criteria = "SELECT TenMonAn FROM data";
            SQLiteCommand command = new SQLiteCommand(criteria, con);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();

            while (reader.Read())
            {
                list.Add(reader["TenMonAn"].ToString());
            }

            Random random = new Random();
            int r = random.Next(0, list.Count);
            resTxb.Text = list[r];
        }
    }
}
    