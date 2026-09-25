using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace StudentManagementForm
{
    public partial class UserForm : Form
    {
        private string loggedInUsername;


        public UserForm(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Form1 signInForm = new Form1();
            signInForm.Show();
            this.Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome, {loggedInUsername}!");
            lblRole.Text = "Role: Student";

            // Load the logged-in student's data
            LoadStudentInfo(loggedInUsername);

            // Load fees dynamically based on the logged-in username
            LoadFees(loggedInUsername);

            // Load enrolled subjects dynamically based on the logged-in username
            LoadEnrolledSubjects(loggedInUsername);
        }

        private void LoadFees(string username)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-PH");
            string studentSubjectsFilePath = "student-subject.txt";
            string feesFilePath = "fees.txt";

            decimal totalFees = 0;
            decimal feesPaid = 0;

            // Calculate total fees from student-subject.txt
            if (File.Exists(studentSubjectsFilePath))
            {
                var lines = File.ReadAllLines(studentSubjectsFilePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length >= 4 && data[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        if (decimal.TryParse(data[3].Trim(), out decimal subjectFee))
                        {
                            totalFees += subjectFee;
                        }
                    }
                }
            }

            // Calculate fees paid from fees.txt
            if (File.Exists(feesFilePath))
            {
                var lines = File.ReadAllLines(feesFilePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length >= 2 && data[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        if (decimal.TryParse(data[1].Trim(), out decimal paidAmount))
                        {
                            feesPaid += paidAmount;
                        }
                    }
                }
            }

            // Update labels
            labelTotalFees.Text = $"₱{totalFees:N2}";
            labelFeesPaid.Text = $"₱{feesPaid:N2}";
            labelOutstandingBalance.Text = $"₱{(totalFees - feesPaid):N2}";
        }


        private void LoadStudentInfo(string username)
        {
            string studentsFilePath = "students.txt";

            if (File.Exists(studentsFilePath))
            {
                var lines = File.ReadAllLines(studentsFilePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    // Clean and extract data
                    string studentName = data[0].Replace("Name:", "").Trim(); 
                    string age = data[1].Replace("Age:", "").Trim();         
                    string subjects = data[2].Replace("Subjects:", "").Trim(); 

                    if (studentName.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        // Update labels with parsed information
                        labelNameStudent.Text = $"{studentName}";
                        labelAgeStudent.Text = $"{age}";
                        labelSubjectsStudent.Text = $"{subjects}";
                        return; // Exit the method once a match is found
                    }
                }

                // If no match found
                MessageBox.Show("Student information not found in students.txt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The file 'students.txt' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEnrolledSubjects(string username)
        {
            string filePath = "student-subject.txt";

            if (File.Exists(filePath))
            {
                listBoxSubjectsEnrolled.Items.Clear();
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length >= 4 && data[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        listBoxSubjectsEnrolled.Items.Add($"{data[1].Trim()}: {data[2].Trim()}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No enrolled subjects found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabPageStudents_Click(object sender, EventArgs e)
        {

        }

        private void labelNameStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
