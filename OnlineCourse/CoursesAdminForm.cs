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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineCourse
{
    public partial class CoursesAdminForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OnlineCourse\OnlineCoursesDB\OnlineCoursesDB.mdf;Integrated Security=True;Connect Timeout=30");
        public CoursesAdminForm()
        {
            InitializeComponent();
        }

        private void CoursesAdminForm_Load(object sender, EventArgs e)
        {
            inputSearch.Focus();
            populate();
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

        private void inputID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate_Click(sender, e);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (inputID.Text == "" && inputName.Text == "" && inputCategory.Text == "" && inputDescription.Text == "" && inputPrice.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK);
            }
            else if (inputID.Text == "")
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK);
            }
            else if (inputName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK);
            }
            else if (inputCategory.Text == "")
            {
                MessageBox.Show("Please Enter Category", "Error", MessageBoxButtons.OK);
            }
            else if (inputDescription.Text == "")
            {
                MessageBox.Show("Please Enter Description", "Error", MessageBoxButtons.OK);
            }
            else if (inputPrice.Text == "")
            {
                MessageBox.Show("Please Enter Price", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CoursesTable values(" + inputID.Text + ", '" + inputName.Text + "', '" + inputCategory.Text + "', '" + inputDescription.Text + "', '" + inputPrice.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Created Successfully");
                Con.Close();
                populate();
                inputID.Clear();
                inputName.Clear();
                inputCategory.Clear();
                inputDescription.Clear();
                inputPrice.Clear();
                inputID.Focus();
            }
        }

        private void CoursesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            inputID.Text = CoursesDGV.SelectedRows[0].Cells[0].Value.ToString();
            inputName.Text = CoursesDGV.SelectedRows[0].Cells[1].Value.ToString();
            inputCategory.Text = CoursesDGV.SelectedRows[0].Cells[2].Value.ToString();
            inputDescription.Text = CoursesDGV.SelectedRows[0].Cells[3].Value.ToString();
            inputPrice.Text = CoursesDGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (inputID.Text == "" && inputName.Text == "" && inputCategory.Text == "" && inputDescription.Text == "" && inputPrice.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK);
            }
            else if (inputID.Text == "")
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK);
            }
            else if (inputName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK);
            }
            else if (inputCategory.Text == "")
            {
                MessageBox.Show("Please Enter Category", "Error", MessageBoxButtons.OK);
            }
            else if (inputDescription.Text == "")
            {
                MessageBox.Show("Please Enter Description", "Error", MessageBoxButtons.OK);
            }
            else if (inputPrice.Text == "")
            {
                MessageBox.Show("Please Enter Price", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Con.Open();
                string query = "update CoursesTable set Name = '" + inputName.Text + "', Category = '" + inputCategory.Text + "', Description = '" + inputDescription.Text + "', Price = '" + inputPrice.Text + "' where ID = " + inputID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Updated Successfully");
                Con.Close();
                populate();
                inputID.Clear();
                inputName.Clear();
                inputCategory.Clear();
                inputDescription.Clear();
                inputPrice.Clear();
                inputID.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (inputID.Text == "")
            {
                MessageBox.Show("Please Enter Courses ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult deleteMessage = MessageBox.Show("Do you want to delete this course?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (deleteMessage == DialogResult.Yes)
                {
                    Con.Open();
                    string query = "delete from CoursesTable where ID = " + inputID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Deleted Successfully");
                    Con.Close();
                    populate();
                }

            }
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
