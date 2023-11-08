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
    public partial class JoinSubjectForm : Form
    {
        public JoinSubjectForm()
        {
            InitializeComponent();
        }

        // Join Button is pressed (join subject)
        private void button1_Click(object sender, EventArgs e)
        {
            // Allocate student to subject



            // Once student is allocated
            StudentDashboardForm studentDashboardForm = new StudentDashboardForm();
            this.Hide();
            studentDashboardForm.Show();


        }
    }
}
