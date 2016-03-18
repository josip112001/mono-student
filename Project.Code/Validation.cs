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
        public static bool ValidateOperation(string operation)
        {
            if (operation.Equals(Operations.enlist, StringComparison.OrdinalIgnoreCase) || operation.Equals(Operations.display, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {          
                return false;
            }
        }

        //checking if user has inserted empty string
        public static bool ValidateString(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }
            else return true;
        }

        //checking if user has inserted non-numericalvalue for GPA or empty-value
        public static bool ValidateGPA(string gpa)
        {
            float result;
            if (!String.IsNullOrEmpty(gpa) && float.TryParse (gpa,out result))
            {
                    return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
