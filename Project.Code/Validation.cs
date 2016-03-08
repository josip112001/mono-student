using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {
        public static string validatedOperation;
        public static int err;

        //checking if user has inserted non-existing operation
        public static bool ValidateOperation(string validOperation)
        {
            if (validOperation.Equals(Operations.enlist, StringComparison.OrdinalIgnoreCase))
            {
                validatedOperation = Operations.enlist;
                return true;
            }
            else if (validOperation.Equals(Operations.display, StringComparison.OrdinalIgnoreCase))
            {
                validatedOperation = Operations.display;
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
            err = 0;
            if (!String.IsNullOrEmpty(gpa))
            {
                if (float.TryParse(gpa, out result))
                {
                    return true;
                }
                else
                {
                    err = 1;
                    return false;
                }
            }
            else
            {
                err = 2;
                return false;
            }
        } 
    }
}
