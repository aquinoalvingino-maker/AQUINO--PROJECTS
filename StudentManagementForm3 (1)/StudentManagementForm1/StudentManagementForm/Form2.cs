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

namespace StudentManagementForm
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Form1 signInForm = new Form1();
            signInForm.Show();
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Form Successfully Loaded");
            lblRole.Text = "Role: Admin";

            // Populate the subjects ComboBox on form load
            PopulateSubjects();

            // Optionally select the first item by default
            if (comboBoxSubject.Items.Count > 0)
            {
                comboBoxSubject.SelectedIndex = 0; // Select the first item
            }

            // Populate the students ComboBox in Fees tab
            PopulateStudentNames();
        }

        private void PopulateStudentNames()
        {
            string filePath = "students.txt";

            // Clear existing items to avoid duplicates
            comboBoxStudentName.Items.Clear();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    // Extract and clean the student name
                    if (data.Length > 0)
                    {
                        string rawName = data[0].Trim();
                        string studentName = rawName.StartsWith("Name:")
                            ? rawName.Substring(5).Trim() // Remove "Name:" prefix
                            : rawName;

                        // Add the cleaned name to the combo box if not already present
                        if (!comboBoxStudentName.Items.Contains(studentName))
                        {
                            comboBoxStudentName.Items.Add(studentName);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The file 'students.txt' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PopulateSubjects()
        {
            string filePath = "subjects.txt";

            // Clear existing items to avoid duplicates
            comboBoxSubject.Items.Clear();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length > 0)
                    {
                        string subjectName = data[0].Trim(); // Extract subject name
                        if (!comboBoxSubject.Items.Contains(subjectName))
                        {
                            comboBoxSubject.Items.Add(subjectName);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The file 'subjects.txt' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            string studentName = textBoxStudentName.Text.Trim(); // Full name (e.g., "John Doe")
            DateTime birthdate = dateTimePickerBirthdate.Value;

            // Calculate the age automatically
            int age = DateTime.Now.Year - birthdate.Year;
            if (DateTime.Now.Date < birthdate.Date.AddYears(age)) age--;

            string subject = comboBoxSubject.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(studentName) && !string.IsNullOrEmpty(subject))
            {
                // Append the new student information to the students.txt file
                string studentFilePath = "students.txt";
                File.AppendAllText(studentFilePath, $"{studentName},{age},{subject}\n");

                // Add the subject, its description, and fee to student-subject.txt
                string subjectFilePath = "subjects.txt";
                string studentSubjectFilePath = "student-subject.txt";

                if (File.Exists(subjectFilePath))
                {
                    var subjectLines = File.ReadAllLines(subjectFilePath);
                    foreach (var line in subjectLines)
                    {
                        var data = line.Split(',');
                        if (data.Length >= 3 && data[0].Trim() == subject)
                        {
                            string subjectDescription = data[1].Trim();
                            string subjectFee = data[2].Trim();
                            File.AppendAllText(studentSubjectFilePath, $"{studentName},{subject},{subjectDescription},{subjectFee}\n");
                            break;
                        }
                    }
                }

                // Append the new student to users.txt
                string usersFilePath = "users.txt";
                string username = studentName.Trim(); // Use full name as username
                string password = username.Replace(" ", "").ToLower(); // Create a lowercase, no-space password
                File.AppendAllText(usersFilePath, $"{username},{password},Student\n");

                // Refresh the ComboBox or other UI elements
                PopulateStudentNames();

                MessageBox.Show("Student added successfully and added to users.txt.");
            }
            else
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearchStudent_Click(object sender, EventArgs e)
        {
            string searchName = textBoxStudentName.Text.ToLower();

            foreach (var item in listBoxStudents.Items)
            {
                if (item.ToString().ToLower().Contains(searchName))
                {
                    listBoxStudents.SelectedItem = item;
                    MessageBox.Show($"Found: {item}");
                    return;
                }
            }

            MessageBox.Show("Student not found.");
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem != null)
            {
                listBoxStudents.Items.Remove(listBoxStudents.SelectedItem);

                // Save updated list to storage
                var updatedList = listBoxStudents.Items.Cast<string>().ToList();
                File.WriteAllLines("students.txt", updatedList);

                MessageBox.Show("Student deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddSubject_Click(object sender, EventArgs e)
        {
            string subjectName = textBoxSubjectName.Text.Trim();
            string description = textBoxDescriptionSubject.Text.Trim();
            string fee = textBoxFeeSubject.Text.Trim();

            if (!string.IsNullOrEmpty(subjectName) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(fee))
            {
                // Add subject details to listBoxSubjects
                listBoxSubjects.Items.Add($"Subject: {subjectName}, Description: {description}, Fee: {fee}");

                // Save subject details to the file
                string filePath = "subjects.txt";
                File.AppendAllText(filePath, $"{subjectName},{description},{fee}\n");

                // Refresh the ComboBox for subjects
                PopulateSubjects();

                MessageBox.Show("Subject added successfully.");
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void ButtonShowStudents_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear(); // Clear the list before adding new entries

            string filePath = "students.txt";

            // Load students from storage
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length >= 3)
                    {
                        string studentName = data[0].Trim();
                        string age = data[1].Trim();
                        string subjects = string.Join(", ", data.Skip(2).Select(s => s.Trim()));

                        // Add formatted student information to the listBox
                        listBoxStudents.Items.Add($"Name: {studentName}, Age: {age}, Subjects: {subjects}");
                    }
                    else
                    {
                        // Handle malformed lines in the file
                        listBoxStudents.Items.Add($"Invalid Data: {line}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No students found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonShowSubjects_Click(object sender, EventArgs e)
        {
            listBoxSubjects.Items.Clear();

            // Load subjects from storage
            if (File.Exists("subjects.txt"))
            {
                var lines = File.ReadAllLines("subjects.txt");
                foreach (var line in lines)
                {
                    listBoxSubjects.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("No subjects found.");
            }
        }

        private void ButtonDeleteSubject_Click(object sender, EventArgs e)
        {
            if (listBoxSubjects.SelectedItem != null)
            {
                listBoxSubjects.Items.Remove(listBoxSubjects.SelectedItem);

                // Save updated list to storage
                var updatedList = listBoxSubjects.Items.Cast<string>().ToList();
                File.WriteAllLines("subjects.txt", updatedList);

                MessageBox.Show("Subject deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.");
            }
        }

        private void ButtonAddFee_Click(object sender, EventArgs e)
        {
            string studentName = comboBoxStudentName.SelectedItem?.ToString();
            string amount = textBoxAmountFees.Text;
            DateTime paymentDate = dateTimePickerPaymentDate.Value;

            if (!string.IsNullOrEmpty(studentName) && !string.IsNullOrEmpty(amount))
            {
                // Add formatted data to listBoxFees
                listBoxFees.Items.Add($"Student: {studentName}, Amount: {amount}, Date: {paymentDate.ToShortDateString()}");

                // Save to storage
                File.AppendAllText("fees.txt", $"{studentName},{amount},{paymentDate.ToShortDateString()}\n");

                MessageBox.Show("Fee added successfully.");
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void comboBoxStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
