using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudents frmStudents = new FrmStudents();
            frmStudents.MdiParent = this;
            frmStudents.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourses frmCourses = new FrmCourses();
            frmCourses.MdiParent = this;
            frmCourses.Show();
        }
    }
}
