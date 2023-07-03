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
using System.Reflection;
using System.Collections;

namespace OnlineCourse
{
    public partial class CoursesAdminForm : Form
    {
        // Connection with database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OnlineCourse\OnlineCoursesDB\DBCourses.mdf;Integrated Security=True;Connect Timeout=30");
        public CoursesAdminForm()
        {
            InitializeComponent();
        }

        private void CoursesAdminForm_Load(object sender, EventArgs e)
        {
            inputSearch.Focus(); // Focus on Search when CoursesAdminForm display
            populate();


        }

        // Populate a DataGridView(CoursesDGV) control with data from a database table(CoursesTable).
        public void populate()
        {
            Con.Open(); // Open Connection
            string query = "select * from CoursesTable "; // It creates a string variable named query that contains the SQL statement to select all records from the CoursesTable table in the database.
            SqlDataAdapter da = new SqlDataAdapter(query, Con); //It creates a SqlDataAdapter object named "da" that takes the "query" and the "Con" object as parameters. The SqlDataAdapter object is used to execute the query and fill a DataSet object with the results.
            SqlCommandBuilder builder = new SqlCommandBuilder(da); // It creates a SqlCommandBuilder object named "builder" that takes the "da" object as a parameter. The SqlCommandBuilder object is used to generate SQL commands for updating the database based on the changes made to the DataSet object.
            var ds = new DataSet(); //It creates a DataSet object named "ds". 
            da.Fill(ds); // Calls the Fill() method on the "da" object, passing "ds" as a parameter. The Fill() method executes the query and fills the ds object with the data from the database table.
            CoursesDGV.DataSource = ds.Tables[0]; // It sets the DataSource property of the CoursesDGV object, which is assumed to be a DataGridView control, to the first table in the ds object. This binds the data from the table to the control and displays it in a grid format.          
            filterCategory.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (!filterCategory.Items.Contains((ds.Tables[0].Rows[i][2].ToString())))
                {
                    filterCategory.Items.Add(ds.Tables[0].Rows[i][2].ToString());
                }
            }
            Con.Close(); // Close Connection
        }

        private void inputName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // pressing enter will go to the next input.
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // pressing enter will go to the next input.
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // pressing enter will go to the next input.
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void inputPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // pressing enter will trigger the btnCreate.
            {
                btnCreate_Click(sender, e);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (inputName.Text == "" && inputCategory.Text == "" && inputDescription.Text == "" && inputPrice.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK);
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
                SqlCommand cmd = new SqlCommand("insert into CoursesTable values('" + inputName.Text + "', '" + inputCategory.Text + "', '" + inputDescription.Text + "', '" + inputPrice.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Created Successfully");
                Con.Close();
                populate();
                valueID.Text = "";
                inputName.Clear();
                inputCategory.Clear();
                inputDescription.Clear();
                inputPrice.Clear();
                inputName.Focus();
            }
        }

        private void CoursesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valueID.Text = CoursesDGV.SelectedRows[0].Cells[0].Value.ToString();
            inputName.Text = CoursesDGV.SelectedRows[0].Cells[1].Value.ToString();
            inputCategory.Text = CoursesDGV.SelectedRows[0].Cells[2].Value.ToString();
            inputDescription.Text = CoursesDGV.SelectedRows[0].Cells[3].Value.ToString();
            inputPrice.Text = CoursesDGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (inputName.Text == "" && inputCategory.Text == "" && inputDescription.Text == "" && inputPrice.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK);
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
                string query = "update CoursesTable set Name = '" + inputName.Text + "', Category = '" + inputCategory.Text + "', Description = '" + inputDescription.Text + "', Price = '" + inputPrice.Text + "' where ID = " + valueID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Updated Successfully");
                Con.Close();
                populate();
                valueID.Text = "";
                inputName.Clear();
                inputCategory.Clear();
                inputDescription.Clear();
                inputPrice.Clear();
                inputName.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult deleteMessage = MessageBox.Show("Do you want to delete this course?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (deleteMessage == DialogResult.Yes)
            {
                Con.Open();
                string query = "delete from CoursesTable where ID = " + valueID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Deleted Successfully");
                Con.Close();
                populate();
                valueID.Text = "";
                inputName.Clear();
                inputCategory.Clear();
                inputDescription.Clear();
                inputPrice.Clear();
                inputName.Focus();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            valueID.Text = "";
            inputName.Clear();
            inputCategory.Clear();
            inputDescription.Clear();
            inputPrice.Clear();
            inputName.Focus();
        }

        public void refreshData()
        {
            populate();
            inputSearch.Clear();
            inputSearch.Focus();
            filterCategory.Text = "Categories";
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
            refreshData();
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
