using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._1Classes
{
    class Guitar
    {
        public Guitar(Brand brand, string type, string shape,int price)
        {
            GuitarBrand = brand;
            GuitarType = type;
            GuitarShape = shape;
            Price = price;

        }

        public Brand GuitarBrand { get; set; }
        public string GuitarType { get; set; }
        public string GuitarShape { get; set; }
        public int Price { get; set;}
    }

    //Guitar Type: Acoustic, Electric , Spanish, Bass, Banjo, Classical
    //Guitar Shapes: Exclusive, ASM, Gunslinger, Dagger, Eagel, Wave, Virgin
}
