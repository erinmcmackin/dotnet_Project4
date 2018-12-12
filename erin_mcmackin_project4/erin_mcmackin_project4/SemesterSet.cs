using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erin_mcmackin_project4
{
    public class SemesterSet
    {
        private static int NumOfCourses;
        private static string Name;
        private static DateTime StartDate;
        private static string CourseNum;
        private static string ClassFormat;

        //public SemesterSet(int numOfCourses, string name, DateTime startDate, string courseNum, string ClassFormat)
        //{
        //     this.NumOfCourses = numOfCourses;
        //    this.Name = name;
        //    this.StartDate = startDate;
        //     this.CourseNum = courseNum;
        //      this.ClassFormat = ClassFormat;
        //  }

        //  public static string getNumOfCourses()
        //  {
        // return Convert.ToString(SemesterSet.NumOfCourses);
        //}
        //
        public static void setSemester(int numOfCourses, string name, DateTime startDate, string courseNum, string classFormat)
        {
            NumOfCourses = numOfCourses;
            Name = name;
            StartDate = startDate;
            CourseNum = courseNum;
            ClassFormat = classFormat;

            SemesterGet.getSemester(NumOfCourses, Name, StartDate, CourseNum, ClassFormat);
        }
    }


}
