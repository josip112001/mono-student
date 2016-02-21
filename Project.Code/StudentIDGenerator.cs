using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        //static field currentID stores the ID of the last 
        //person that has been created
        private static int currentID;

        public static int CreatePersonId()
        {
            return ++currentID;
        }

    }
}
