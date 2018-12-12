using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erin_mcmackin_project4
{
    public class SemesterSet
    {
        // declaring the variables
        private static int NumOfCourses;
        private static string Name;
        private static DateTime StartDate;
        private static string CourseNum;
        private static string ClassFormat;

        // when Set button is clicked, assigning value to SemesterSet class variables
        public static void setSemester(int numOfCourses, string name, DateTime startDate, string courseNum, string classFormat)
        {
            NumOfCourses = numOfCourses;
            Name = name;
            StartDate = startDate;
            CourseNum = courseNum;
            ClassFormat = classFormat;

            // Passing variable values to SemesterGet class
            SemesterGet.getSemester(NumOfCourses, Name, StartDate, CourseNum, ClassFormat);
        }
    }


}
