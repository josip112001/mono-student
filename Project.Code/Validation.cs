using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {
        //checking if user has inserted non-existing operation
        public static string ValidateOperation(string operation)
        {
            if (operation.Equals(Operations.enlist, StringComparison.OrdinalIgnoreCase))
            {
                operation = "enlist";
                return operation;
            }
            else if (operation.Equals(Operations.display, StringComparison.OrdinalIgnoreCase))
            {
                operation = "display";
                return operation;
            }
            else
            {
                Console.WriteLine("This operation does not exist");
                operation = "unknown";
                return operation;
            }
        }
        //checking if user has inserted empty string
        public static bool ValidateString(string input)
        {
            if (input == "")
            {
                Console.WriteLine("You need to insert value.");
                return false;
            }
            else return true;
        }
        //checking if user has inserted non-numericalvalue for GPA or empty-value
        public static bool ValidateGPA(string gpa)
        {
            float result;
            if (gpa != "")
            {
                if (float.TryParse(gpa, out result))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("You need to insert numerical value.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("You need to insert value");
                return false;
            }
        }
    }
}
