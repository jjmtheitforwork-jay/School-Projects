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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var F8 = new Form8();
            F8.Show();
            this.Hide();
        }


        private void btnEnroll_Click(object sender, EventArgs e)
        {
            var F6 = new Form6();
            F6.Show(); this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Training_Courses";
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTrainingCourse.DataSource = dt;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
