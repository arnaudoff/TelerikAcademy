// Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.

namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telephone;
        private string email;
        private byte groupNumber;

        public Student(string firstName, string lastName, string facultyNumber, byte groupNumber, string telephone, string email, float[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.GroupNumber = groupNumber;
            this.Telephone = telephone;
            this.Email = email;
            this.Marks = new List<float>(marks);
        }

        public string FirstName
        {
            get 
            { 
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name of a student cannot be empty.");
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
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name of a student cannot be empty.");
                }

                this.lastName = value;
            }
        }

        public string FacultyNumber
        {
            get 
            { 
                return this.facultyNumber; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The faculty number of a student cannot be negative.");
                }

                this.facultyNumber = value;
            }
        }

        public string Telephone
        {
            get 
            {
                return this.telephone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The phone number of a student cannot be empty.");
                }
                if (!Regex.IsMatch(value, @"(0[0-9]{9})"))
                {
                    throw new ApplicationException("Phone numbers should contain exactly 10 digits.");
                }

                this.telephone = value;
            }
        }

        public string Email
        {
            get 
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The email of a student cannot be empty.");
                }

                this.email = value;
            }
        }

        public byte GroupNumber
        {
            get 
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("The group number of a student cannot be negative.");
                }

                this.groupNumber = value;
            }
        }

        public List<float> Marks { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
