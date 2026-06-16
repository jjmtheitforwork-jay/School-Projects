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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var F8 = new Form8();
            F8.Show(); this.Hide();
        }

        private void Enrollment_autoID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adp = new SqlDataAdapter("select isnull(max(Enrollment_ID), 0) + 1 from Enrollment", con);
            DataTable dt = new DataTable(); 
            adp.Fill(dt); 
            int nextEnrollmentID = Convert.ToInt32(dt.Rows[0][0]);
            txtEID.Text = nextEnrollmentID.ToString();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            Enrollment_autoID();
            fill_UserID();
            fill_CourseID();
            fill_TrainerID();
        }

        private void fill_TrainerID()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Trainer_ID from Trainers", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboTID.Items.Add(rd.GetValue(0).ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fill_CourseID()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Course_ID from Training_Courses", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboCID.Items.Add(rd.GetValue(0).ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fill_UserID()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Member_ID from Members", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboMID.Items.Add(rd.GetValue(0).ToString());
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Enrollment_validation()
        {
            if (string.IsNullOrEmpty(txtEID.Text.Trim()))
            {
                errorProvider1.SetError(txtEID, "Enrollment ID is required");
                MessageBox.Show(errorProvider1.GetError(txtEID));
                return false;
            }
            else
            {
                errorProvider1.SetError(txtEID, string.Empty);
            }

            if (string.IsNullOrEmpty(cboMID.Text.Trim()))
            {
                errorProvider2.SetError(cboMID, "Member ID must be selected");
                MessageBox.Show(errorProvider2.GetError(cboMID));
                return false;
            }
            else
            {
                errorProvider2.SetError(cboMID, string.Empty);
            }

            if (string.IsNullOrEmpty (cboCID.Text.Trim()))
            {
                errorProvider3.SetError(cboCID, "Training Course ID must be selected");
                MessageBox.Show(errorProvider3.GetError(cboCID));
                return false;
            }
            else
            {
                errorProvider3.SetError(cboCID, string.Empty);
            }

            if (string.IsNullOrEmpty (cboTID.Text.Trim()))
            {
                errorProvider4.SetError(cboTID, "Trainer ID must be selected");
                MessageBox.Show(errorProvider4.GetError(cboTID));
                return false;
            }
            else
            {
                errorProvider4.SetError(cboTID, string.Empty);
            }

            if (string.IsNullOrEmpty(txtFullname.Text.Trim()))
            {
                errorProvider5.SetError(txtFullname, "Full Name required");
                MessageBox.Show(errorProvider5.GetError(txtFullname));
                return false;
            }
            else
            {
                errorProvider5.SetError(txtFullname, string.Empty);
            }

            if (string.IsNullOrEmpty(txtBd.Text.Trim()))
            {
                errorProvider6.SetError(txtBd, "Birth date required");
                MessageBox.Show(errorProvider6.GetError(txtBd));
                return false;
            }
            else if (!DateTime.TryParse(txtBd.Text.Trim(), out DateTime birthDate)) //check if valid date format
            { 
                errorProvider6.SetError(txtBd, "Invalid birth date format"); 
                MessageBox.Show(errorProvider6.GetError(txtBd)); 
                return false; 
            }
            else if (birthDate > DateTime.Today) 
            { 
                errorProvider6.SetError(txtBd, "Birth date cannot be in the future"); 
                MessageBox.Show(errorProvider6.GetError(txtBd)); 
                return false; 
            }
            else if ((DateTime.Today.Year - birthDate.Year) < 16) // optional age check
            { 
                errorProvider6.SetError(txtBd, "Member must be at least 16 years old"); 
                MessageBox.Show(errorProvider6.GetError(txtBd)); 
                return false; 
            }
            else
            {
                errorProvider6.SetError(txtBd, string.Empty);
            }

            if (string.IsNullOrEmpty(cboGender.Text.Trim()))
            {
                errorProvider7.SetError(cboGender, "Gender required");
                MessageBox.Show(errorProvider7.GetError(cboGender));
                return false;
            }
            else
            {
                errorProvider7.SetError(cboGender, string.Empty);
            }

            if (string.IsNullOrEmpty(txtHeight.Text.Trim()))
            {
                errorProvider8.SetError(txtHeight, "Height required");
                MessageBox.Show(errorProvider8.GetError(txtHeight));
                return false;
            }

            else if (!int.TryParse(txtHeight.Text.Trim(), out int heightValue))
            {
                errorProvider8.SetError(txtHeight, "Height must be a number"); 
                MessageBox.Show(errorProvider8.GetError(txtHeight)); 
                return false;
            }
            else if (heightValue < 100 || heightValue > 250)
            {
                errorProvider8.SetError(txtHeight, "Height must be between 100 and 250 cm"); 
                MessageBox.Show(errorProvider8.GetError(txtHeight)); 
                return false;
            }
            else
            {
                errorProvider8.SetError(txtHeight, string.Empty);
            }

            if (string.IsNullOrEmpty(txtCWeight.Text.Trim()))
            {
                errorProvider9.SetError(txtCWeight, "Current weight required");
                MessageBox.Show(errorProvider9.GetError(txtCWeight));
                return false;
            }

            else if (!int.TryParse(txtCWeight.Text.Trim(), out int curWeightValue))
            {
                errorProvider9.SetError(txtCWeight, "Current weight must be a number"); 
                MessageBox.Show(errorProvider9.GetError(txtCWeight)); 
                return false;
            }

            else if (curWeightValue < 30 || curWeightValue > 300)
            {
                errorProvider9.SetError(txtCWeight, "Current weight must be between 30 and 300 kg"); 
                MessageBox.Show(errorProvider9.GetError(txtCWeight)); 
                return false;
            }

            else
            {
                errorProvider9.SetError(txtCWeight, string.Empty);
            }

            if (string.IsNullOrEmpty(txtGWeight.Text.Trim()))
            {
                errorProvider10.SetError(txtGWeight, "Goal weight required");
                MessageBox.Show(errorProvider10.GetError(txtGWeight));
                return false;
            }

            else if (!int.TryParse(txtGWeight.Text.Trim(), out int goalWeightValue))
            {
                errorProvider10.SetError(txtGWeight, "Goal weight must be a number"); 
                MessageBox.Show(errorProvider10.GetError(txtGWeight)); 
                return false;
            }

            else if (goalWeightValue < 30 || goalWeightValue > 300)
            {
                errorProvider10.SetError(txtGWeight, "Goal weight must be between 30 and 300 kg"); 
                MessageBox.Show(errorProvider10.GetError(txtGWeight)); 
                return false;
            }
            else
            {
                errorProvider10.SetError(txtGWeight, string.Empty);
            }

            if (string.IsNullOrEmpty(txtStartDate.Text.Trim()))
            {
                errorProvider11.SetError(txtStartDate, "Start date required");
                MessageBox.Show(errorProvider11.GetError(txtStartDate));
                return false;
            }

            else if (!DateTime.TryParse(txtStartDate.Text.Trim(), out DateTime startDate)) 
            { 
                errorProvider11.SetError(txtStartDate, "Invalid start date format"); 
                MessageBox.Show(errorProvider11.GetError(txtStartDate)); 
                return false; 
            }
            else if (startDate < DateTime.Today) 
            { 
                errorProvider11.SetError(txtStartDate, "Start date cannot be in the past"); 
                MessageBox.Show(errorProvider11.GetError(txtStartDate)); 
                return false; 
            }
            else
            {
                errorProvider11.SetError(txtStartDate, string.Empty);
            }

            return true;
        }
       
        private void btnEnroll_Click_1(object sender, EventArgs e)
        {
            if (Enrollment_validation() == false)
            {
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Enrollment(Member_ID,Course_ID,Trainer_ID,Full_Name,Birth_Date, Gender,[Height(cm)],[Current_Weight(kg)], [Goal_Weight(kg)], Start_date)values('" + cboMID.Text + "', '" + cboCID.Text + "','" + cboTID.Text + "','" + txtFullname.Text + "','" + txtBd.Text + "','"+cboGender.Text+"', '"+txtHeight.Text+"','"+txtCWeight.Text+"','"+txtGWeight.Text+"','"+txtStartDate.Text+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enrolled Successfully!");
                var F8 = new Form8();
                F8.Show();
                this.Hide();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
