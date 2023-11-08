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
    public partial class ViewUsersForm : Form
    {
        public ViewUsersForm()
        {
            InitializeComponent();
        }
        // Table with all users 
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Populate table with users from database.
        }
    }
}
