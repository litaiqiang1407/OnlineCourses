namespace OnlineCourse
{
    partial class ChoiceForm
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
            button1 = new Button();
            panel1 = new Panel();
            btnUser = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 18, 18);
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(300, 150);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 100);
            panel1.TabIndex = 1;
            // 
            // btnUser
            // 
            btnUser.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            btnUser.FlatAppearance.BorderSize = 2;
            btnUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 92, 92);
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 92, 92);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.FromArgb(67, 179, 217);
            btnUser.Location = new Point(141, 60);
            btnUser.Margin = new Padding(3, 3, 30, 3);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(100, 30);
            btnUser.TabIndex = 2;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            btnAdmin.FlatAppearance.BorderSize = 2;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 92, 92);
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 92, 92);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.FromArgb(67, 179, 217);
            btnAdmin.Location = new Point(19, 60);
            btnAdmin.Margin = new Padding(30, 3, 3, 3);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(100, 30);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 179, 217);
            label1.Location = new Point(83, 10);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 0;
            label1.Text = "You are?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 150);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChoiceForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button btnUser;
        private Button btnAdmin;
    }
}