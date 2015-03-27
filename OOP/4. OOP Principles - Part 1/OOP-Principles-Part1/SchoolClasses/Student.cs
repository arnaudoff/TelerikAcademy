namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Student : People
    {
        public Student(string fullname, byte age, string gender, int ucn)
        {
            this.Fullname = fullname;
            this.Age = age;
            this.Gender = gender;
            this.UniqueClassNumber = ucn;
        }

        public int UniqueClassNumber { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1} Gender: {2} UCN: {3}", this.Fullname, this.Age, this.Gender, this.UniqueClassNumber);
        }
    }
}
