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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        // Close App
        private void closeApp_Click(object sender, EventArgs e)
        {
            // Click on exit button, exit confirmation dialog will appear
            DialogResult closeMessage = MessageBox.Show("Do you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (closeMessage == DialogResult.Yes)
            {
                // Choose "Yes" --> Exit App
                Application.Exit();
            }
        }

        // Display child form
        private Form activeForm = null; // Set a value indicating that no form is active
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // It checks if there is already an active form in the panel. If yes, it closes the active form.
            }
            activeForm = childForm; // It assigns the child form to the activeForm variable, which keeps track of the current form in the panel.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm); // It adds the child form to the panel’s Controls collection                                              
            panelChildForm.Tag = childForm; // Sets its Tag property to the child form object.
            childForm.BringToFront(); // It brings the child form to the front of the panel and shows it.
            childForm.Show();
        }

        // Display HomeForm
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        // Display CoursesAdminForm
        private void btnCourses_Click(object sender, EventArgs e)
        {
            openChildForm(new CoursesAdminForm());

        }
    }
}
