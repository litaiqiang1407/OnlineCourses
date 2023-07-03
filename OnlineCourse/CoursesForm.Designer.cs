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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesForm));
            label2 = new Label();
            CoursesDGV = new DataGridView();
            label1 = new Label();
            inputSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            filterCategory = new ComboBox();
            label8 = new Label();
            panelInforCourse = new Panel();
            btnEnroll = new Button();
            valueDescription = new Label();
            valuePrice = new Label();
            valueCategory = new Label();
            valueName = new Label();
            labelDescriptionText = new Label();
            labelPriceText = new Label();
            labelCategoryText = new Label();
            labelNameText = new Label();
            button2 = new Button();
            label3 = new Label();
            logoHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CoursesDGV).BeginInit();
            panelInforCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoHome).BeginInit();
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
            CoursesDGV.AllowUserToResizeColumns = false;
            CoursesDGV.AllowUserToResizeRows = false;
            CoursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CoursesDGV.BackgroundColor = Color.WhiteSmoke;
            CoursesDGV.BorderStyle = BorderStyle.None;
            CoursesDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(67, 179, 217);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(67, 179, 217);
            dataGridViewCellStyle3.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CoursesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CoursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesDGV.EnableHeadersVisualStyles = false;
            CoursesDGV.GridColor = Color.FromArgb(67, 179, 217);
            CoursesDGV.Location = new Point(50, 161);
            CoursesDGV.Margin = new Padding(50, 50, 50, 20);
            CoursesDGV.Name = "CoursesDGV";
            CoursesDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CoursesDGV.RowHeadersVisible = false;
            CoursesDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(134, 223, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            CoursesDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            CoursesDGV.RowTemplate.Height = 29;
            CoursesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CoursesDGV.Size = new Size(700, 410);
            CoursesDGV.TabIndex = 4;
            CoursesDGV.CellContentClick += CoursesDGV_CellContentClick;
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
            inputSearch.PlaceholderText = "Search for All";
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
            filterCategory.Text = "Categories";
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
            // panelInforCourse
            // 
            panelInforCourse.BackColor = Color.White;
            panelInforCourse.BackgroundImage = (Image)resources.GetObject("panelInforCourse.BackgroundImage");
            panelInforCourse.BackgroundImageLayout = ImageLayout.Center;
            panelInforCourse.Controls.Add(btnEnroll);
            panelInforCourse.Controls.Add(valueDescription);
            panelInforCourse.Controls.Add(valuePrice);
            panelInforCourse.Controls.Add(valueCategory);
            panelInforCourse.Controls.Add(valueName);
            panelInforCourse.Controls.Add(labelDescriptionText);
            panelInforCourse.Controls.Add(labelPriceText);
            panelInforCourse.Controls.Add(labelCategoryText);
            panelInforCourse.Controls.Add(labelNameText);
            panelInforCourse.Location = new Point(800, 225);
            panelInforCourse.Name = "panelInforCourse";
            panelInforCourse.Size = new Size(300, 300);
            panelInforCourse.TabIndex = 48;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(67, 179, 217);
            btnEnroll.BackgroundImageLayout = ImageLayout.Zoom;
            btnEnroll.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            btnEnroll.FlatAppearance.BorderSize = 2;
            btnEnroll.FlatAppearance.MouseDownBackColor = Color.FromArgb(134, 223, 255);
            btnEnroll.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 223, 255);
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEnroll.ForeColor = Color.White;
            btnEnroll.Location = new Point(1, 261);
            btnEnroll.Margin = new Padding(3, 20, 3, 3);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(298, 38);
            btnEnroll.TabIndex = 43;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // valueDescription
            // 
            valueDescription.BackColor = Color.Transparent;
            valueDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueDescription.ForeColor = Color.FromArgb(67, 179, 217);
            valueDescription.Location = new Point(123, 143);
            valueDescription.Margin = new Padding(10, 20, 10, 0);
            valueDescription.Name = "valueDescription";
            valueDescription.Size = new Size(167, 100);
            valueDescription.TabIndex = 7;
            // 
            // valuePrice
            // 
            valuePrice.BackColor = Color.Transparent;
            valuePrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valuePrice.ForeColor = Color.FromArgb(67, 179, 217);
            valuePrice.Location = new Point(123, 108);
            valuePrice.Margin = new Padding(10, 20, 10, 0);
            valuePrice.Name = "valuePrice";
            valuePrice.Size = new Size(167, 30);
            valuePrice.TabIndex = 6;
            // 
            // valueCategory
            // 
            valueCategory.BackColor = Color.Transparent;
            valueCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueCategory.ForeColor = Color.FromArgb(67, 179, 217);
            valueCategory.Location = new Point(123, 73);
            valueCategory.Margin = new Padding(10, 20, 10, 0);
            valueCategory.Name = "valueCategory";
            valueCategory.Size = new Size(167, 30);
            valueCategory.TabIndex = 5;
            // 
            // valueName
            // 
            valueName.BackColor = Color.Transparent;
            valueName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            valueName.ForeColor = Color.FromArgb(67, 179, 217);
            valueName.Location = new Point(123, 23);
            valueName.Margin = new Padding(10, 20, 10, 0);
            valueName.MaximumSize = new Size(167, 40);
            valueName.MinimumSize = new Size(167, 30);
            valueName.Name = "valueName";
            valueName.Size = new Size(167, 40);
            valueName.TabIndex = 4;
            // 
            // labelDescriptionText
            // 
            labelDescriptionText.BackColor = Color.Transparent;
            labelDescriptionText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescriptionText.ForeColor = Color.FromArgb(67, 179, 217);
            labelDescriptionText.Location = new Point(10, 143);
            labelDescriptionText.Margin = new Padding(10, 5, 3, 0);
            labelDescriptionText.Name = "labelDescriptionText";
            labelDescriptionText.Size = new Size(100, 30);
            labelDescriptionText.TabIndex = 3;
            // 
            // labelPriceText
            // 
            labelPriceText.BackColor = Color.Transparent;
            labelPriceText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPriceText.ForeColor = Color.FromArgb(67, 179, 217);
            labelPriceText.Location = new Point(10, 108);
            labelPriceText.Margin = new Padding(10, 5, 3, 0);
            labelPriceText.Name = "labelPriceText";
            labelPriceText.Size = new Size(100, 30);
            labelPriceText.TabIndex = 2;
            // 
            // labelCategoryText
            // 
            labelCategoryText.BackColor = Color.Transparent;
            labelCategoryText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoryText.ForeColor = Color.FromArgb(67, 179, 217);
            labelCategoryText.Location = new Point(10, 73);
            labelCategoryText.Margin = new Padding(10, 10, 3, 0);
            labelCategoryText.Name = "labelCategoryText";
            labelCategoryText.Size = new Size(100, 30);
            labelCategoryText.TabIndex = 1;
            // 
            // labelNameText
            // 
            labelNameText.BackColor = Color.Transparent;
            labelNameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameText.ForeColor = Color.FromArgb(67, 179, 217);
            labelNameText.Location = new Point(10, 23);
            labelNameText.Margin = new Padding(10, 20, 3, 0);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(100, 40);
            labelNameText.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(798, 223);
            button2.Name = "button2";
            button2.Size = new Size(304, 304);
            button2.TabIndex = 51;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 179, 217);
            label3.Location = new Point(853, 171);
            label3.Name = "label3";
            label3.Size = new Size(247, 30);
            label3.TabIndex = 50;
            label3.Text = "Welcome to TaiKun - Online Courses";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoHome
            // 
            logoHome.Image = (Image)resources.GetObject("logoHome.Image");
            logoHome.Location = new Point(800, 161);
            logoHome.Margin = new Padding(40, 0, 0, 0);
            logoHome.Name = "logoHome";
            logoHome.Size = new Size(50, 50);
            logoHome.SizeMode = PictureBoxSizeMode.Zoom;
            logoHome.TabIndex = 49;
            logoHome.TabStop = false;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 600);
            Controls.Add(panelInforCourse);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(logoHome);
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
            panelInforCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoHome).EndInit();
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
        private Button btnEnroll;
        private Panel panelInforCourse;
        private Button button1;
        private Label valueDescription;
        private Label valuePrice;
        private Label valueCategory;
        private Label valueName;
        private Label labelDescriptionText;
        private Label labelPriceText;
        private Label labelCategoryText;
        private Label labelNameText;
        private Button button2;
        private Label label3;
        private PictureBox logoHome;
    }
}