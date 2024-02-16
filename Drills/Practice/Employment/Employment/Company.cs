using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    //class Company : Person
    class Company 
    {

       // public Company(string name, List<string> employee, List<string> consultant ) : base(name)
        public Company(string name)
        {
            Name = name;
           // Employee = new List<string>(employee);
            Employees = new List<Employee>();
           // Consultant = new List<string>(consultant);
            
        }
        //NOTE: The construtor field can also be placed in Properites next to Get & Set 

        public string Name { get; set; }
       // public  List<string> Employee { get; set; }
        public  List<Employee> Employees { get; set; }
       // public List<string> Consultant { get; set; }
        public List<Consultant> Consultants { get; set; } = new List<Consultant>();
    }
}
