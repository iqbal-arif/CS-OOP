namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic List!\n");

            var names = new List<string>();
            names.Add("add");
            names.Add("subtact");
            names.Add("divide");

            names[names.Count-1] = "add";

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }
    }
}
