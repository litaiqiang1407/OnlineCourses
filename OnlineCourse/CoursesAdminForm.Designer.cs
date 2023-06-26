namespace OnlineCourse
{
    partial class CoursesAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesAdminForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            btnSearch = new Button();
            inputSearch = new TextBox();
            label1 = new Label();
            CoursesDGV = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label3 = new Label();
            inputID = new TextBox();
            inputName = new TextBox();
            label4 = new Label();
            inputCategory = new TextBox();
            label5 = new Label();
            inputDescription = new TextBox();
            label6 = new Label();
            inputPrice = new TextBox();
            label7 = new Label();
            label8 = new Label();
            filterCategory = new ComboBox();
            btnRefresh = new Button();
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
            label2.TabIndex = 4;
            label2.Text = "TaiKun - Online Courses - CuongLT <3";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(67, 179, 217);
            btnSearch.FlatAppearance.MouseDownBackColor = Color.White;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(893, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 27);
            btnSearch.TabIndex = 13;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // inputSearch
            // 
            inputSearch.BackColor = Color.WhiteSmoke;
            inputSearch.Location = new Point(135, 62);
            inputSearch.Margin = new Padding(3, 50, 5, 3);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(750, 27);
            inputSearch.TabIndex = 0;

            inputSearch.KeyDown += inputSearch_KeyDown;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 179, 217);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(50, 59);
            label1.Margin = new Padding(50, 20, 50, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 11;
            label1.Text = "Search";
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(67, 179, 217);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CoursesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            CoursesDGV.EnableHeadersVisualStyles = false;
            CoursesDGV.GridColor = Color.FromArgb(67, 179, 217);
            CoursesDGV.Location = new Point(400, 161);
            CoursesDGV.Margin = new Padding(20, 50, 50, 20);
            CoursesDGV.Name = "CoursesDGV";
            CoursesDGV.ReadOnly = true;
            CoursesDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(67, 179, 217);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CoursesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CoursesDGV.RowHeadersVisible = false;
            CoursesDGV.RowHeadersWidth = 51;
            CoursesDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(134, 223, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            CoursesDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            CoursesDGV.RowTemplate.Height = 29;
            CoursesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CoursesDGV.Size = new Size(700, 410);
            CoursesDGV.TabIndex = 10;
            CoursesDGV.CellContentClick += CoursesDGV_CellContentClick;
            // 
            // btnCreate
            // 
            btnCreate.AutoSize = true;
            btnCreate.BackColor = Color.FromArgb(67, 179, 217);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(48, 530);
            btnCreate.Margin = new Padding(3, 10, 3, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 40);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(67, 179, 217);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(154, 530);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(67, 179, 217);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(260, 530);
            btnDelete.Margin = new Padding(3, 20, 20, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 179, 217);
            label3.Location = new Point(50, 147);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 17;
            label3.Text = "ID";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputID
            // 
            inputID.BackColor = Color.FromArgb(224, 224, 224);
            inputID.Location = new Point(48, 180);
            inputID.Name = "inputID";
            inputID.Size = new Size(312, 27);
            inputID.TabIndex = 1;
            inputID.KeyDown += inputID_KeyDown;
            // 
            // inputName
            // 
            inputName.BackColor = Color.FromArgb(224, 224, 224);
            inputName.Location = new Point(48, 253);
            inputName.Name = "inputName";
            inputName.Size = new Size(312, 27);
            inputName.TabIndex = 2;
            inputName.KeyDown += inputName_KeyDown;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(67, 179, 217);
            label4.Location = new Point(48, 220);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 19;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputCategory
            // 
            inputCategory.BackColor = Color.FromArgb(224, 224, 224);
            inputCategory.Location = new Point(48, 326);
            inputCategory.Name = "inputCategory";
            inputCategory.Size = new Size(312, 27);
            inputCategory.TabIndex = 3;
            inputCategory.KeyDown += inputCategory_KeyDown;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(67, 179, 217);
            label5.Location = new Point(48, 293);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 21;
            label5.Text = "Category";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputDescription
            // 
            inputDescription.BackColor = Color.FromArgb(224, 224, 224);
            inputDescription.Location = new Point(50, 399);
            inputDescription.Name = "inputDescription";
            inputDescription.Size = new Size(312, 27);
            inputDescription.TabIndex = 4;

            inputDescription.KeyDown += inputDescription_KeyDown;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(67, 179, 217);
            label6.Location = new Point(48, 366);
            label6.Name = "label6";
            label6.Size = new Size(130, 30);
            label6.TabIndex = 23;
            label6.Text = "Description";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPrice
            // 
            inputPrice.BackColor = Color.FromArgb(224, 224, 224);
            inputPrice.Location = new Point(48, 472);
            inputPrice.Name = "inputPrice";
            inputPrice.Size = new Size(312, 27);
            inputPrice.TabIndex = 5;
            inputPrice.KeyDown += inputPrice_KeyDown;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(67, 179, 217);
            label7.Location = new Point(48, 439);
            label7.Name = "label7";
            label7.Size = new Size(100, 30);
            label7.TabIndex = 25;
            label7.Text = "Price";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(67, 179, 217);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(400, 112);
            label8.Margin = new Padding(50, 20, 50, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 30);
            label8.TabIndex = 26;
            label8.Text = "Filter";
            // 
            // filterCategory
            // 
            filterCategory.BackColor = Color.WhiteSmoke;
            filterCategory.FlatStyle = FlatStyle.Flat;
            filterCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filterCategory.ForeColor = Color.FromArgb(67, 179, 217);
            filterCategory.FormattingEnabled = true;
            filterCategory.Items.AddRange(new object[] { "IT & Software", "Business", "Lifestyle", "Design", "Marketing" });
            filterCategory.Location = new Point(485, 113);
            filterCategory.Margin = new Padding(3, 15, 3, 3);
            filterCategory.Name = "filterCategory";
            filterCategory.Size = new Size(150, 28);
            filterCategory.TabIndex = 27;
            filterCategory.Text = "Category";
            filterCategory.SelectedIndexChanged += filterCategory_SelectedIndexChanged;
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
            btnRefresh.TabIndex = 29;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CoursesAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 600);
            Controls.Add(btnRefresh);
            Controls.Add(filterCategory);
            Controls.Add(label8);
            Controls.Add(inputPrice);
            Controls.Add(label7);
            Controls.Add(inputDescription);
            Controls.Add(label6);
            Controls.Add(inputCategory);
            Controls.Add(label5);
            Controls.Add(inputName);
            Controls.Add(label4);
            Controls.Add(inputID);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnSearch);
            Controls.Add(inputSearch);
            Controls.Add(label1);
            Controls.Add(CoursesDGV);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursesAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoursesAdminForm";
            Load += CoursesAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)CoursesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnSearch;
        private TextBox inputSearch;
        private Label label1;
        private DataGridView CoursesDGV;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label3;
        private TextBox inputID;
        private TextBox inputName;
        private Label label4;
        private TextBox inputCategory;
        private Label label5;
        private TextBox inputDescription;
        private Label label6;
        private TextBox inputPrice;
        private Label label7;
        private Label label8;
        private ComboBox filterCategory;
        private Button btnRefresh;
    }
}