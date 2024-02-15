namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Properties!\n");

            Person person = new Person(10, "Chubby"); // CTRL + SHIFT + SPACEBAR to reveal the required parameter

            //Set
            person.Age = 5;
            person.Age = -10;

            //Get Age
            Console.WriteLine("Person Age: " + person.Age);

            //Set
            person.Height = 25;

            //Get Height
            Console.WriteLine("Person Height: " + person.Height);

            //Get Weight
            Console.WriteLine("Person Weight: " + person.Weight);

            //Get BodyType
            Console.WriteLine("Person BodyType: " + person.BodyType);


            
        }
    }
}


//CTRL + F10: To start Debugger
//F11: NEXT STEP
//SHIFT + F5: TO Exit Debugger