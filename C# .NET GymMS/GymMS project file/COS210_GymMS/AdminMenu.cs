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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void trainingCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Cs = new trainingCourseMS();
            Cs.Show();
            this.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void trainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var T1 = new TrainersMS();
            T1.Show();
            this.Hide();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var M1 = new MemberForm();
            M1.Show();
            this.Hide();
        }

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var e1 = new EnrollmentMS();
            e1.Show();
            this.Hide();
        }
    }
}
