using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erin_mcmackin_project4
{
    public partial class formSemester : Form
    {
        public formSemester()
        {
            InitializeComponent();
        }

        private SemesterSet newSemester = null;

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.class_DBDataSet);

        }

        private void formSemester_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'class_DBDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.class_DBDataSet.Courses);

        }

        // Create a new new SemesterSet object
        private void btnSet_Click(object sender, EventArgs e)
        {
            //newSemester = new SemesterSet(Convert.ToInt32(txtNumOfCoursesIn.Text), txtNameIn.Text, Convert.ToDateTime(calStartDateIn.Text), courseNumComboBox.Text, groupBox1.Text);
            // MessageBox.Show(txtNameIn.Text);
            SemesterSet.setSemester(Convert.ToInt32(txtNumOfCoursesIn.Text), txtNameIn.Text, Convert.ToDateTime(calStartDateIn.Text), courseNumComboBox.Text, groupBox1.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //private string txtNumOfCoursesOutNew = SemesterGet.setGetOutputs();
            txtNumOfCoursesOut.Text = Convert.ToString(SemesterGet.GetNumOfCourses);
            txtNameOut.Text = SemesterGet.GetName;
            txtStartDateOut.Text = Convert.ToString(SemesterGet.GetStartDate);
            txtCourseNumOut.Text = SemesterGet.GetCourseNum;
            txtFormatOut.Text = SemesterGet.GetClassFormat;
        }
    }
}
