using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Loading in MySql reference
using MySql.Data.MySqlClient;
// Loading in data reader 
using System.IO;
using System.Runtime.InteropServices;
using System.Linq.Expressions;

namespace StudentApp
{
    public partial class MainForm : Form
    {
        // Providing the MySql credentials to connect 
        string connectionString = "Server=localhost; Database=project4db; User=root; Password=Mason101";
        // Setting the inital connection to null 
        MySqlConnection connection = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Open the database
            OpenDB();
            try
            {
                // Reading in external data from moodle upon opening application
                StreamReader data = new StreamReader("StudentData.txt");

                // Creating string variable and an array
                string studentInfo;
                string[] studentData;

                // Reading in each line from the external file until the end of the file
                while (data.EndOfStream == false)
                {
                    // Read in each line of the data and splitting the values 
                    studentInfo = data.ReadLine();
                    studentData = studentInfo.Split(',');

                    // Creating variables and setting them equal to the values within the array 
                    int studentId = int.Parse(studentData[0].Trim());
                    string studentName = studentData[1].Trim();
                    int studentScore = int.Parse(studentData[2].Trim());

                    // Using a string to turn studentId, studentName, and studentScore into a MySql statement
                    string sqlStatement = "insert into student (studentid, studentname, studentscore) values (" + studentId + ", '" + studentName + "', " + studentScore + ")";
                }
            }
            catch (Exception ex)
            {
                // Showing an error message if the file cannot be properly read in 
                MessageBox.Show("There is an error loading the file: " + ex.Message);
            }

            // Closing the DB connection
            CloseDB();
        }

        public void OpenDB()
        {
            try
            {
                // Establish a new DB connection 
                connection = new MySqlConnection(connectionString);
                // Open the connection 
                connection.Open();
            }
            catch
            {
                // Showing error message if DB can't connect
                MessageBox.Show("Error establishing connection");
            }
        }
        public void CloseDB()
        {
            // If an open database connection exists
            if (connection != null)
            {
                connection.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Opening the DB connection
            OpenDB();

            try
            {
                // Creating string and int variables and setting them equal to what is inserted in the text boxes
                string studentName = txtName.Text.Trim();
                string studentId = txtId.Text.Trim();
                int studentScore;
                int.TryParse(txtScore.Text, out studentScore);

                // Ensures the Name textbox is filled out
                if (studentName.Length == 0)
                {
                    MessageBox.Show("Please enter a valid name");
                    txtName.Clear();
                    txtName.Focus();
                    return;
                }

                // Ensures the studentID textbox is filled out
                if (studentId.Length == 0)
                {
                    MessageBox.Show("Please enter a valid ID");
                    txtId.Clear();
                    txtId.Focus();
                    return;
                }

                // Ensures the student score textbox is filled out
                if (studentScore == 0)
                {
                    MessageBox.Show("Please enter a valid score");
                    txtScore.Clear();
                    txtScore.Focus();
                    return;
                }

                // Using a string to turn studentId, studentName, and studentScore into a MySql statement
                string sqlStatement = "insert into student (studentid, studentname, studentscore) values (" + studentId + ", '" + studentName + "', " + studentScore + ")";
                // Creating a new MySqlCommand command
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                // Executing the sqlCommand made above
                sqlCommand.ExecuteNonQuery();
                // Showing message that the data was inserted properly
                MessageBox.Show("Added data to the student table");

                // Clearing all text boxes after data has been inserted 
                txtName.Clear();
                txtId.Clear();
                txtScore.Clear();
            }

            // Displaying an error message if the data cannot be inserted into the "Student" table
            catch (Exception ex)
            {
                MessageBox.Show("Error adding data into the 'Student' Table: " + ex.Message);
            }

            // Closing the connection 
            CloseDB();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Opening the DB connection
            OpenDB();

            try
            {
                // String the MySql code to be executed
                string sqlStatement = "select * from student";
                // Creating a MySqlCommand with parameters
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                // Executing the command
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                // Creating a new DataTable to store the data in memory as rows and columns
                DataTable dt = new DataTable();
                // Loading data into the DataTable
                dt.Load(reader);
                // Inserting the data into the grid view 
                grdData.DataSource = dt;
            }

            catch (Exception ex)
            {
                // Showing an error message if the data cannot be displayed
                MessageBox.Show("Data was not displayed successfully: " + ex.Message);
            }
            
            // Closing the DB connection 
            CloseDB();
        }

        private void dataTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opening the DB connection
            OpenDB();

            try
            {
                // String the MySql code to be executed
                string sqlStatement = "select * from student", grade; 
                // Creating a MySqlCommand with parameters
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                // Executing the command
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                // Creating a new DataTable to store the data in memory as rows and columns
                DataTable dt = new DataTable();
                // Loading data into the DataTable
                dt.Load(reader);
               
                // Formating the lables in the list box
                lstData.Items.Add(string.Format("{0,20}{1,20}{2,20}", "Student ID", "Student Name", "Student Grade"));

                // Looping through each item in the DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Creating string and int variables and setting them equal to what is inserted in the text boxes
                    int studentId = Convert.ToInt32(row["studentid"]);
                    string studentName = row["studentname"].ToString();
                    int studentScore = Convert.ToInt32(row["studentscore"]);

                    // Using an else if statement to determine letter grade based on score 
                    if (studentScore >= 90)
                    {
                        grade = "A";
                    }
                    else if (studentScore >= 80)
                    {
                        grade = "B";
                    }
                    else if (studentScore >= 70)
                    {
                        grade = "C";
                    }
                    else if (studentScore >= 60)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }
  
                    // Adding studentId, studentName, and grade variables to list box with formatting
                    lstData.Items.Add(string.Format("{0,20}{1,20}{2,20}", studentId, studentName, grade));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }

            // Closing the DB connection
            CloseDB();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating string variables and setting them equal to what is inserted in the text boxes
                string studentName = txtName.Text.Trim();

                // Creating int variables
                int studentId, studentScore;

                // Try Parsing the new int variables into the correct textboxes to turn them into variables
                int.TryParse(txtId.Text, out studentId);
                int.TryParse(txtScore.Text, out studentScore);

                // Writing the data stored to an external file and closing the application
                StreamWriter writer = new StreamWriter("studentgrades.txt", append: true);
                foreach(var item in lstData.Items)
                {
                    string value = item.ToString();
                    writer.WriteLine(value);
                }
                writer.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data could not be exported successfully: " + ex.Message);
            }
        }
    }
}


