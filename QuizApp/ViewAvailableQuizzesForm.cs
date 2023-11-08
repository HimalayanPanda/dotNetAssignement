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
    public partial class ViewAvailableQuizzesForm : Form
    {
        public ViewAvailableQuizzesForm()
        {
            InitializeComponent();
        }

        // List box with available quizzes to take
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List all available Quizzes for student from enrolled subjects
        }

        // Take Quiz Button is pressed for selected quiz
        private void button1_Click(object sender, EventArgs e)
        {
            // Start quiz session for quiz 

            QuizQuestionForm quizQuestionForm = new QuizQuestionForm();
            this.Hide();
            quizQuestionForm.Show();

        }
    }
}
