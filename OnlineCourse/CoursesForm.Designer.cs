namespace OnlineCourse
{
    partial class CoursesForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesForm));
            label2 = new Label();
            CoursesDGV = new DataGridView();
            label1 = new Label();
            inputSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            filterCategory = new ComboBox();
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)CoursesDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(67, 179, 217);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1150, 40);
            label2.TabIndex = 3;
            label2.Text = "TaiKun - Online Courses - CuongLT <3";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CoursesDGV
            // 
            CoursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CoursesDGV.BackgroundColor = Color.WhiteSmoke;
            CoursesDGV.BorderStyle = BorderStyle.None;
            CoursesDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(67, 179, 217);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(67, 179, 217);
            dataGridViewCellStyle1.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CoursesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CoursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesDGV.EnableHeadersVisualStyles = false;
            CoursesDGV.GridColor = Color.FromArgb(67, 179, 217);
            CoursesDGV.Location = new Point(50, 161);
            CoursesDGV.Margin = new Padding(50, 50, 50, 20);
            CoursesDGV.Name = "CoursesDGV";
            CoursesDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CoursesDGV.RowHeadersVisible = false;
            CoursesDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(134, 223, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            CoursesDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            CoursesDGV.RowTemplate.Height = 29;
            CoursesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CoursesDGV.Size = new Size(1050, 410);
            CoursesDGV.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 179, 217);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(50, 60);
            label1.Margin = new Padding(50, 20, 50, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 5;
            label1.Text = "Search";
            // 
            // inputSearch
            // 
            inputSearch.BackColor = Color.WhiteSmoke;
            inputSearch.Location = new Point(136, 62);
            inputSearch.Margin = new Padding(3, 50, 5, 3);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(750, 27);
            inputSearch.TabIndex = 0;
            inputSearch.KeyDown += inputSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            btnSearch.FlatAppearance.MouseDownBackColor = Color.White;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(894, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 27);
            btnSearch.TabIndex = 9;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.White;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(1000, 62);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 27);
            btnRefresh.TabIndex = 30;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // filterCategory
            // 
            filterCategory.BackColor = Color.WhiteSmoke;
            filterCategory.FlatStyle = FlatStyle.Flat;
            filterCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filterCategory.ForeColor = Color.FromArgb(67, 179, 217);
            filterCategory.FormattingEnabled = true;
            filterCategory.Items.AddRange(new object[] { "IT & Software", "Business", "Lifestyle", "Design", "Marketing" });
            filterCategory.Location = new Point(135, 111);
            filterCategory.Margin = new Padding(3, 15, 3, 3);
            filterCategory.Name = "filterCategory";
            filterCategory.Size = new Size(150, 28);
            filterCategory.TabIndex = 33;
            filterCategory.Text = "Category";
            filterCategory.SelectedIndexChanged += filterCategory_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(67, 179, 217);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(50, 110);
            label8.Margin = new Padding(50, 20, 50, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 30);
            label8.TabIndex = 32;
            label8.Text = "Filter";
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 600);
            Controls.Add(filterCategory);
            Controls.Add(label8);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(inputSearch);
            Controls.Add(label1);
            Controls.Add(CoursesDGV);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoursesForm";
            Load += CoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)CoursesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView CoursesDGV;
        private Label label1;
        private TextBox inputSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private ComboBox filterCategory;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}