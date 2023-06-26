namespace OnlineCourse
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            closeApp = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            inputEmail = new MaskedTextBox();
            label3 = new Label();
            inputFullName = new MaskedTextBox();
            btnSignUp = new Button();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            inputPassword = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)closeApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // closeApp
            // 
            closeApp.Image = (Image)resources.GetObject("closeApp.Image");
            closeApp.Location = new Point(460, 0);
            closeApp.Margin = new Padding(0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(40, 40);
            closeApp.SizeMode = PictureBoxSizeMode.Zoom;
            closeApp.TabIndex = 19;
            closeApp.TabStop = false;
            closeApp.Click += closeApp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(67, 179, 217);
            label4.Location = new Point(100, 398);
            label4.Margin = new Padding(3, 10, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 16;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(100, 429);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(300, 27);
            inputEmail.TabIndex = 1;
            inputEmail.KeyDown += inputEmail_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 179, 217);
            label3.Location = new Point(100, 320);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 15;
            label3.Text = "Full name";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputFullName
            // 
            inputFullName.Location = new Point(100, 358);
            inputFullName.Margin = new Padding(3, 10, 3, 3);
            inputFullName.Name = "inputFullName";
            inputFullName.Size = new Size(300, 27);
            inputFullName.TabIndex = 0;
            inputFullName.KeyDown += inputFullName_KeyDown;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(67, 179, 217);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(100, 559);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(300, 40);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(67, 179, 217);
            label2.Location = new Point(329, 620);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 13;
            label2.Text = "Log in";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 620);
            label1.Name = "label1";
            label1.Size = new Size(236, 30);
            label1.TabIndex = 11;
            label1.Text = "Already have an account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(67, 179, 217);
            label5.Location = new Point(100, 469);
            label5.Margin = new Padding(3, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 21;
            label5.Text = "Password";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(100, 500);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '●';
            inputPassword.Size = new Size(300, 27);
            inputPassword.TabIndex = 2;
            inputPassword.KeyDown += inputPassword_KeyDown;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(500, 700);
            Controls.Add(label5);
            Controls.Add(inputPassword);
            Controls.Add(closeApp);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(inputEmail);
            Controls.Add(label3);
            Controls.Add(inputFullName);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)closeApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox closeApp;
        private PictureBox pictureBox1;
        private Label label4;
        private MaskedTextBox inputEmail;
        private Label label3;
        private MaskedTextBox inputFullName;
        private Button btnSignUp;
        private Label label2;
        private Label label1;
        private Label label5;
        private MaskedTextBox inputPassword;
    }
}