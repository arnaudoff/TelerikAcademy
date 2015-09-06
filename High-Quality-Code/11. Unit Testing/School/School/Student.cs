namespace School
{
    using System;

    public class Student
    {
        private const int MinValidID = 10000;
        private const int MaxValidID = 99999;

        private int id;
        private string firstName;
        private string lastName;

        public Student(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < MinValidID || value > MaxValidID)
                {
                    throw new ArgumentOutOfRangeException("ID", string.Format("The ID of a student must be in the range [{0}; {1}].", MinValidID, MaxValidID));
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name", "The first name of a student cannot be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name", "The last name of a student cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public void AttendCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            course.RemoveStudent(this);
        }
    }
}
