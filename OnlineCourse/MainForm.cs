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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            DialogResult closeMessage = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (closeMessage == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
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
       
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void logoHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void nameHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            openChildForm(new CoursesForm());
        }
    }
}
