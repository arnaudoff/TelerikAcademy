namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name, IList<Teacher> teachers, IList<Student> students, string lab)
            : base(name, teachers, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                Validate.Course.IfPropertyIsNullOrWhitespace(value, "lab");

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine("Lab: " + this.Lab);

            return result.ToString();
        }
    }
}
