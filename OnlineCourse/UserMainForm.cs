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
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
            btnHome.BackColor = Color.FromArgb(92, 92, 92);
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
        private void closeApp_Click(object sender, EventArgs e)
        {
            DialogResult closeMessage = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (closeMessage == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult messageLogOut = MessageBox.Show("Do you wan to log out?", "Log out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messageLogOut == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}
