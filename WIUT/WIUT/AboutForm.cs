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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // this for only tesing purposes
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
            var c = new Course();
            c.Name = tbxTest.Text;
            MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
