namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, string town, DateTime birthDate, string[] remarks = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Town = town;
            this.BirthDate = birthDate;
            this.Remarks = remarks;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDate { get; private set; }

        public string Town { get; private set; }

        public string[] Remarks { get; private set; }

        public bool IsOlderThan(Student other)
        {
            return this.BirthDate < other.BirthDate;
        }
    }
}
