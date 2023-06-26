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
    public partial class CoursesForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OnlineCourse\OnlineCoursesDB\OnlineCoursesDB.mdf;Integrated Security=True;Connect Timeout=30");
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void CoursesForm_Load(object sender, EventArgs e)
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
            Con.Close();
        }

        public void valueSearch()
        {
            Con.Open();
            string query = "select * from CoursesTable where Name = '" + inputSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CoursesDGV.DataSource = ds.Tables[0];
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

    }
}
