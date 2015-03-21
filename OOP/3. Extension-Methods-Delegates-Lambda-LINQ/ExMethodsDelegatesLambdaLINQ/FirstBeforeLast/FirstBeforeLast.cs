/*
 * Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
 * Use LINQ query operators.
 */

namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    public class FirstBeforeLast
    {
        static void Main()
        {
            var listOfStudents = new[]
            {
                new { FirstName = "Yanis", LastName = "Petkov" },
                new { FirstName = "Mitko", LastName = "Todorov" },
                new { FirstName = "Dinko", LastName = "Bashev" },
                new { FirstName = "Djordjano", LastName = "Ivanov"}
            };

            var result = from student in listOfStudents
						 where student.FirstName.CompareTo(student.LastName) < 0
						 select student;

            foreach (var item in result)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
