namespace SchoolClasses
{
    using System.Collections.Generic;

    public class SchoolClass
    {
        public SchoolClass(string textID, List<Student> students, List<Teacher> teachers)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.TextID = textID;
        }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public string TextID { get; set; }

        public override string ToString()
        {
            return string.Format("Class {0} \nStudents: \n{1}\nTeachers: \n{2}", this.TextID, string.Join("\n", this.Students), string.Join("\n", this.Teachers));
        }
    }
}
