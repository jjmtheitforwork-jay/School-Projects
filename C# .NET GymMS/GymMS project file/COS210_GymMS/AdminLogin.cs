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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAdmN.Text)|| string.IsNullOrEmpty(txtPsw.Text))
            {
                MessageBox.Show("Admin Username and Password must be filled");
            }
            else
            {
                try
                {
                    
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\OneDrive\ART Category\COS210_GymMS.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select*from Admin where Admin_name = '" + txtAdmN.Text+"'and Password = '"+txtPsw.Text+"' ";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    con.Close();
                    if(dt.Rows.Count == 1)
                    {
                        MessageBox.Show ("Welcome admin : "+ txtAdmN.Text);
                        var A2 = new AdminMenu();
                        A2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, Username and Password are not matched");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void chkPsw_CheckedChanged(object sender, EventArgs e)
        {
            txtPsw.UseSystemPasswordChar = !chkPsw.Checked;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            txtPsw.UseSystemPasswordChar = true;
            chkPsw.Checked = false;
            chkPsw.CheckedChanged += chkPsw_CheckedChanged;
        }
    }
}
