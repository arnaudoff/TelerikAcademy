namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private ICollection<Student> students;
        private ICollection<Course> courses;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "The name of a school cannot be null or empty.");
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

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Student cannot be null.");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student already exists.");
            }

            if (this.students.Any(x => x.ID == student.ID)) 
            {
                throw new InvalidOperationException("There is an existing student with this ID.");
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
                throw new InvalidOperationException("The student specified does not exist in the list of students.");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course already exists.");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("The course specified does not exist in the list of courses.");
            }

            this.courses.Remove(course);
        }
    }
}