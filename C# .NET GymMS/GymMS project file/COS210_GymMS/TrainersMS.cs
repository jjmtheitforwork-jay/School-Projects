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
    public partial class TrainersMS : Form
    {
        public TrainersMS()
        {
            InitializeComponent();
        }

        private void lblAdminMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var AM1 = new AdminMenu();
            AM1.Show();
            this.Hide();
        }

        private void viewTrainer()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Trainers";
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTrainers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void TrainersMS_Load(object sender, EventArgs e)
        {
            viewTrainer();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Trainers(Trainer_ID, Trainer_Name, Gender, Role, Experience, Phone, Address) values ('" + txtTID.Text + "','" + txtTName.Text + "','" + cboGender.Text + "','" + txtRole.Text + "','" + txtExp.Text + "','" + txtPh.Text + "','" + txtAddress.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New trainer is added.");
                viewTrainer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewTrainer();
            txtTID.Text = "";
            txtTName.Text = "";
            cboGender.Text = "";
            txtRole.Text = "";
            txtExp.Text = "";
            txtPh.Text = "";
            txtAddress.Text = "";
        }

        private void dgvTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow i = dgvTrainers.Rows[e.RowIndex];
                txtTID.Text = i.Cells[0].Value.ToString();
                txtTName.Text = i.Cells[1].Value.ToString();
                cboGender.Text = i.Cells[2].Value.ToString();
                txtRole.Text = i.Cells[3].Value.ToString();
                txtExp.Text = i.Cells[4].Value.ToString();
                txtPh.Text = i.Cells[5].Value.ToString();
                txtAddress.Text = i.Cells[6].Value.ToString();
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
                cmd.CommandText = "Update Trainers set Trainer_ID = '" + txtTID.Text + "' , Trainer_Name= '" + txtTName.Text + "', Gender = '" + cboGender.Text + "', Role = '" + txtRole.Text + "', Experience = '" + txtExp.Text + "', Phone = '" + txtPh.Text + "', Address = '"+txtAddress.Text+"' where Trainer_ID = '" + txtTID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information Updated");
                viewTrainer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTID.Text))
            {
                MessageBox.Show("Enter Trainer ID to delete");
            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Trainers WHERE Trainer_ID = '" + txtTID.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Trainer ID is found.");

                    DialogResult result = MessageBox.Show("Are you sure you want to delete Trainer ID " + txtTID.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "DELETE FROM Trainers WHERE Trainer_ID = '" + txtTID.Text + "'";
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(txtTID.Text + "is deleted successfully");
                        viewTrainer();
                    }
                    else
                    {
                        MessageBox.Show("Delete cancelled.");
                    }
                }
                else
                {
                    MessageBox.Show("Trainer ID is not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTID.Text))
            {
                MessageBox.Show("Enter Trainer ID to search");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select*from Trainers where Trainer_ID = '" + txtTID.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Trainer ID not found!");
                        viewTrainer();
                    }
                    dgvTrainers.DataSource = dt;
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

