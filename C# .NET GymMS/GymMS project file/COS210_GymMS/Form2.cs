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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace COS210_GymMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var F4 = new Form4();
            F4.Show(); this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty (txtMUsn.Text) || string.IsNullOrEmpty(txtPsw.Text))
            {
                MessageBox.Show("Enter both Member Username and Password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand ();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Members where Member_Username = '" + txtMUsn.Text + "'  and Password = '" + txtPsw.Text + "'";
                    cmd.ExecuteNonQuery ();
                    con.Close();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill (dt);
                    if (dt.Rows.Count == 1 )
                    {
                        MessageBox.Show("Member Login Success!");
                        var F8 = new Form8();
                        F8.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("MemberUsername and Password is not matched.");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void chkPsw_CheckedChanged(object sender, EventArgs e)
        {
            txtPsw.UseSystemPasswordChar = !chkPsw.Checked;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtPsw.UseSystemPasswordChar = true; // to hide the password
            chkPsw.Checked = false;
            chkPsw.CheckedChanged += chkPsw_CheckedChanged;
        }
    }
}
