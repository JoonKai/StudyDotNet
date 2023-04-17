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
            updateDataBinding();
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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void displayPosition()
        {
            positionLabel.Text = "Position: " + Convert.ToString(bindingSrc.Position + 1) +"/" + bindingSrc.Count.ToString();
        }
        private void updateDataBinding(SQLiteCommand cmd = null)
        {
            try
            {
                TextBox tb;
                foreach (Control c in groupBox1.Controls)
                {
                    if(c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                    dbCommand = "SELECT";

                    sql = "SELECT * FROM Vendor ORDER BY AutoID ASC;";
                    if(cmd == null)
                    {
                        command.CommandText = sql;
                    }
                    else
                    {
                        command = cmd;
                    }
                }
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet dataSt = new DataSet();
                adapter.Fill(dataSt, "Vendor");
                bindingSrc = new BindingSource();
                bindingSrc.DataSource = dataSt.Tables["Vendor"];

                //simple databinding

                AutoID_txt.DataBindings.Add("Text", bindingSrc, "AutoID");
                FirstName_txt.DataBindings.Add("Text", bindingSrc, "FirstName");
                LastName_txt.DataBindings.Add("Text", bindingSrc, "LastName");
                JobTitle_txt.DataBindings.Add("Text", bindingSrc, "JobTitle");
                Email_txt.DataBindings.Add("Text", bindingSrc, "Email");
                Phone_txt.DataBindings.Add("Text", bindingSrc, "Phone");

                dataGridView1.DataSource = bindingSrc;

                dataGridView1.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.Columns[0].Width = 70;//AutoID
                displayPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Binding Error: " + ex.Message.ToString(), "Error Message : son", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
