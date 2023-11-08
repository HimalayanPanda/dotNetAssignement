using System.ComponentModel.DataAnnotations;

namespace QuizApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // LOGIN BUTTON IS PRESSED
        private void button1_Click(object sender, EventArgs e)
        {

            string email = textBox1.Text;
            string password = textBox2.Text;

            // Check if user exists and user type 

            // if student open student dashboard 
            
            // Testing purposes*****
            StudentDashboardForm studentDashboardForm = new StudentDashboardForm();
            this.Hide();
            studentDashboardForm.Show();


            // if teacher open teacher dashboard


            // if admin open admin dashboard


            // if user does not exist show message


        }

        // Register Button Clicked
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();



        }
        
    }
}