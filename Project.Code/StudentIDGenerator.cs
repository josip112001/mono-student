using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{ 
    public class StudentIdGenerator
    {
        private static int id = 0;
        private static StudentIdGenerator currentID;
        private StudentIdGenerator() { }
        public  StudentIdGenerator CurrentID
        {
            get
            {
                if (currentID == null)
                {
                    currentID = new StudentIdGenerator();
                }
                return currentID;
            }
        }

        public static int ID()
        {
            return id++;
        }
    }
}
