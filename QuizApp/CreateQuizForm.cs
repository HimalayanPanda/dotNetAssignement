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
    public partial class CreateQuizForm : Form
    {
        public CreateQuizForm()
        {
            InitializeComponent();
        }

        // Create Quiz Subjects Avalilable
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display subjects available or created by teacher for which a quiz can be created.

        }

        // Select Subject button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            AddQuizDetailsForm addQuizDetailsForm = new AddQuizDetailsForm();
            this.Hide();
            addQuizDetailsForm.Show();

        }
    }
}
