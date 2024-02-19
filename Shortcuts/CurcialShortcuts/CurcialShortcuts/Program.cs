

using System.Threading.Channels;

namespace CurcialShortcuts
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curcial Shortcuts\n!");
            Console.WriteLine();
            
            MethodShortcut();

            MethodWithParameter("Shortcut");

            Person.CelebrateBirthday();
        }

        private static void MethodWithParameter(string v)
        {
            Console.WriteLine("ALT+Enter Key for Options");
            Console.WriteLine("F9 Key for Debug Mark");
            Console.WriteLine("F5 Key for Debugging");
            Console.WriteLine("F11 Key for STEP-IN");
            Console.WriteLine("SHITF + F11 Key for STEP-OUT");
            Console.WriteLine("SHITF + F10 Key for STEP-OVER");
        }

        private static void MethodShortcut()
        {
            Console.WriteLine( "cla for class\n");
            Console.WriteLine( "cla for class\n");
        }

    
    }

    class CodeSnipptes()
    {
      
        
    }
}
