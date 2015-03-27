namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        public Teacher(string fullName, byte age, string gender, List<Discipline> disciplines)
        {
            this.Fullname = fullName;
            this.Age = age;
            this.Gender = gender;
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1} Gender: {2} Disciplines: {3}", this.Fullname, this.Age, this.Gender, string.Join(", ", this.Disciplines));
        }
    }
}
