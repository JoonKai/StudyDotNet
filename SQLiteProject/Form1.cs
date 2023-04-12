using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteProject
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sqlconn;
        private SQLiteCommand sqlcmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;
        private string dbName = "MyDB.db";
        private string path = @"URI=file:" + Application.StartupPath + "\\MyDB.db";


        public Form1()
        {
            InitializeComponent();
            CreateDB();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void CreateDB()
        {
            if (!System.IO.File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + dbName))
                {
                    sqlite.Open();
                    string sql = "create table Vendor(" +
                        "ID INTEGER," +
                        "StudentID TEXT," +
                        "CourseCode TEXT," +
                        "Firstname TEXT," +
                        "Surname TEXT," +
                        "AddMaths INTEGER," +
                        "Maths INTEGER," +
                        "Business INTEGER," +
                        "Biology INTEGER," +
                        "Chemistry INTEGER," +
                        "Computing INTEGER," +
                        "English INTEGER," +
                        "Physics INTEGER," +
                        "Total INTEGER," +
                        "Average INTEGER," +
                        "Ranking TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("데이터베이스 생성 불가");
                return;
            }
        }
        private void SetConnection()
        {
            if (System.IO.File.Exists(dbName))
            {
                sqlconn = new SQLiteConnection("Data Source = C:\\Users\\thstj\\Source\\Repos\\JoonKai\\StudyDotNet\\SQLiteProject\\bin\\Debug\\MyDB.db");
            }
            else
            {
                sqlconn = new SQLiteConnection();
            }
            
        }
        private void ExcuteQuery(string StudentIDq)
        {
            SetConnection();
            sqlconn.Open();
            sqlcmd = sqlconn.CreateCommand();
            sqlcmd.CommandText = StudentIDq;
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Dispose();
            sqlconn.Close();
        }
        private void LoadData()
        {
            SetConnection();
            sqlconn.Open();

            sqlcmd = sqlconn.CreateCommand();
            string CommandText = "select * from Vendor";
            DB = new SQLiteDataAdapter(CommandText, sqlconn);
            DS.Reset();
            DB.Fill(DS);
            sqlDT = DS.Tables[0];
            dataGridView1.DataSource = sqlDT;
            sqlconn.Close();
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Student Database", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void ClearAllText(Control con)
        {
            foreach(Control c in con.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllText(c);
                }
            }
        }
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            CourseCode_cmb.Text = "";
            Gender_cmb.Text = "";
            transcript_rt.Text = "";
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);

            if((asciiCode != 8))
            {
                if((asciiCode >=48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("숫자만 입력하세요", "Error: 숫자만~~~!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled= true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CourseCode_cmb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            AddMaths_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Maths_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Business_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Biology_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Chemistry_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Computing_txt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            English_txt.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            Physics_txt.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            TotalScore_txt.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            Average_txt.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Ranking_txt.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void StudentResult_btn_Click(object sender, EventArgs e)
        {
            transcript_rt.AppendText("Student ID:\t\t\t\t" + StudentID_txt.Text + "\n");
            transcript_rt.AppendText("Name:\t\t\t\t" + FirstName_txt.Text +" "+SurName_txt.Text+ "\n");
            transcript_rt.AppendText("Course Code:\t\t\t\t" + CourseCode_cmb.Text + "\n");
            transcript_rt.AppendText("Add Maths:\t\t\t\t" + AddMaths_txt.Text + "\n");
            transcript_rt.AppendText("Maths:\t\t\t\t" + Maths_txt.Text + "\n");
            transcript_rt.AppendText("Business:\t\t\t\t" + Business_txt.Text + "\n");
            transcript_rt.AppendText("Biology:\t\t\t\t" + Biology_txt.Text + "\n");
            transcript_rt.AppendText("Chemistry:\t\t\t\t" + Chemistry_txt.Text + "\n");
            transcript_rt.AppendText("Computing:\t\t\t\t" + Computing_txt.Text + "\n");
            transcript_rt.AppendText("English:\t\t\t\t" + English_txt.Text + "\n");
            transcript_rt.AppendText("Physics:\t\t\t\t" + Physics_txt.Text + "\n");
            transcript_rt.AppendText("Total Score:\t\t\t\t" + TotalScore_txt.Text + "\n");
            transcript_rt.AppendText("Average:\t\t\t\t" + Average_txt.Text + "\n");
            transcript_rt.AppendText("Ranking:\t\t\t\t" + Ranking_txt.Text + "\n");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string studentIDq = "insert into Vendor (StudentID, CourseCode, Firstname, Surname,AddMaths, Maths, Business, Biology, Chemistry, Computing,English, Physics, Total, Average, Ranking)values('"+StudentID_txt.Text+"','"+ CourseCode_cmb.Text + "','" + FirstName_txt.Text + "','" + SurName_txt.Text + "','" + AddMaths_txt.Text + "','" + Maths_txt.Text + "','" + Business_txt.Text + "','" + Biology_txt.Text + "','" + Chemistry_txt.Text + "','" + Computing_txt.Text + "','" + English_txt.Text + "','" + Physics_txt.Text + "','" + TotalScore_txt.Text + "','" + Average_txt.Text + "','" + Ranking_txt.Text +"')";
            ExcuteQuery(studentIDq);
            LoadData();
        }
    }
}
