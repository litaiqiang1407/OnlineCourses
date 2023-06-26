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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
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
        private void inputFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
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
                btnSignUp_Click(sender, e);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (inputEmail.Text == "" && inputPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputFullName.Focus();
            }
            else if (inputFullName.Text == "")
            {
                MessageBox.Show("Please Enter Your Full name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputFullName.Focus();
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
                LogInForm logInForm = new LogInForm();
                logInForm.Show();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();

        }
    }
}
