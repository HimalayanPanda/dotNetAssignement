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


        /*
         private void ListAvailableQuizzesForStudent(Student student, List<Quiz> availableQuizzes)
        {
            listBox1.Items.Clear();

            foreach (string enrolledSubject in student.EnrolledSubjects)
            {
                foreach (Quiz quiz in availableQuizzes)
                {
                    if (quiz.Subject == enrolledSubject)
                    {
                        listBox1.Items.Add(quiz.Name);
                    }
                }
    }
         


        */


        // List box with available quizzes to take
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List all available Quizzes for student from enrolled subjects

        }

        // Take Quiz Button is pressed for selected quiz
        private void button1_Click(object sender, EventArgs e)
        {
            // Start quiz session for quiz 
            string selectedQuizName = listBox1.SelectedItem.ToString();






            QuizQuestionForm quizQuestionForm = new QuizQuestionForm();
            this.Hide();
            quizQuestionForm.Show();

        }
    }
}
