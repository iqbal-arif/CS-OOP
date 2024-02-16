using System.Threading.Channels;

namespace Employment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employment!\n");

            Employee employeeOne = new Employee("Arif", "Research");
            Consultant consultantOne= new Consultant("Iqbal", 45, 250);
           // Company company = new Company("Dell", new List<string>() { "Jack" }, new() { "Joe" });
           Company company = new Company("Dell");
            company.Employees.Add(new Employee("Jack", "HR"));
            company.Employees.Add(new Employee("Joe", "HR"));
            company.Employees.Add(new Employee("Jim", "Sales"));
            company.Consultants.Add(new Consultant("Mark", 80, 15));

            Console.WriteLine("Employee : {0} is hired in {1} Departement.", employeeOne.Name, employeeOne.Department);
            Console.WriteLine();
            Console.WriteLine("Consultant : {0} reprted {1} hours and his hourly rate are {2}.", consultantOne.Name,consultantOne.HoursReported,consultantOne.HourlyRate);
            Console.WriteLine();

            Console.WriteLine(company.Employees.Count);
            Console.WriteLine(company.Consultants.Count);
        }
    }
}
