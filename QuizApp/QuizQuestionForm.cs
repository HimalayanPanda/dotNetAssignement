using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizQuestionForm : Form
    {
        public QuizQuestionForm()
        {
            InitializeComponent();
        }

        // OPTION A is Selected
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        // OPTION B is Selected
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        // OPTION C IS SELECTED
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        // OPTION D IS SELECTED
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Next Button is pressed
        private void button2_Click(object sender, EventArgs e)
        {
            // Reset Option A, B, C, D text fields with data from next question.
            // Hide next button when at last question
        }

        // Submit Quiz Button is pressed 
        private void button1_Click(object sender, EventArgs e)
        {
            // Submit quiz 

            StudentDashboardForm studentDashboardForm = new StudentDashboardForm();
            this.Hide();
            studentDashboardForm.Show();
        }
    }
}
