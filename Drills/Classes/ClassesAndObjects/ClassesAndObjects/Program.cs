namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes & Objects!\n");

            /*
             * 1. By Default every class has an empty construtor
             * 2. By providing name parameter, means it is manditory
             * 3. But age is optional
             * 
             */

            Person person1 = new Person("Bob"); 
            Person person2 = new Person("Lee");

           // person1.name = "Bob"; // Initially defined, but later passed it as a parameter.
            person1.age = 30;

           // person2.name = "Lee";
            person2.age = 40;

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);

        }
    }
}
