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
        public static void InsertIntoStudents(string firstName, string lastName, string gpa)
        {
            //inserting new student into list
            Students.Add(new Student(firstName, lastName, gpa));
        }

        public static void ListAllStudents()
        {
            int i = 1;
            //listing all students in list
            foreach (Student s in Students.OrderBy(o => o.LastName).ToList())
            {
                Console.WriteLine("{0}.{1},{2} - {3}", i, s.LastName, s.Name, s.GPA.Replace(',', '.'));
                i++;
            }
        }
    }
}
