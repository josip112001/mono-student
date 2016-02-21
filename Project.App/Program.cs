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
        public static string operation = "unknown";
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
                }
                while (Validation.ValidateOperation(operation) == "unknown");

                switch (Validation.ValidateOperation(operation))
                {
                    case "enlist":
                        do
                        {
                            Console.WriteLine("Student");
                            Console.Write("Firstname:");
                            firstname = Console.ReadLine();
                        }
                        while (!Validation.ValidateString(firstname));

                        do
                        {
                            Console.Write("Lastname:");
                            lastname = Console.ReadLine();
                        }
                        while (!Validation.ValidateString(lastname));

                        do
                        {
                            Console.Write("GPA:");
                            gpa = Console.ReadLine();
                        }
                        while (!Validation.ValidateGPA(gpa));
                        // create new student object with data that user have inserted
                        StudentContainer.InsertIntoStudents(firstname, lastname, gpa);
                        break;
                    case "display":
                        StudentContainer.ListAllStudents();
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            while (operation != "display");
        }
    }
}

