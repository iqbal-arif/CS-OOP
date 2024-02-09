using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._1Classes
{
    public class Exercise
    {
        public static void  Start()
        {
            Console.WriteLine("****CLASSES MODULE****\n");
            Console.WriteLine("EX-1: Class Guitar with Three Paramter...\n");

            Guitar guitarOne = new Guitar(Brand.Gibson, "Acoustic", "Dagger",1000);
            Guitar guitarTwo = new Guitar(Brand.Fender, "Electric", "Eagel", 2000);

            /*
            Console.WriteLine("Ex1: Class Guitar\n");
            Console.WriteLine(guitarOne.GuitarType);
            Console.WriteLine(guitarTwo.GuitarBrand);
            Console.WriteLine(guitarTwo.GuitarType);
            */
            /**********************************************************************/

            Console.WriteLine("\nEX-2: Class Musicaian with Two Paramter...\n");

            //The OBJECT can take signle variable as int, string, bool or an Object as a parameter

           // Musician jackson = new Musician("Jackson", guitarOne);
            Musician jackson = new Musician("Jackson", new Guitar(Brand.Gibson, "Acoustic", "Dagger", 1000));
            Musician eminem = new Musician("Eminem", guitarTwo);

            Console.WriteLine("Ex2: Class Musician\n");

            jackson.Play();
            eminem.Play();

        }
            
    }

    enum Brand
    {
        Fender, // default int value 0
        Gibson, // 1
        Ibanez  // 2
    }



}
