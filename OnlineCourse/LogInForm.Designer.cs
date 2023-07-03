namespace OnlineCourse
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            label1 = new Label();
            labelSignUp = new Label();
            btnLogIn = new Button();
            inputEmail = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            inputPassword = new MaskedTextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            closeApp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 620);
            label1.Name = "label1";
            label1.Size = new Size(220, 30);
            label1.TabIndex = 0;
            label1.Text = "Don't have an account?";
            // 
            // labelSignUp
            // 
            labelSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSignUp.ForeColor = Color.FromArgb(67, 179, 217);
            labelSignUp.Location = new Point(310, 620);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(90, 30);
            labelSignUp.TabIndex = 1;
            labelSignUp.Text = "Sign up";
            labelSignUp.Click += labelSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(67, 179, 217);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(100, 550);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(300, 40);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(100, 381);
            inputEmail.Margin = new Padding(3, 10, 3, 3);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(300, 27);
            inputEmail.TabIndex = 0;
            inputEmail.KeyDown += inputEmail_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 179, 217);
            label3.Location = new Point(100, 350);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 4;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(67, 179, 217);
            label4.Location = new Point(100, 421);
            label4.Margin = new Padding(3, 10, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 6;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(100, 452);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '●';
            inputPassword.Size = new Size(300, 27);
            inputPassword.TabIndex = 1;
            inputPassword.KeyDown += inputPassword_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(67, 179, 217);
            label5.Location = new Point(100, 482);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 7;
            label5.Text = "Forgot password?";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // closeApp
            // 
            closeApp.Image = (Image)resources.GetObject("closeApp.Image");
            closeApp.Location = new Point(460, 0);
            closeApp.Margin = new Padding(0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(40, 40);
            closeApp.SizeMode = PictureBoxSizeMode.Zoom;
            closeApp.TabIndex = 9;
            closeApp.TabStop = false;
            closeApp.Click += closeApp_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(500, 700);
            Controls.Add(closeApp);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(inputPassword);
            Controls.Add(label3);
            Controls.Add(inputEmail);
            Controls.Add(btnLogIn);
            Controls.Add(labelSignUp);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelSignUp;
        private Button btnLogIn;
        private MaskedTextBox inputEmail;
        private Label label3;
        private Label label4;
        private MaskedTextBox inputPassword;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox closeApp;
    }
}