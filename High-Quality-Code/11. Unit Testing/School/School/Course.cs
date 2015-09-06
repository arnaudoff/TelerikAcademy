namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        public const int MaxStudentsCount = 30;
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name", "The name of a course cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student", "Student cannot be null.");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("Cannot add the same student twice.");
            }

            if (this.Students.Count + 1 > MaxStudentsCount)
            {
                throw new InvalidOperationException("Cannot add a student to a course with max attendees.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Student cannot be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("Cannot remove a student who is not an attendee.");
            }

            this.students.Remove(student);
        }
    }
}