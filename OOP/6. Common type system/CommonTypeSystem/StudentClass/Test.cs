namespace StudentClass
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student gosho = new Student("Gosho", "Ivanov", "Petkov", 2048, "Sofia", "0888888888", "goshetyy@abv.bg", "First", University.Sofia_University, Faculty.Informatics, Specialty.Computer_Science);
            students.Add(gosho);
            Student pesho = new Student("Pesho", "Ivanov", "Petkov", 211, "Sofia", "0888888889", "peshety6969@abv.bg", "First", University.Sofia_University, Faculty.Informatics, Specialty.Computer_Science);
            // The overriden Equals() should return false as some of the properties don't match hence the overloaded "==" also returns false
            students.Add(pesho);
            students.Sort();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
