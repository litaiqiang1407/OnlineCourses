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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            DialogResult closeMessage = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (closeMessage == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void inputEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (inputEmail.Text == "" && inputPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputEmail.Focus();
            }
            else if (inputEmail.Text == "")
            {
                MessageBox.Show("Please Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputEmail.Focus();

            }
            else if (inputPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputPassword.Focus();
            }
            else
            {
                ChoiceForm choiceForm = new ChoiceForm();
                choiceForm.Show();
            }

        }
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();

        }
    }
}
