namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, ushort weekSalary, byte workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public ushort WeekSalary { get; set; }

        public byte WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format("First name: {0} Last name: {1} Week salary: {2} WHPD: {3} MPH: {4:F2}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
