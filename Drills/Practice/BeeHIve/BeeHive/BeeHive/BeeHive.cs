using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive
{
     class BeeHive
    {
        public BeeHive(QueenBee queen)
        {
            Queen = queen;
            Drones = new List<DroneBee>();
        }

        //Properties
        public QueenBee Queen { get; set; }

        public List<DroneBee> Drones { get; set; }
    }

    class Bee
    {
        public Bee(string name)
        {
            Name = name;
        }

        //Properties
        public string Name { get; set; }
    }

    class QueenBee : Bee
    {
        public QueenBee(string name) : base(name) 
        {
            
        }
    }

    class DroneBee : Bee
    {
        public DroneBee(string name) : base(name) 
        {
            
        }
        //Properties
        public int HoneyCount { get; set; }
    }
}
