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
            /*
             * foreach (object item in listBox1.SelectedItems)
            {
            student.Subjects.Add(item.ToString());
            }
            */



            // Once student is allocated
            StudentDashboardForm studentDashboardForm = new StudentDashboardForm();
            this.Hide();
            studentDashboardForm.Show();


        }

        private void displaySubjects()
        {
            /*
         for subject in subjects 
        listBox1.Items.Add(Subject);
         
        */


        }
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
