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
    public partial class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            InitializeComponent();
        }


        // Join Subject Button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            JoinSubjectForm joinSubjectForm = new JoinSubjectForm();
            this.Hide();
            joinSubjectForm.Show();

        }

        // Take a quiz button is pressed in dashboard
        private void button2_Click(object sender, EventArgs e)
        {
            ViewAvailableQuizzesForm viewAvailableQuizzesForm = new ViewAvailableQuizzesForm();
            this.Hide();
            viewAvailableQuizzesForm.Show();

        }

        // Results button is pressed in dashboard
        private void button3_Click(object sender, EventArgs e)
        {
            ResultsViewForm resultsViewForm = new ResultsViewForm();
            this.Hide();
            resultsViewForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
