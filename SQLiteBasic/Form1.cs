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

namespace SQLiteBasic
{
    public partial class Form1 : Form
    {
        //데이터 베이스 경로
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db"; 

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        // 데이터를 테이블에 보여준다.
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0),dr.GetString(1));
            }
        }
        //데이터 베이스 테이블을 만든다.
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using(var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20), id varchar(12))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database cannot crate");
                return;
            }
        }
        //데이터추가
        private void Insert_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO test(name,id) VALUES(@name, @id)";
            
                string NAME = name_txt.Text;
                string ID = id_txt.Text;

                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue ("@id", ID);

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Name";
                dataGridView1.Columns[1].Name = "Id";
                string[] row = new string[] { NAME, ID };
                dataGridView1.Rows.Add(row);
            
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }

        }
        //업데이트 데이터
        private void Update_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE test Set id=@Id where name = @Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", name_txt.Text);
                cmd.Parameters.AddWithValue("@Id", id_txt.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot update data");
                return;
            }
        }
        //데이터지우기
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM test where name = @Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", name_txt.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot delete data");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                name_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                id_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            }
        }
    }
}
