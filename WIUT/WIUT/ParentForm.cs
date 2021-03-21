using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIUT.DAL;

namespace WIUT
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        // testing
        private void ParentForm_Load(object sender, EventArgs e)
        {
            var courseList = new CourseList();
            var courses = courseList.GetAllCourses();
            MessageBox.Show(courses.Count.ToString());
        }
    }
}
