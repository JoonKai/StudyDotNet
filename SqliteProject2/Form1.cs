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
        private static string conString = "Data Source=" + dbPath;



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
                using (var sqlite = new SQLiteConnection(conString))
                {
                    sqlite.Open();
                    string sql = "create table Vendor(" +
                        "AutoID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                        "FirstName TEXT NOT NULL," +
                        "LastName TEXT NOT NULL," +
                        "JobTitle TEXT NOT NULL," +
                        "Email TEXT NOT NULL," +
                        "Phone TEXT" +
                        ")";
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
                //MessageBox.Show("The connection is: " + connection.State.ToString());
            }
        }

        private void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
                //MessageBox.Show("The connection is: " + connection.State.ToString());
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

        private void moveFirst_btn_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveFirst();
            displayPosition();
        }

        private void movePreview_btn_Click(object sender, EventArgs e)
        {
            bindingSrc.MovePrevious();
            displayPosition();
        }

        private void moveNext_btn_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveNext();
            displayPosition();
        }

        private void moveLast_btn_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveLast();
            displayPosition();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                displayPosition();
            }
            catch (Exception)
            {

            }
        }

        private void refreshData_btn_Click(object sender, EventArgs e)
        {
            if (addNew_btn.Text.Equals("Cancel"))
            {
                return;
            }
            updateDataBinding();
        }

        private void addNew_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(addNew_btn.Text == "Add New")
                {
                    addNew_btn.Text = "Cancel";
                    positionLabel.Text = "Position: 0/0";
                    dataGridView1.ClearSelection();
                    dataGridView1.Enabled = false;
                }
                else
                {
                    addNew_btn.Text = "Add New";
                    updateDataBinding();
                    return;
                }
                TextBox txt;
                foreach (Control c in groupBox1.Controls)
                {
                    if(c.GetType() == typeof(TextBox))
                    {
                        txt = (TextBox)c;
                        txt.DataBindings.Clear();
                        txt.Text = "";
                        if (txt.Name.Equals("FirstName_txt"))
                        {
                            if(txt.CanFocus)
                            {
                                txt.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void addCmdParameters()
        {
            command.Parameters.Clear();
            command.CommandText = sql;

            command.Parameters.AddWithValue("FirstName", FirstName_txt.Text.Trim());
            command.Parameters.AddWithValue("LastName", LastName_txt.Text.Trim());
            command.Parameters.AddWithValue("JobTitle", JobTitle_txt.Text.Trim());
            command.Parameters.AddWithValue("Email", Email_txt.Text.Trim());
            command.Parameters.AddWithValue("Phone", Phone_txt.Text.Trim());

            if(dbCommand.ToUpper() == "UPDATE")
            {
                command.Parameters.AddWithValue("AutoID", AutoID_txt.Text.Trim());
            }
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            //addCmdParameters();
            if(string.IsNullOrEmpty(FirstName_txt.Text.Trim())||
                string.IsNullOrEmpty(LastName_txt.Text.Trim())||
                string.IsNullOrEmpty(JobTitle_txt.Text.Trim())||
                string.IsNullOrEmpty(Email_txt.Text.Trim())||
                string.IsNullOrEmpty(Phone_txt.Text.Trim()))
            {
                MessageBox.Show("Please fill in the required fields.", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            openConnection();
            try
            {
                if(addNew_btn.Text == "Add New")
                {
                    if(AutoID_txt.Text.Trim() == ""||
                        string.IsNullOrEmpty(AutoID_txt.Text.Trim()))
                    {
                        MessageBox.Show("Plese select an item.");
                        return;
                    }
                    if(MessageBox.Show("ID: " + AutoID_txt.Text.Trim()+
                        " -- Do you want to update the slected record?",
                        "Visual C# and SQLite (UPDATE)",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    dbCommand = "UPDATE";
                    sql = "UPDATE Vendor SET FirstName = @FirstName, LastName = @LastName, JobTitle = @JobTitle, ";
                    sql += "Email = @Email, Phone=@Phone Where AutoID = @AutoID";
                    addCmdParameters();
                }
                else if (addNew_btn.Text.Equals("Cancel"))
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to add a new Vendor record?) (Y/N)",
                        "Visual C# and SQLite(INSERT) ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == DialogResult.Yes)
                    {
                        dbCommand = "INSERT";
                        sql = "INSERT INTO Vendor(FirstName, LastName, JobTitle, Email, Phone)" +
                            "VALUES(@FirstName, @LastName, @JobTitle, @Email, @Phone)";

                        addCmdParameters();
                    }
                    else
                    {
                        return;
                    }
                }
                int executeResult = command.ExecuteNonQuery();
                if(executeResult == -1)
                {
                    MessageBox.Show("Data was not Saved", "Fail to save Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    MessageBox.Show("Your SQL " + dbCommand + "Query has been excuted succes");
                    updateDataBinding();
                    addNew_btn.Text = "Add New";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Save Data : ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (addNew_btn.Text == "Cancel")
            {
                return;
            }
            if(AutoID_txt.Text.Trim() ==""||
                string.IsNullOrEmpty(AutoID_txt.Text.Trim()))
            {
                MessageBox.Show("Please select an item from the list",
                    "Delete Data : ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            openConnection();
            try
            {
                dbCommand = "DELETE";
                sql = "DELETE FROM Vendor WHERE AutoID = @AutoID";

                command.Parameters.Clear();
                command.CommandText = sql;
                command.Parameters.AddWithValue("AutoID", AutoID_txt.Text.Trim());

                int executeResult = command.ExecuteNonQuery();
                if(executeResult == 1)
                {
                    updateDataBinding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if(addNew_btn.Text == "Cancel")
            {
                return;
            }

            openConnection();
            try
            {
                if(string.IsNullOrEmpty(keyword_txt.Text.Trim()))
                {
                    updateDataBinding();
                    return;
                }
                sql = "SELECT * FROM Vendor ";
                sql += "WHERE FirstName LIKE @Keyword2 ";
                sql += "OR LastName LIKE @Keyword2 ";
                sql += "OR JobTitle LIKE @Keyword2 ";
                sql += "OR Email = @Keyword1 ";
                sql += "OR Phone LIKE @Keyword2 ";
                sql += "ORDER BY AutoID ASC";

                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Clear();

                string keyword = string.Format("%{0}%", keyword_txt.Text);
                command.Parameters.AddWithValue("Keyword1", keyword_txt.Text);
                command.Parameters.AddWithValue("Keyword2", keyword);

                updateDataBinding(command);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message.ToString(),
                    "Error Message : ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
                keyword_txt.Focus();
            }
        }
    }
}
