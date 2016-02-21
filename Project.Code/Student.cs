using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Student : Person
    {
        public string GPA { get; set; }

        public Student(string firstName, string lastName, string gpa)
            : base(firstName, lastName)
        {
            //property GPA is a member of Student, but not of Person
            this.GPA = gpa;
        }

    }

}
