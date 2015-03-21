/*
 * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
 * Rewrite the same with LINQ.
 */

namespace OrderStudents
{
    using System;
    using System.Linq;

    class OrderStudents
    {
        static void Main()
        {
            var listOfStudents = new[]
            {
                new { FirstName = "Yanis", LastName = "Petkov" },
                new { FirstName = "Mitko", LastName = "Todorov" },
                new { FirstName = "Dinko", LastName = "Bashev" },
                new { FirstName = "Djordjano", LastName = "Ivanov"},
                new { FirstName = "Anatolii", LastName = "Angelov"}
            };

            var result = listOfStudents.OrderByDescending(student => student.FirstName)
                                       .ThenByDescending(student => student.LastName);


            Console.WriteLine("LINQ Extension methods: \n");
            foreach (var student in result)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nLINQ: \n");
            var secondResult = from student in listOfStudents
                               orderby student.FirstName descending, student.LastName descending
                               select student;
                

            foreach (var item in secondResult)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
