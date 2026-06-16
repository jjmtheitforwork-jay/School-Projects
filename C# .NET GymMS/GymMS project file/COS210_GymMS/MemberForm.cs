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
using System.Xml.Linq;

namespace COS210_GymMS
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var AM1 = new AdminMenu();
            AM1.Show();
            this.Hide();
        }

        private void viewMember()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Members";
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvMember.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            viewMember();
            
        }

        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            try
            { 
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Members(Member_ID, Member_Username, Email_Address, Password, Confirm_Password, Member_Type) values ('" + txtMID.Text + "','" + txtMUsn.Text + "','" + txtEmail.Text + "','" + txtPsw.Text + "','" + txtCPsw.Text + "','" + txtMType.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("New member is added.");
                con.Close();
                viewMember();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewMember();
            txtMID.Text = "";
            txtMUsn.Text = "";
            txtEmail.Text = "";
            txtMUsn.Text = "";
            txtPsw.Text = "";
            txtCPsw.Text = "";
            txtMType.Text = "";
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow i = dgvMember.Rows[e.RowIndex];
                txtMID.Text = i.Cells[0].Value.ToString();
                txtMUsn.Text = i.Cells[1].Value.ToString();
                txtEmail.Text = i.Cells[2].Value.ToString();
                txtPsw.Text = i.Cells[3].Value.ToString();
                txtCPsw.Text = i.Cells[4].Value.ToString();
                txtMType.Text = i.Cells[5].Value.ToString();
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
                cmd.CommandText = "Update Members set Member_ID = '" + txtMID.Text + "' , Member_Username= '" + txtMUsn.Text + "', Email_Address = '" + txtEmail.Text + "', Password = '" + txtPsw.Text + "', Confirm_Passworrd = '" + txtCPsw.Text + "', Member_Type = '" + txtMType.Text + "' where Member_ID = '" + txtMID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information Updated");
                viewMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMID.Text))
            {
                MessageBox.Show("Enter Member ID to delete");
            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Members where Member_ID = '" + txtMID.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 1) 
                {
                    MessageBox.Show("Member ID is found.");

                    DialogResult result = MessageBox.Show("Are you sure you want to delete Member ID " + txtMID.Text+ "?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "DELETE FROM Members WHERE Member_ID = '" + txtMID.Text + "'";
                        cmd1.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show(txtMID.Text + " is deleted successfully");
                        viewMember();
                    }
                    else
                    {
                        MessageBox.Show("Delete cancelled.");
                    }
                }
                else
                {
                    MessageBox.Show("Member ID is not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMID.Text))
            {
                MessageBox.Show("Enter Member ID to search");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select*from Members where Member_ID = '" + txtMID.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Member ID not found!");
                        viewMember();
                    }
                    dgvMember.DataSource = dt;
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
