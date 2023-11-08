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
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        // Add teacher button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            // Add teacher with value in field box
            
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            this.Hide();
            adminDashboardForm.Show();

        }
    }
}
