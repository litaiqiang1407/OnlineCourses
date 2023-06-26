namespace OnlineCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value == 100)
            {
                timerProgressBar.Enabled = false;
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}