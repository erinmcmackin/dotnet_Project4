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
            // disable Get button until Set click method passes
            btnGet.Enabled = false;
        }

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

        // when Set button is clicked, pass values from inputs to SemesterSet class
        private void btnSet_Click(object sender, EventArgs e)
        {
            // verify Number of Courses is numeric
            try
            {
                Convert.ToInt32(txtNumOfCoursesIn.Text);
                // found the .Value method on Microsoft's Developer community: https://social.msdn.microsoft.com/Forums/en-US/0902ba30-479e-4c2e-bd06-4a03f52e1cdd/quick-way-of-getting-day-and-month-and-year-from-datetimepicker-component?forum=clr
                if (calStartDateIn.Value.Month != 1 || calStartDateIn.Value.Year != 2019)
                {
                    MessageBox.Show("Please choose a start date in January 2019");
                    txtNumOfCoursesIn.Focus();
                }

                // ensure Class Format option is selected
                else if (radioHybrid.Checked == false && radioOnline.Checked == false)
                {
                    MessageBox.Show("Please select a class format");
                    txtNumOfCoursesIn.Focus();
                }

                // ensure name includes space
                else if (!txtNameIn.Text.Contains(" "))
                {
                    MessageBox.Show("You must include your first and last names, separated with a space");
                    txtNumOfCoursesIn.Focus();
                }

                else
                {
                    // capture value of Class Format radio buttons
                    string classFormatCheck;
                    if (radioHybrid.Checked == true)
                    {
                        classFormatCheck = "Hybrid";
                    }
                    else
                    {
                        classFormatCheck = "Online";
                    }

                    // if all exceptions pass, continue to SemesterSet class
                    SemesterSet.setSemester(Convert.ToInt32(txtNumOfCoursesIn.Text), txtNameIn.Text, Convert.ToDateTime(calStartDateIn.Text), courseNumComboBox.Text, classFormatCheck);
                    // enable Get button
                    btnGet.Enabled = true;
                }
            }
            
            // alert user of Format Exception
            catch (FormatException)
            {
                MessageBox.Show("Number of Courses must be a numeric value", "Entry Error");
                txtNumOfCoursesIn.Focus();
            }

            // alert user of Overflow Exception
            catch (OverflowException)
            {
                MessageBox.Show("The number of courses you entered is too large. Please enter a smaller value");
                txtNumOfCoursesIn.Focus();
            }

        }


        // when Get button is clicked, pass values from SemesterSet class to SemesterGet class
        private void btnGet_Click(object sender, EventArgs e)
        {
            txtNumOfCoursesOut.Text = Convert.ToString(SemesterGet.GetNumOfCourses);
            txtNameOut.Text = SemesterGet.GetName;
            txtStartDateOut.Text = Convert.ToString(SemesterGet.GetStartDate);
            txtCourseNumOut.Text = SemesterGet.GetCourseNum;
            txtFormatOut.Text = SemesterGet.GetClassFormat;

            // alert the user that they have updated the course number in the SemesterGet class
            MessageBox.Show("You have updated the course number to " + txtCourseNumOut.Text);
        }
    }
}
