using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS210_GymMS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool Register_validation() // validation for registration form (with boolean type)
        {
            if (string.IsNullOrEmpty(txtMemberID.Text.Trim()))               //checking if userID is empty
            {
                errorProvider1.SetError(txtMemberID, "User ID is required"); //provide error if userID is empty
                MessageBox.Show(errorProvider1.GetError(txtMemberID));       // show this error message
                return false;                                              // false to stop validation
            }
            else
            {
                errorProvider1.SetError(txtMemberID, string.Empty);          //no error if valid
            }

            if (string.IsNullOrEmpty(txtMUsn.Text.Trim()))
            {
                errorProvider2.SetError(txtMUsn, "Member Username is required");
                MessageBox.Show(errorProvider2.GetError(txtMUsn));
                return false;
            }

            else if (!Regex.IsMatch(txtMUsn.Text.Trim(), @"^[A-Za-z]+$")) //checking username has only letters
            {
                errorProvider2.SetError(txtMUsn, "Username must contain only letters (A–Z, a–z)"); 
                MessageBox.Show(errorProvider2.GetError(txtMUsn)); 
                return false;
            }

            else if (UsernameTaken(txtMUsn.Text.Trim()))  // checking username is taken
            {
                errorProvider2.SetError(txtMUsn, "This username is already taken!"); 
                MessageBox.Show(errorProvider2.GetError(txtMUsn)); 
                return false;
            }

            else
            {
                errorProvider2.SetError(txtMUsn, string.Empty);
            }

            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider3.SetError(txtEmail, "Email Address is required");
                MessageBox.Show(errorProvider3.GetError(txtEmail));
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) //to write email format validation
            {
                errorProvider3.SetError(txtEmail, "Invalid email format"); 
                MessageBox.Show(errorProvider3.GetError(txtEmail)); 
                return false;
            }
            else
            {
                errorProvider3.SetError(txtEmail, string.Empty);

            }

            if (txtConfirmPsw.Text != txtPsw.Text) //checking confirm password == password
            {
                errorProvider4.SetError(this.txtConfirmPsw, "Confirm password is not matched !");
                MessageBox.Show(errorProvider4.GetError(txtConfirmPsw));
                return false;
            }
            else
            {
                errorProvider4.SetError(txtConfirmPsw, string.Empty);
            }

            if (string.IsNullOrEmpty(txtPsw.Text.Trim()))
            {
                errorProvider5.SetError(txtPsw, "Password is required");
                MessageBox.Show(errorProvider5.GetError(txtPsw));
                return false;
            }

            else if (txtPsw.Text.Trim().Length < 6)
            {
                errorProvider5.SetError(txtPsw, "Password must be at least 6 characters long"); 
                MessageBox.Show(errorProvider5.GetError(txtPsw)); 
                return false;
            }

            else
            {
                errorProvider5.SetError(txtPsw, string.Empty);
            }
            if (string.IsNullOrEmpty(cboMemType.Text.Trim()))
            {
                errorProvider6.SetError(cboMemType, "Member Type must be selected");
                MessageBox.Show(errorProvider6.GetError(cboMemType));
                return false;

            }
            else
            {
                errorProvider6.SetError(cboMemType, string.Empty);
            }
            return true;            //all checks passed, return true >> registration continues
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Register_validation() == false)
            {
                return;
            }
            
            try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Members(Member_ID,Member_Username, Email_Address, Password, Confirm_Password, Member_Type) values ('" + txtMemberID.Text + "' , '" + txtMUsn.Text + "', '" + txtEmail.Text + "', '" + txtPsw.Text + "','" + txtConfirmPsw.Text + "','" + cboMemType.Text + "' )";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registered Successfully");

                    var F1 = new Form1();
                    F1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Member_AutoID();
            txtPsw.UseSystemPasswordChar = true;
            chkSPsw1.Checked = false;
            chkSPsw1.CheckedChanged += chkSPsw1_CheckedChanged;

            txtConfirmPsw.UseSystemPasswordChar = true;
            chkSPsw2.Checked = false;
            chkSPsw2.CheckedChanged += chkSPsw2_CheckedChanged;
        }
        private void Member_AutoID() //adding autoID
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter adp = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(SUBSTRING(Member_ID, 2, LEN(Member_ID)) AS INT)), 0) + 1 FROM Members", con); 
                DataTable dt = new DataTable();
                adp.Fill(dt);
                int nextUserIDNumber = Convert.ToInt32(dt.Rows[0][0]);
                txtMemberID.Text = "M" + nextUserIDNumber.ToString("D3"); //.ToString("D3") = taking decimal 3 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtUsn_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsn_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSPsw1_CheckedChanged(object sender, EventArgs e)
        {
            txtPsw.UseSystemPasswordChar = !chkSPsw1.Checked;
        }

        private void chkSPsw2_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPsw.UseSystemPasswordChar = !chkSPsw2.Checked;
        }

        private bool UsernameTaken(string username)   //validation for existing username
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();   

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select COUNT(*) from Members where Member_Username = @username";
                cmd.Parameters.AddWithValue("@username", username);         //parameterized query

                int count = (int)cmd.ExecuteScalar();                       //get number of matching usernames
                con.Close();   

                return count > 0;                                           //true if username already exists
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   //show error if query fails
                return true;                   //show taken if error occurs
            }
        }


    }
}
