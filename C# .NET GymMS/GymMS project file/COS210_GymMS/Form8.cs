using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS210_GymMS
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnTCourse_Click(object sender, EventArgs e)
        {
            var F5 = new Form5();
            F5.Show();
            this.Hide();
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            var F6 = new Form6();
            F6.Show();
            this.Hide();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            var F7 = new Form7();
            F7.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var F1 = new Form1();
            F1.Show(); this.Hide();
        }
    }
}
