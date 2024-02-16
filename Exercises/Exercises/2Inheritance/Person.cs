using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._2Inheritance
{
    class Person : Object
    {
        //Constructor
        public Person(string name) : base()
        {
            Name = name;
        }
        //Property
        public string  Name { get; set; }
    }
}
