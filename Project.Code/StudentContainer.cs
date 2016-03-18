using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        public static List<Student> Students = new List<Student>();

        public static void InsertStudent(string firstName, string lastName, string gpa)
        {
            //inserting new student into list
            Students.Add(new Student(firstName, lastName, gpa));
        }

        public static List<Student> GetStudents()
        {
            SortStudents();
            return Students;
        }

        public static void SortStudents()
        {
            Students = Students.OrderBy(o => o.LastName).ToList();
        }
    }
}
