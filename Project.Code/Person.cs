using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    abstract public class Person
    {
        //Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        //Instance constructor that has three parameters.
        public Person(string firstName, string lastName)
        {


            this.ID = StudentIdGenerator.IdGenerator.GetNextID();
            this.Name = firstName;
            this.LastName = lastName;
        }
    }
}
