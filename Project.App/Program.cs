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
        static bool flag = false;

        static void Main(string[] args)
        {
            do
            {
                do
                {
                    if (flag)
                    {
                        Console.WriteLine("This operation does not exist");
                    }
                    Console.Write("Operation:");
                    operation = Console.ReadLine();
                    flag = true;
                }
                while (!Validation.ValidateOperation(operation));
                flag = false;
                switch (Validation.validatedOperation)
                {
                    case Operations.enlist:
                        do
                        {
                            if (flag)
                            {
                                Console.WriteLine("You need to insert value");
                            }
                            Console.WriteLine("Student");
                            Console.Write("Firstname:");
                            firstname = Console.ReadLine();
                            flag = true;
                        }
                        while (!Validation.ValidateString(firstname));
                        flag = false;
                        do
                        {
                            if (flag)
                            {
                                Console.WriteLine("You need to insert value");
                            }
                            Console.Write("Lastname:");
                            lastname = Console.ReadLine();
                            flag = true;
                        }
                        while (!Validation.ValidateString(lastname));
                        flag = false;
                        do
                        {
                            if (Validation.err == 1)
                            {
                                Console.WriteLine("You need to insert numerical value");
                            }
                            if (Validation.err == 2)
                            {
                                Console.WriteLine("You need to insert value");
                            }
                            Console.Write("GPA:");
                            gpa = Console.ReadLine();
                            flag = true;
                        }
                        while (!Validation.ValidateGPA(gpa));
                        flag = false;

                        // create new student object with data that user have inserted
                        StudentContainer.InsertStudentIntoList(firstname, lastname, gpa);
                        break;
                    case Operations.display:
                        //displaying all students from list
                        int i = 1;
                        Console.WriteLine("Students in a system:");
                        foreach (Student s in StudentContainer.DisplayStudentsList().OrderBy(o => o.LastName).ToList())
                        {
                            Console.WriteLine("{0}.{1},{2} - {3}", i, s.LastName, s.Name, s.GPA.Replace(',', '.'));
                            i++;
                        }
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            while (operation != Operations.display);
        }
    }        
}
  


