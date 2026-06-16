using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS210_GymMS
{
    public partial class EnrollmentMS : Form
    {
        public EnrollmentMS()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var A1 = new AdminMenu();
            A1.Show();
            this.Hide();
        }

        private void EnrollmentMS_Load(object sender, EventArgs e)
        {
            viewEnrollment();

            txtBd.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtHeight.ReadOnly = true;
            txtCWeight.ReadOnly = true;
            txtGWeight.ReadOnly = true;

            txtBd.TabStop = false;
            txtGender.TabStop = false;
            txtHeight.TabStop = false;
            txtCWeight.TabStop = false;
            txtGWeight.TabStop = false;
        }

        private void viewEnrollment()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Enrollment";
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvEnrollment.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewEnrollment();
            txtEID.Text = "";
            txtMID.Text = "";
            txtCID.Text = "";
            txtTID.Text = "";
            txtFullname.Text = "";
            txtBd.Text = "";
            txtGender.Text = "";
            txtHeight.Text = "";
            txtCWeight.Text = "";
            txtGWeight.Text = "";
            txtStartdate.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEID.Text))
            {
                MessageBox.Show("Enter Enrollment ID to search");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select*from Enrollment where Enrollment_ID = '" + txtEID.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if(dt.Rows.Count ==0)
                    {
                        MessageBox.Show("Enrollment ID not found!");
                        viewEnrollment();
                    }
                    dgvEnrollment.DataSource = dt;
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
                cmd.CommandText = "update Enrollment set Member_ID='" + txtMID.Text + "', Course_ID='" + txtCID.Text + "', Trainer_ID='" + txtTID.Text + "', Full_Name='" + txtFullname.Text + "', Birth_Date='" + txtBd.Text + "', Gender='" + txtGender.Text + "', [Height(cm)]='" + txtHeight.Text + "', [Current_Weight(kg)]='" + txtCWeight.Text + "', [Goal_Weight(kg)]='" + txtGWeight.Text + "', Start_date='" + txtStartdate.Text + "' WHERE Enrollment_ID='" + txtEID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information Updated");
                viewEnrollment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEnrollment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow i = dgvEnrollment.Rows[e.RowIndex];
                txtEID.Text = i.Cells[0].Value.ToString();
                txtMID.Text = i.Cells[1].Value.ToString();
                txtCID.Text = i.Cells[2].Value.ToString();
                txtTID.Text = i.Cells[3].Value.ToString();
                txtFullname.Text = i.Cells[4].Value.ToString();
                txtBd.Text = i.Cells[5].Value.ToString();
                txtGender.Text = i.Cells[6].Value.ToString();
                txtHeight.Text = i.Cells[7].Value.ToString();
                txtCWeight.Text = i.Cells[8].Value.ToString();
                txtGWeight.Text = i.Cells[9].Value.ToString();
                txtStartdate.Text = i.Cells[10].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEID.Text))
            {
                MessageBox.Show("Enter Enrollment ID to delete");
            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Enrollment WHERE Enrollment_ID = '" + txtEID.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Enrollment ID is found.");

                    DialogResult result = MessageBox.Show("Are you sure you want to delete Enrollment ID " + txtEID.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "DELETE FROM Enrollment WHERE Enrollment_ID = '" + txtEID.Text + "'";
                        cmd1.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show(txtEID.Text + " is deleted successfully");
                        viewEnrollment();
                    }
                    else
                    {
                        MessageBox.Show("Delete cancelled.");
                    }
                }
                else
                {
                    MessageBox.Show("Enrollment ID is not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
