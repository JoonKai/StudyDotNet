using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SqliteProject2
{
    public partial class Form1 : Form
    {
        private static string dbCommand = "";
        private static BindingSource bindingSrc;
        private static string dbPath = Application.StartupPath + "\\MyDB.db";
        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";



        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;
        private string dbName = "MyDB.db";
        public Form1()
        {
            InitializeComponent();
            CreateDB();
            this.AutoID_txt.Enabled = false;
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
                        "AutoID INTEGER UNIQUE NOT NULL," +
                        "FirstName TEXT NOT NULL," +
                        "LastName TEXT NOT NULL," +
                        "JobTitle TEXT NOT NULL," +
                        "Email TEXT NOT NULL," +
                        "Phone TEXT)";
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
        private void Form1_Load(object sender, EventArgs e)
        {
            //create open connection method
            openConnection();
            closeConnection();
        }

        private void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("The connection is: " + connection.State.ToString());
            }
        }

        private void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("The connection is: " + connection.State.ToString());
            }
        }
    }
}
