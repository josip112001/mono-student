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
        static void Main(string[] args)
        {
            string operation;
            string firstname;
            string lastname;
            string gpa;
            bool isValid;

            do
            {
                do
                {
                    Console.Write("Operation:");
                    operation = Console.ReadLine();
                    if (!Validation.ValidateOperation(operation))
                    {
                        isValid = false;
                        Console.WriteLine("This operation does not exist");
                    }
                    else
                    {
                        isValid = true;
                    }
                } while (!isValid);

                if (operation.Equals(Operations.enlist, StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        Console.WriteLine("Student");
                        Console.Write("Firstname:");
                        firstname = Console.ReadLine();
                        if (!Validation.ValidateString(firstname))
                        {
                            isValid = false;
                            Console.WriteLine("You need to insert value");
                        }
                        else
                        {
                            isValid = true;
                        }
                    } while (!isValid);

                    do
                    {
                        Console.Write("Lastname:");
                        lastname = Console.ReadLine();
                        if (!Validation.ValidateString(lastname))
                        {
                            isValid = false;
                            Console.WriteLine("You need to insert value");
                        }
                        else
                        {
                            isValid = true;
                        }
                    } while (!isValid);

                    do
                    {
                        float result;
                        Console.Write("GPA:");
                        gpa = Console.ReadLine();
                        if (String.IsNullOrEmpty(gpa))
                        {
                            isValid = false;
                            Console.WriteLine("You need to insert value");
                        }

                        else if (!float.TryParse(gpa, out result) && !String.IsNullOrEmpty(gpa))
                        {
                            isValid = false;
                            Console.WriteLine("You need to insert numerical value");
                        }
                        else
                        {
                            isValid = true;
                        }
                    } while (!isValid);

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

  


