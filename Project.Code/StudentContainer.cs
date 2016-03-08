using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        static List<Student> Students = new List<Student>();

        public static void InsertStudentIntoList(string firstName, string lastName, string gpa)
        {
            //inserting new student into list
            Students.Add(new Student(firstName, lastName, gpa));
        }

        public static List<Student> DisplayStudentsList()
        {
            return Students;
        }
    }
}
