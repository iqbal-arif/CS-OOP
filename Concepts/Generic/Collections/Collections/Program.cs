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
            
            //Code wiating for the longest in the Queue

            var queue = new Queue<string>();

            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");

            Console.WriteLine("\nList the long waited Item in the Queue!\n");
            Console.WriteLine(queue.Dequeue() + "\n");

            //Stack list the last itme first in the Queue

            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("\nList the Last Item listed in the Queue Stack!\n");
            Console.WriteLine(stack.Pop() + "\n");

            //Dictionary Key & Value List

            var student = new Dictionary<string, int>();

            student.Add("Arif", 47);
            student.Add("Jack", 32);
            student.Add("Joe", 40);

            Console.WriteLine(student["Arif"]);
            Console.ReadLine();
        }
    }
}
