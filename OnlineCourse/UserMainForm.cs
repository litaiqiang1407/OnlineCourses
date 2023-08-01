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
    public partial class UserMainForm : Form
    {
        // A constructor that initializes the form components
        public UserMainForm()
        {
            InitializeComponent();
            btnHome.BackColor = Color.FromArgb(92, 92, 92);
        }

        // An event handler method for the log out button click event
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Show a message box asking the user to confirm log out
            DialogResult messageLogOut = MessageBox.Show("Do you wan to log out?", "Log out Confirmation", 
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // If the user chooses yes, create an object of the MainForm class and show it
            if (messageLogOut == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
       
        private void closeApp_Click(object sender, EventArgs e)
        {
            DialogResult closeMessage = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (closeMessage == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // A field that stores the reference to the active form
        private Form activeForm = null;
        // A method that opens a child form on the panel
        private void openChildForm(Form childForm)
        {
            // If there is an active form, close it
            if (activeForm != null)
            {
                activeForm.Close();
            }
            // Set the child form as the active form
            activeForm = childForm;
            // Set some properties of the child form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Add the child form to the panel's controls collection
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;           
            childForm.BringToFront(); // Bring the child form to the front
            childForm.Show(); // Show the child form
        }

        // An event handler method for the home button click event
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Call the openChildForm method with a new object of the HomeForm class
            openChildForm(new HomeForm());
            // Change the background color of the home button to indicate it is active
            btnHome.BackColor = Color.FromArgb(92, 92, 92);
            // Change the background color of the other buttons to indicate they are inactive
            btnCourses.BackColor = Color.FromArgb(18, 18, 18);
            btnHelp.BackColor = Color.FromArgb(18, 18, 18);
            btnAboutUs.BackColor = Color.FromArgb(18, 18, 18);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            openChildForm(new CoursesUserForm());
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

