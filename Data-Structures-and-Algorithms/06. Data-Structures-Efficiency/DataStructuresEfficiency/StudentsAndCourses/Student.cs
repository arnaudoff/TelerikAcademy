namespace StudentsAndCourses
{
    using System;

    public class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int CompareTo(Student other)
        {
            var comparisonResult = this.LastName.CompareTo(other.LastName);

            if (comparisonResult == 0)
            {
                comparisonResult = this.FirstName.CompareTo(other.FirstName);
            }

            return comparisonResult;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
