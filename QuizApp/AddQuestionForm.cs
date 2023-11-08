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
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        // Add question to quiz
        private void button1_Click(object sender, EventArgs e)
        {
            // Add question to quiz with relevant fields and data

        }
        // Create quiz button is pressed
        private void button2_Click(object sender, EventArgs e)
        {
            // Create quiz with questions which were added
            TeacherDashboardForm teacherDashboardForm = new TeacherDashboardForm();
            this.Hide();
            teacherDashboardForm.Show();
        }
    }
}
