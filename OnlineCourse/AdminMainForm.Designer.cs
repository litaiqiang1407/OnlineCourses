namespace OnlineCourse
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            panel1 = new Panel();
            closeApp = new PictureBox();
            panel2 = new Panel();
            btnAboutUs = new Button();
            btnHelp = new Button();
            btnCourses = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            progressBar = new CircularProgressBar.CircularProgressBar();
            panelChildForm = new Panel();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panelChildFormMain = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            nameHome = new Label();
            logoHome = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeApp).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelChildFormMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoHome).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(closeApp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 40);
            panel1.TabIndex = 1;
            // 
            // closeApp
            // 
            closeApp.Image = (Image)resources.GetObject("closeApp.Image");
            closeApp.Location = new Point(1360, 0);
            closeApp.Margin = new Padding(0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(40, 40);
            closeApp.SizeMode = PictureBoxSizeMode.Zoom;
            closeApp.TabIndex = 0;
            closeApp.TabStop = false;
            closeApp.Click += closeApp_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(btnAboutUs);
            panel2.Controls.Add(btnHelp);
            panel2.Controls.Add(btnCourses);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 660);
            panel2.TabIndex = 2;
            // 
            // btnAboutUs
            // 
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 92, 92);
            btnAboutUs.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 92, 92);
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAboutUs.ForeColor = Color.FromArgb(67, 179, 217);
            btnAboutUs.Location = new Point(0, 420);
            btnAboutUs.Margin = new Padding(0);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Padding = new Padding(30, 0, 0, 0);
            btnAboutUs.Size = new Size(250, 50);
            btnAboutUs.TabIndex = 4;
            btnAboutUs.Text = "About Us";
            btnAboutUs.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 92, 92);
            btnHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 92, 92);
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHelp.ForeColor = Color.FromArgb(67, 179, 217);
            btnHelp.Location = new Point(0, 370);
            btnHelp.Margin = new Padding(0);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(30, 0, 0, 0);
            btnHelp.Size = new Size(250, 50);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 92, 92);
            btnCourses.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 92, 92);
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourses.ForeColor = Color.FromArgb(67, 179, 217);
            btnCourses.Location = new Point(0, 320);
            btnCourses.Margin = new Padding(0);
            btnCourses.Name = "btnCourses";
            btnCourses.Padding = new Padding(30, 0, 0, 0);
            btnCourses.Size = new Size(250, 50);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Courses";
            btnCourses.TextAlign = ContentAlignment.MiddleLeft;
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnHome
            // 
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 92, 92);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 92, 92);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(67, 179, 217);
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 270);
            btnHome.Margin = new Padding(0, 20, 0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(250, 50);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(progressBar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 250);
            panel3.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            progressBar.AnimationSpeed = 500;
            progressBar.BackColor = Color.Transparent;
            progressBar.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            progressBar.ForeColor = Color.FromArgb(64, 64, 64);
            progressBar.InnerColor = Color.FromArgb(18, 18, 18);
            progressBar.InnerMargin = 2;
            progressBar.InnerWidth = -1;
            progressBar.Location = new Point(85, 85);
            progressBar.MarqueeAnimationSpeed = 2000;
            progressBar.Name = "progressBar";
            progressBar.OuterColor = Color.FromArgb(18, 18, 18);
            progressBar.OuterMargin = -25;
            progressBar.OuterWidth = 26;
            progressBar.ProgressColor = Color.FromArgb(67, 179, 217);
            progressBar.ProgressWidth = 10;
            progressBar.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            progressBar.Size = new Size(80, 80);
            progressBar.StartAngle = 270;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            progressBar.SubscriptText = "";
            progressBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            progressBar.SuperscriptText = "";
            progressBar.TabIndex = 2;
            progressBar.TextMargin = new Padding(8, 8, 0, 0);
            progressBar.Value = 68;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.White;
            panelChildForm.Controls.Add(label4);
            panelChildForm.Controls.Add(label2);
            panelChildForm.Controls.Add(label3);
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Controls.Add(panelChildFormMain);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 40);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1150, 660);
            panelChildForm.TabIndex = 3;

            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(500, 330);
            label4.Name = "label4";
            label4.Size = new Size(450, 60);
            label4.TabIndex = 8;
            label4.Text = "Skills for your present  and your future.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(67, 179, 217);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 60);
            label2.Name = "label2";
            label2.Size = new Size(1150, 40);
            label2.TabIndex = 7;
            label2.Text = "TaiKun - Online Courses - CuongLT <3";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(500, 280);
            label3.Name = "label3";
            label3.Size = new Size(400, 60);
            label3.TabIndex = 6;
            label3.Text = "Learn without limits";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(150, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 500);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panelChildFormMain
            // 
            panelChildFormMain.BackColor = Color.White;
            panelChildFormMain.Controls.Add(label1);
            panelChildFormMain.Controls.Add(pictureBox1);
            panelChildFormMain.Controls.Add(nameHome);
            panelChildFormMain.Controls.Add(logoHome);
            panelChildFormMain.Dock = DockStyle.Top;
            panelChildFormMain.Location = new Point(0, 0);
            panelChildFormMain.Name = "panelChildFormMain";
            panelChildFormMain.Size = new Size(1150, 60);
            panelChildFormMain.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 179, 217);
            label1.Location = new Point(1038, 5);
            label1.Margin = new Padding(0, 0, 40, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 50);
            label1.TabIndex = 3;
            label1.Text = "Admin";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(985, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // nameHome
            // 
            nameHome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameHome.ForeColor = Color.FromArgb(67, 179, 217);
            nameHome.Location = new Point(90, 5);
            nameHome.Margin = new Padding(0);
            nameHome.Name = "nameHome";
            nameHome.Size = new Size(129, 50);
            nameHome.TabIndex = 1;
            nameHome.Text = "TaiKun";
            nameHome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logoHome
            // 
            logoHome.Image = (Image)resources.GetObject("logoHome.Image");
            logoHome.Location = new Point(40, 5);
            logoHome.Margin = new Padding(40, 0, 0, 0);
            logoHome.Name = "logoHome";
            logoHome.Size = new Size(50, 50);
            logoHome.SizeMode = PictureBoxSizeMode.Zoom;
            logoHome.TabIndex = 0;
            logoHome.TabStop = false;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 700);
            Controls.Add(panelChildForm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeApp).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelChildFormMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox closeApp;
        private Panel panel2;
        private Button btnAboutUs;
        private Button btnHelp;
        private Button btnCourses;
        private Button btnHome;
        private Panel panel3;
        private CircularProgressBar.CircularProgressBar progressBar;
        private Panel panelChildForm;
        private Label label4;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panelChildFormMain;
        private Label nameHome;
        private PictureBox logoHome;
        private Label label1;
        private PictureBox pictureBox1;
    }
}