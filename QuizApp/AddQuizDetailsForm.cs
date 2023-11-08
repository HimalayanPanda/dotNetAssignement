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
    public partial class AddQuizDetailsForm : Form
    {
        public AddQuizDetailsForm()
        {
            InitializeComponent();
        }

        // Next button is pressed after adding quiz details
        private void button1_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            this.Hide();
            addQuestionForm.Show();
        }
    }
}
