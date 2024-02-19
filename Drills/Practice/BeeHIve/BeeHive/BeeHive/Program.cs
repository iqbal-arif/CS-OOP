namespace BeeHive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BeeHive!\n");

            BeeHive hive = new BeeHive(new QueenBee("Queen"));

            hive.Drones.Add(new DroneBee("Buzzy"));
            hive.Drones.Add(new DroneBee("Fuzzy"));
            hive.Drones.Add(new DroneBee("Kuzzy"));
          

        }
    }
}
