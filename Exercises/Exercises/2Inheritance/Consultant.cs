using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._2Inheritance
{
    class Consultant : Person
    {
        public Consultant(string name, decimal hourlyRate, int hoursReported ) :  base(name)
        {
            HourlyRate = hourlyRate;
            HoursReported = hoursReported;
        }

        public decimal HourlyRate { get; set; }

        public int HoursReported { get; set; }
    }
}
