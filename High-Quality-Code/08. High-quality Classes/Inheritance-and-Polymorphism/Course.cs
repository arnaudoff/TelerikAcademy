namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;

        protected Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        protected Course(string name, ICollection<Teacher> teachers)
            : this(name)
        {
            if (teachers != null) 
            {
                foreach (var teacher in teachers)
                {
                    this.Teachers.Add(teacher);
                }
            }
        }

        protected Course(string name, ICollection<Teacher> teachers, ICollection<Student> students)
            : this(name, teachers)
        {
            if (students != null)
            {
                foreach (var student in students)
                {
                    this.Students.Add(student);
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validate.Course.IfPropertyIsNullOrWhitespace(value, "name");

                this.name = value;
            }
        }

        public ICollection<Student> Students { get; private set; }

        public ICollection<Teacher> Teachers { get; private set; }

        public override string ToString()
        {
            string students = this.Students.Count > 0 ? string.Join(Environment.NewLine, this.Students) : string.Empty;
            string teachers = this.Teachers.Count > 0 ? string.Join(Environment.NewLine, this.Teachers) : string.Empty;

            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("[{0}]", this.GetType().Name));
            result.AppendLine(string.Format("Name: {0}", this.Name));
            result.AppendLine(string.Format("Teachers: \n{0}", teachers));
            result.AppendLine(string.Format("Students: \n{0}", students));

            return result.ToString();
        }
    }
}
