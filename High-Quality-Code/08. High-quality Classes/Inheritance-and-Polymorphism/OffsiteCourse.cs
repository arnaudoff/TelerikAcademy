namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name, IList<Teacher> teachers, IList<Student> students, string town)
            : base(name, teachers, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                Validate.Course.IfPropertyIsNullOrWhitespace(value, "town");

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine("Town: " + this.Town);

            return result.ToString();
        }
    }
}
