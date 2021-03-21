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
    public partial class CourseListForm : Form
    {
        public CourseListForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CourseListForm_Load(object sender, EventArgs e)
        {
            // ParentFrom is a MdiParent of the CourseListForm
            // to make sure our CourseListForm always stays inside the ParentForm
            MdiParent = MyForms.GetForm<ParentForm>();

            LoadData();
        }

        public void LoadData()
        {
            dgvCourse.DataMember = "";
            dgvCourse.DataSource = null;
            dgvCourse.DataSource = new CourseList().GetAllCourses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new CourseEditForm();
            form.CreateNewCourse();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count == 0)
                MessageBox.Show("Please select a course");
            else
            {
                var c = (Course)dgvCourse.SelectedRows[0].DataBoundItem;
                new CourseEditForm().UpdateCourse(c);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count == 0)
                MessageBox.Show("Please select a course");
            else
            {
                var c = (Course)dgvCourse.SelectedRows[0].DataBoundItem;
                new CourseManager().Delete(c.Id);
                LoadData();
            }
        }
    }
}
