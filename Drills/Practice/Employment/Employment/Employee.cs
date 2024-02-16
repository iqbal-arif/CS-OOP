namespace Employment
{
    class Employee : Person
    {
        public Employee(string name, string department) : base(name)
        {
            Department = department;
        }
        public string Department { get; set; }
    }
}
