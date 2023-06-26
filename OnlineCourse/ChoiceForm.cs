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
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        // If you are an Admin, the AdminMainForm will display.
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
        }


        // If you are an User, the UserMainForm will display.
        private void btnUser_Click(object sender, EventArgs e)
        {
            UserMainForm userMainForm = new UserMainForm();
            userMainForm.Show();
        }
    }
}
