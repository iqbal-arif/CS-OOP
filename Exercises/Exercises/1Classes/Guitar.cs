using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._1Classes
{
    class Guitar
    {
        public Guitar(string brand, string type, string shape)
        {
            GuitarBrand = brand;
            GuitarType = type;
            GuitarShape = shape;
        }

        public string GuitarBrand { get; set; }
        public string GuitarType { get; set; }
        public string GuitarShape { get; set; }
    }

    //Guitar Type: Acoustic, Electric , Spanish, Bass, Banjo, Classical
    //Guitar Shapes: Exclusive, ASM, Gunslinger, Dagger, Eagel, Wave, Virgin
}
