namespace StudentsAndWorkers
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public double Grade { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0} Last name: {1} Grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
