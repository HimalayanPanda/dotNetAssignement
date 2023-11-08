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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        // Add teacher button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            this.Hide();
            addTeacherForm.Show();


        }

        // Add student button is pressed 
        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            this.Hide();
            addStudentForm.Show();

        }

        // View users button is pressed
        private void button3_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsersForm = new ViewUsersForm();
            this.Hide();
            viewUsersForm.Show();

        }
    }
}
