using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Code;


namespace Project.App
{
    class Program
    {
        public static string operation;
        static string firstname;
        static string lastname;
        static string gpa;

        static void Main(string[] args)
        {
            do
            {
                do
                {
                    Console.Write("Operation:");
                    operation = Console.ReadLine();

                    if (!Validation.ValidateOperation(operation))
                    {
                        Console.WriteLine("This operation does not exist");
                    }

                } while (!Validation.ValidateOperation(operation));

                if (operation.Equals(Operations.enlist, StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        Console.WriteLine("Student");
                        Console.Write("Firstname:");
                        firstname = Console.ReadLine();
                        if (!Validation.ValidateString(firstname))
                        {
                            Console.WriteLine("You need to insert value");
                        }
                    } while (!Validation.ValidateString(firstname));

                    do
                    {
                        Console.Write("Lastname:");
                        lastname = Console.ReadLine();
                        if (!Validation.ValidateString(lastname))
                        {
                            Console.WriteLine("You need to insert value");
                        }

                    } while (!Validation.ValidateString(lastname));

                    do
                    {
                        float result;
                        Console.Write("GPA:");
                        gpa = Console.ReadLine();
                        if (String.IsNullOrEmpty(gpa))
                        {
                            Console.WriteLine("You need to insert value");
                        }

                        if (!float.TryParse(gpa, out result) && !String.IsNullOrEmpty(gpa))
                        {
                            Console.WriteLine("You need to insert numerical value");
                        }

                    } while (!Validation.ValidateGPA(gpa));

                    //inserting student into list
                    StudentContainer.InsertStudent(firstname, lastname, gpa);
                }

                else
                {
                    //displaying all students
                    int i = 1;
                    Console.WriteLine("Students in a system:");
                    foreach (Student s in StudentContainer.GetStudents())
                    {
                        Console.WriteLine("{0}.{1},{2} - {3}", i, s.LastName, s.Name, s.GPA.Replace(',', '.'));
                        i++;
                    }
                    Console.ReadLine();
                }
            } while (!operation.Equals(Operations.display, StringComparison.OrdinalIgnoreCase));
        } 
     }
}

  


