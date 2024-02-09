


using System.Drawing;

Console.WriteLine("Hello, Zoo!\n");

//OBJECT :
Animal cat = new Animal(4.5);
Animal dog = new Animal(10);

Console.WriteLine(cat.Weight);
Console.WriteLine(dog.Weight);






Console.ReadLine();


class Animal
{
    //CONSTRUCTORS: Sets the state of the Object by assigning values to Properties
    public Animal(double weight)
    {
        //FIELDS: Contains data of the object
        Weight = weight;
    }

    //PROPERTY: 
    public double Weight { get; set; }
}

