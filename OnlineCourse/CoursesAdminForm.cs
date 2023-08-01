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
using static System.Net.Mime.MediaTypeNames;

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

        // An event handler function that is triggered when the form loads
        private void CoursesAdminForm_Load(object sender, EventArgs e)
        {           
            inputSearch.Focus();// Set the focus to the input search box           
            populate();// Call the populate function to load and display the data
        }

        // A function that loads and displays the data from the database
        public void populate()
        {
            Con.Open(); // Open the database connection
            string query = "select * from CoursesTable "; // Define the query string to select all the courses from the table

            // Create a data adapter object with the query and the connection
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            // Create a command builder object with the data adapter
            SqlCommandBuilder builder = new SqlCommandBuilder(da); 
            var ds = new DataSet();  // Create a data set object
            da.Fill(ds); // Fill the data set with the results of the query
            CoursesDGV.DataSource = ds.Tables[0]; // Set the data source of the data grid view to the data set table      
            filterCategory.Items.Clear(); // Clear the filter category combo box items

            // Loop through each row in the table
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // If the filter category combo box does not contain the category of the current row
                if (!filterCategory.Items.Contains((ds.Tables[0].Rows[i][2].ToString())))
                {
                    // Add the category of the current row to the filter category combo box items
                    filterCategory.Items.Add(ds.Tables[0].Rows[i][2].ToString());
                }
            }
            Con.Close(); // Close the database connection
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
            //Retrieve the values from the selected row in the DataGridView and display them in the corresponding text boxes.
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
            Con.Open();// Open the connection

            DataTable dt = new DataTable("CoursesTable"); // Create a data table object to store the query results and give it a name

            /** Define a SQL query string that selects all columns from the CoursesTable 
            where the Name, Category, Description, or Price columns match the inputSearch text with wildcards**/
            string query = "select * from CoursesTable where Name like @name or Category like @category " +
                           "or Description like @description or Price like @price";

            // Create a command object to execute the query using the connection and the query string
            SqlCommand cmd = new SqlCommand(query, Con);

            // Add four parameters to the command object with the names and values corresponding to the columns and the inputSearch text
            cmd.Parameters.AddWithValue("name", string.Format($"%{inputSearch.Text}%"));
            cmd.Parameters.AddWithValue("category", string.Format($"%{inputSearch.Text}%"));
            cmd.Parameters.AddWithValue("description", string.Format($"%{inputSearch.Text}%"));
            cmd.Parameters.AddWithValue("price", string.Format($"%{inputSearch.Text}%"));

            // Create a data adapter object to transfer the data between the database and the data table using the command object
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt); // Fill the data table with the query results using the data adapter
            CoursesDGV.DataSource = dt; // Set the data source of the grid view control to the data table to display the query results
            Con.Close(); // Close the connection
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

        // A function that filters the courses by category and displays them in a data grid view
        public void filterCategorySearch()
        {
            // Open the database connection
            Con.Open();
            // Define the query string with the selected category as a parameter
            string query = "select * from CoursesTable where Category = '" + filterCategory.SelectedItem.ToString() + "'";
            // Create a data adapter object with the query and the connection
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            // Create a command builder object with the data adapter
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            // Create a data set object
            var ds = new DataSet();
            // Fill the data set with the results of the query
            da.Fill(ds);
            // Set the data source of the data grid view to the data set table
            CoursesDGV.DataSource = ds.Tables[0];
            // Close the database connection
            Con.Close();

        }

        // An event handler function that is triggered when the selected category changes
        private void filterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the filterCategorySearch function to update the data grid view
            filterCategorySearch();
        }


    }
}
