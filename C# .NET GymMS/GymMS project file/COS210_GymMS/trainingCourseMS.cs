using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS210_GymMS
{
    public partial class trainingCourseMS : Form
    {
        public trainingCourseMS()
        {
            InitializeComponent();
        }

        private void trainingCourseMS_Load(object sender, EventArgs e)
        {
            viewCourse();
        }
        private void viewCourse()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Training_Courses";
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvCourse.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var M = new AdminMenu();
            M.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Training_Courses(Course_ID, Course_Name, Category, Duration, Fees, Start_date) values ('" + txtCID.Text + "','" + txtCourseN.Text + "','" + txtCategory.Text + "','" + txtDuration.Text + "','" + txtFees.Text + "','"+txtStartDate.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Training Course is added.");
                viewCourse();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewCourse();
            txtCID.Text = "";
            txtCourseN.Text = "";
            txtCategory.Text = "";
            txtDuration.Text = "";
            txtFees.Text = "";
            txtStartDate.Text = "";
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow i = dgvCourse.Rows[e.RowIndex];
                txtCID.Text = i.Cells[0].Value.ToString();
                txtCourseN.Text = i.Cells[1].Value.ToString();
                txtCategory.Text = i.Cells[2].Value.ToString();
                txtDuration.Text = i.Cells[3].Value.ToString();
                txtFees.Text = i.Cells[4].Value.ToString();
                txtStartDate.Text = i.Cells[5].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Training_Courses set Course_ID = '" + txtCID.Text + "' , Course_Name= '" + txtCourseN.Text + "', Category = '" + txtCategory.Text + "', Duration = '" + txtDuration.Text + "', Fees = '" + txtFees.Text + "', Start_date = '" + txtStartDate.Text + "' where Course_ID = '" + txtCID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information Updated");
                viewCourse();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCID.Text))
            {
                MessageBox.Show("Enter Course ID to delete");
            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Training_Courses WHERE Course_ID = '" + txtCID.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Course ID is found.");

                    DialogResult result = MessageBox.Show("Are you sure you want to delete Course ID " + txtCID.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "DELETE FROM Training_Courses WHERE Course_ID = '" + txtCID.Text + "'";
                        cmd1.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show(txtCID.Text + " is deleted successfully");
                        viewCourse();
                    }
                    else
                    {
                        MessageBox.Show("Delete cancelled.");
                    }
                }
                else
                {
                    MessageBox.Show("Course ID is not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCID.Text))
            {
                MessageBox.Show("Enter Course ID to search");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select*from Training_Courses where Course_ID = '" + txtCID.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Course ID not found!");
                        viewCourse();
                    }
                    dgvCourse.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
