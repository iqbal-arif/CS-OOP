namespace Employment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employment!\n");

            Employee employeeOne = new Employee();
            Consultant consultantOne= new Consultant(45, 250);

            Console.WriteLine(employeeOne.Name);
            Console.WriteLine(consultantOne.Name);
            Console.WriteLine(consultantOne.HourlyRate);
            Console.WriteLine(consultantOne.HoursReported);
        }
    }

    class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    class Employee : Person
    {
        public Employee() : base("Arif")
        {
            Console.WriteLine(Name);
        }
        public string Department { get; set; }
    }

    class Consultant : Person
    {
        public Consultant(int hourRate, int hourReport) : base("Arif")
        {
            Console.WriteLine(Name);
            Console.WriteLine(HourlyRate);
            Console.WriteLine(HoursReported);
        }
        public decimal HourlyRate { get; set; }
        public int HoursReported { get; set; }
    }
}
