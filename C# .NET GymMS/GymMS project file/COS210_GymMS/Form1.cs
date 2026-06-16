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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F3= new AdminLogin();
            F3.Show(); this.Hide();
        }

        private void rEGISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F4 = new Form4();
            F4.Show(); this.Hide();
        }

        private void tRAININGCOURSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F5 = new Form5();
            F5.Show(); this.Hide();
        }

        private void tRAINERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F6 = new Form6();
            F6.Show(); this.Hide();
        }

        private void eNROLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F7 = new Form7();
            F7.Show(); this.Hide();

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
