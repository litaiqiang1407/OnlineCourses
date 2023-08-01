using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourse
{
    // A class that inherits from the Form class
    public partial class MainForm : Form
    {
        // A constructor that initializes the form components
        public MainForm()
        {
            InitializeComponent();
            // Set the background color of the home button
            btnHome.BackColor = Color.FromArgb(92, 92, 92);
        }

        // An event handler method for the close app button click event
        private void closeApp_Click(object sender, EventArgs e)
        {
            // Show a message box asking the user to confirm exit
            DialogResult closeMessage = MessageBox.Show("Do you want to exit?", "Exit", 
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // If the user chooses yes, close the application
            if (closeMessage == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // An event handler method for the log in button click event
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Create an object of the LogInForm class
            LogInForm logInForm = new LogInForm();
            // Show the log in form
            logInForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void logoHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void nameHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
            btnHome.BackColor = Color.FromArgb(92, 92, 92);
            btnCourses.BackColor = Color.FromArgb(18, 18, 18);
            btnHelp.BackColor = Color.FromArgb(18, 18, 18);
            btnAboutUs.BackColor = Color.FromArgb(18, 18, 18);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            openChildForm(new CoursesForm());
            btnCourses.BackColor = Color.FromArgb(92, 92, 92);
            btnHome.BackColor = Color.FromArgb(18, 18, 18);
            btnHelp.BackColor = Color.FromArgb(18, 18, 18);
            btnAboutUs.BackColor = Color.FromArgb(18, 18, 18);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new HelpForm());
            btnHelp.BackColor = Color.FromArgb(92, 92, 92);
            btnCourses.BackColor = Color.FromArgb(18, 18, 18);
            btnHome.BackColor = Color.FromArgb(18, 18, 18);
            btnAboutUs.BackColor = Color.FromArgb(18, 18, 18);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutUsForm());
            btnAboutUs.BackColor = Color.FromArgb(92, 92, 92);
            btnCourses.BackColor = Color.FromArgb(18, 18, 18);
            btnHelp.BackColor = Color.FromArgb(18, 18, 18);
            btnHome.BackColor = Color.FromArgb(18, 18, 18);
        }
    }
}

