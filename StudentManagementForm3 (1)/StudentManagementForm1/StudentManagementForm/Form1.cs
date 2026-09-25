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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = LoginBtn;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text.Trim();
            string password = pwTxt.Text.Trim();

            try
            {
                var lines = File.ReadAllLines("users.txt");
                var user = lines.Select(line => line.Split(','))
                                .FirstOrDefault(data => data[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase) && data[1].Trim() == password);

                if (user != null)
                {
                    string role = user[2].Trim();

                    if (role == "Admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else if (role == "Student")
                    {
                        UserForm userForm = new UserForm(username); // Pass username
                        userForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
