// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace AgeRange
{
    using System;
    using System.Linq;

    public class AgeRange
    {
        static void Main()
        {
            var listOfStudents = new[]
            {
                new { FirstName = "Yanis", LastName = "Petkov", Age = 20},
                new { FirstName = "Mitko", LastName = "Todorov", Age = 21},
                new { FirstName = "Dinko", LastName = "Bashev", Age = 12},
                new { FirstName = "Djordjano", LastName = "Ivanov", Age = 50}
            };

            var result = from student in listOfStudents
                         where student.Age >= 18 && student.Age <= 24
                         select new { student.FirstName, student.LastName };

            foreach (var item in result)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
