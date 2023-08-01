using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourse
{
    // A class that inherits from the Form class - OOP: Inheritance
    public partial class LogInForm : Form
    {
        // A constructor that initializes the form components
        public LogInForm()
        {
            InitializeComponent();
            errorEmail.Visible = false;
            errorPassword.Visible = false;
        }

        // An event handler method for the close app button click event - EDP: Reactive
        private void closeApp_Click(object sender, EventArgs e)
        {
            // Show a message box asking the user to confirm exit
            DialogResult closeMessage = MessageBox.Show("Do you want to exit?", "Exit",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // If the user chooses yes, close the form
            if (closeMessage == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // An event handler method for the sign up label click event
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            // Create an object of the SignUpForm class
            SignUpForm signUpForm = new SignUpForm();
            // Show the sign up form
            signUpForm.Show();
        }

        private void inputEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valueEmail = inputEmail.Text;
                if (!IsValidEmail(valueEmail))
                {
                    errorEmail.Visible = true;
                    inputEmail.Focus();
                }
                else
                {
                    errorEmail.Visible = false;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression for basic email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void inputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int lenPassword = inputPassword.TextLength;
                if (lenPassword < 8)
                {
                    errorPassword.Visible = true;
                    inputPassword.Focus();
                }
                else
                {
                    errorPassword.Visible = false;
                    btnLogIn_Click(sender, e);
                }
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
    }
}

