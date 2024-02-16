using Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inheritance!");
        Console.WriteLine("Inheritance Implementation in Zoo Project!\n");

        //Animal cat = new Animal(4.5);
        //Animal dog = new Animal(10);

        Cat cat = new Cat();
        Dog dog = new Dog(10);

        Console.WriteLine(cat.Weight);

    }
}

namespace Inheritance
{
    abstract class Animal
    {
        public Animal(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; set; }
    }


    class Cat : Animal
    {
        //The Constructor will not run until it calls the Base constructor to get the weight of the Cat
        public Cat() : base(4.5)
        {
        }

    }

    class Dog : Animal
    {
        //Constructor has two option take the external value or call the base for the weight value.
        public Dog(double weight) : base(weight)
        {

        }

    }
}
