namespace OnlineCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar.Value = 0; // Initialize progressBar
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1; // Increase progressBar value
            if (progressBar.Value == 100)
            {
                // When progressBar value is 100 then timer disenable and display MainForm
                timerProgressBar.Enabled = false;
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}