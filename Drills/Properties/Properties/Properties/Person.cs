using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {
		//SHCT: propfull

		private int age;

		public int Age
		{
			get { return age; }
			set 
			{
				if (value > 0)
					age = value;
				else
					age = 0;
			}
		}

        //SHCT: prop
		//Autmatic Property : Don't need Validation

        public int Height { get; set; }

		//Constructor

        public Person(int weight, string bodyType)
        {
			Weight = weight;
			//BodyType = bodyType;
        }


        public int Weight { get; private set; }

		
        public string BodyType { get; } = "Muscular";

    }
}

//Use Properties then Public fields