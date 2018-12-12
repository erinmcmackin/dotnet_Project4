using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erin_mcmackin_project4
{
    public class SemesterGet
    {
        // declaring the variables
        public static int GetNumOfCourses;
        public static string GetName;
        public static DateTime GetStartDate;
        public static string GetCourseNum;
        public static string GetClassFormat;

        // when the Get button is clicked, pull values from SemesterSet class and assign to SemesterGet class variables
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
