using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OnlineCourse
{
    public partial class CoursesUserForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OnlineCourse\OnlineCoursesDB\DBCourses.mdf;Integrated Security=True;Connect Timeout=30");

        public CoursesUserForm()
        {
            InitializeComponent();
            btnEnroll.Visible = false;
        }

        private void CoursesUserForm_Load(object sender, EventArgs e)
        {
            populate();
            inputSearch.Focus();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from CoursesTable ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CoursesDGV.DataSource = ds.Tables[0];
            filterCategory.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (!filterCategory.Items.Contains((ds.Tables[0].Rows[i][2].ToString())))
                {
                    filterCategory.Items.Add(ds.Tables[0].Rows[i][2].ToString());
                }
            }
            Con.Close();
        }

        public void valueSearch()
        {
            Con.Open();

            DataTable dt = new DataTable("CoursesTable");

            string query = "select * from CoursesTable where Name like @name or Category like @category or Description like @description or Price like @price";

            SqlCommand cmd = new SqlCommand(query, Con);

            cmd.Parameters.AddWithValue("name", string.Format($"%{inputSearch.Text}%"));
            cmd.Parameters.AddWithValue("category", string.Format($"%{inputSearch.Text}%"));
            cmd.Parameters.AddWithValue("description", string.Format($"%{inputSearch.Text}%"));
            cmd.Parameters.AddWithValue("price", string.Format($"%{inputSearch.Text}%"));

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            CoursesDGV.DataSource = dt;

            Con.Close();
        }

        private void inputSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                valueSearch();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            valueSearch();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
            inputSearch.Clear();
            inputSearch.Focus();
            filterCategory.Text = "Categories";

        }

        public void filterCategorySearch()
        {
            Con.Open();
            string query = "select * from CoursesTable where Category = '" + filterCategory.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CoursesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void filterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterCategorySearch();
        }


        private void btnEnroll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to enroll this course?", "Enroll confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }


        private void CoursesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panelInforCourse.BackgroundImage = null;

            btnEnroll.Visible = true;

            labelNameText.Text = "Name:";
            labelCategoryText.Text = "Category:";
            labelPriceText.Text = "Price:";
            labelDescriptionText.Text = "Description:";

            valueName.Text = CoursesDGV.SelectedRows[0].Cells[1].Value.ToString();
            valueCategory.Text = CoursesDGV.SelectedRows[0].Cells[2].Value.ToString();
            valueDescription.Text = CoursesDGV.SelectedRows[0].Cells[3].Value.ToString();
            valuePrice.Text = CoursesDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
