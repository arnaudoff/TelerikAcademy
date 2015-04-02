namespace StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable
    {
        public Student()
        {

        }
        public Student(string firstName, string middleName, string lastName,
                       int ssn, string address, string mobilePhone, string email, string course,
                       University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public int SSN { get; private set; }

        public string Address { get; private set;}

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public string Course { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        public Specialty Specialty { get; private set; }

        public override bool Equals(object obj)
        {
            // Probably can be improved with a bit of reflection tricks
            if (this.FirstName == (obj as Student).FirstName &&
                this.MiddleName == (obj as Student).MiddleName &&
                this.LastName == (obj as Student).LastName &&
                this.SSN == (obj as Student).SSN &&
                this.Address == (obj as Student).Address &&
                this.MobilePhone == (obj as Student).MobilePhone &&
                this.Email == (obj as Student).Email &&
                this.Course == (obj as Student).Course &&
                this.University == (obj as Student).University &&
                this.Faculty == (obj as Student).Faculty &&
                this.Specialty == (obj as Student).Specialty)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1 == s2);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(string.Format("SSN: {0}", this.SSN));
            result.AppendLine(string.Format("Address: {0}", this.Address));
            result.AppendLine(string.Format("Mobile phone: {0}", this.MobilePhone));
            result.AppendLine(string.Format("Email: {0}", this.Email));
            result.AppendLine(string.Format("Course: {0}", this.Course));
            result.AppendLine(string.Format("University: {0}", this.University));
            result.AppendLine(string.Format("Faculty: {0}", this.Faculty));
            result.AppendLine(string.Format("Specialty: {0}", this.Specialty));

            return result.ToString();
        }

        // This is a poor hash code generator. It fails if two instances of the student class have the same SSN and mobile phone.
        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.MobilePhone.GetHashCode();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
                                               this.MobilePhone, this.Email, this.Course, this.University, this.Faculty, this.Specialty);
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }

            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }

            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }
    }
}
