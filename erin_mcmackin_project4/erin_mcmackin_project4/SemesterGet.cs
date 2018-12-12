using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erin_mcmackin_project4
{
    public class SemesterGet
    {
        public static int GetNumOfCourses;
        public static string GetName;
        public static DateTime GetStartDate;
        public static string GetCourseNum;
        public static string GetClassFormat;

        public static void setGetOutputs()
        {
            //System.Windows.Forms.MessageBox.Show("haiii");
            // public string name = SemesterSet.getNumOfCourses();

        }

        public static void getSemester(int numOfCourses, string name, DateTime startDate, string courseNum, string classFormat)
        {
            GetNumOfCourses = numOfCourses;
            GetName = name;
            GetStartDate = startDate;
            GetCourseNum = courseNum;
            GetClassFormat = classFormat;
        }
    }
}
