namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School
    {
        public School(string name, List<SchoolClass> schoolClasses)
        {
            this.Name = name;
            this.SchoolClasses = schoolClasses;
        }

        public string Name { get; set; }

        public List<SchoolClass> SchoolClasses { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \nSchool classes: {1}\n", this.Name, string.Join(", ", this.SchoolClasses));
        }
    }
}
