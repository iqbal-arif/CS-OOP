namespace Employment
{
    class Consultant : Person
    {
        public Consultant(string name, decimal hourRate, int hourReport) : base(name)
        {
            HourlyRate = hourRate;
            HoursReported = hourReport;
        }
        public decimal HourlyRate { get; set; }
        public int HoursReported { get; set; }
    }
}
