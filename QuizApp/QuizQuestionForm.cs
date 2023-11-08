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
            checkBox1.Text = "OptionA";
            checkBox2.Text = "OptionB";
            checkBox3.Text = "OptionC";
            checkBox4.Text = "OptionD";
        }
   
        // Next Button is pressed
        private void button2_Click(object sender, EventArgs e)
        {
            // Reset Option A, B, C, D text fields with data from next question.
            // Hide next button when at last question
            if(checkBox1.Checked.Equals("Answer")) {
                // Add Mark
            }

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
