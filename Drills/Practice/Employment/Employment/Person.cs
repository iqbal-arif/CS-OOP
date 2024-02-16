namespace Employment
{
    class Person : Object
    {
        public Person(string name) : base()
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
