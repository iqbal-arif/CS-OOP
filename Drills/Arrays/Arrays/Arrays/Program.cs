namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays!\n");

            string[] names = new string[2];
            names[0] = "Arif";
            names[1] = "Iqbal";

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);

           

            string[] authors = { "Brad", "Joe", "Zack" };

            //PrintFirst(authors);
            //PrintLast(authors);
            //AnyItem(authors);

            //Accessing all the items in Array

            for (int i = 0; i < authors.Length; i++)
            {
                string? author = authors[i];
                Console.WriteLine($"{i+1} {author}\n");

            }

            // Reverse the Array

            Array.Reverse(authors);
            
            foreach (string? author in authors)
            {
                Console.WriteLine(author);
            }


        }

        static void PrintFirst(string[] items)
        {
            Console.WriteLine(items[0]);
        }
        
        static void PrintLast(string[] items)
        {
            Console.WriteLine(items[2]);
        }
        
        static void AnyItem(string[] items)
        {
            Console.WriteLine(items[items.Length - 2]);
        }
    }
}
