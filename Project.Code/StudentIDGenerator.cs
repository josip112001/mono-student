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
        private static StudentIdGenerator idGenerator;
        private StudentIdGenerator() { }
        public static StudentIdGenerator IdGenerator          
        {
            get
            {
                if (idGenerator == null)
                {
                    idGenerator  = new StudentIdGenerator();
                }
                return idGenerator;
            }
        }

        public int GetNextID()                     
        {
            return id++;
        }
    }
}
