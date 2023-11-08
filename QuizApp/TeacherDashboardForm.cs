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
    public partial class TeacherDashboardForm : Form
    {
        public TeacherDashboardForm()
        {
            InitializeComponent();
        }

        // Create Class button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            CreateSubjectForm createSubjectForm = new CreateSubjectForm();
            this.Hide();
            createSubjectForm.Show();

        }
        // Create  Quiz button is pressed in dashboard
        private void button2_Click(object sender, EventArgs e)
        {
            CreateQuizForm createQuizForm = new CreateQuizForm();
            this.Hide();
            createQuizForm.Show();
        }

        // Results button is pressed 
        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
