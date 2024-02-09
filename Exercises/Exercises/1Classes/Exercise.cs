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

            Guitar guitarOne = new Guitar("Gibson", "Acoustic", "Dagger");
            Guitar guitarTwo = new Guitar("Fender", "Electric", "Eagel");


            Console.WriteLine("Ex1: Class Guitar\n");
            Console.WriteLine(guitarOne.GuitarBrand);
            Console.WriteLine(guitarOne.GuitarType);
            Console.WriteLine(guitarTwo.GuitarBrand);
            Console.WriteLine(guitarTwo.GuitarType);


      

        }
            
    }





}
