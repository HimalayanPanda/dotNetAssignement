using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Clicking Register Button
        {
            // Getting data from textbox
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if(!IsPasswordValid(password))
            {
                MessageBox.Show("Invalid password. Minimum length 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // If email does't exist, add student to database and go to student dashboard

            /*
            StudentDashboardForm studentDashboardForm = new StudentDashboardForm();
            this.Hide();
            studentDashboardForm.Show();
            */




        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // Define a regular expression pattern for a valid email address
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsPasswordValid(string password)
        {
            return password.Length >= 8;
        }

        // Login button is pressed to redirect to login page
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }

        // Check if email exists already in database (ADI)




    }
}
