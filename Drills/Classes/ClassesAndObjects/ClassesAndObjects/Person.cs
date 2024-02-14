using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Person
    {
        public Person(string name)
        {
            this.name = name;
        }

        public string name; //By default it is private variable
       // public int age; // Public Member
        public static int age;
    }
}
