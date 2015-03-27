/*
 * Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
 * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
 * Initialize a list of 10 workers and sort them by money per hour in descending order.
 * Merge the lists and sort them by first name and last name.
 */

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        static void Main()
        {
            var students = new List<Student>
			               {
				               new Student("Pesho", "Vasilev", 3.46),
							   new Student("Gosho", "Petrakiev", 2.98),
							   new Student("Dragan", "Tzvetkov", 4.5),
							   new Student("Emil", "Kodjabashev", 5.6),
							   new Student("Vasil", "Dragoev", 3.78),
							   new Student("Petko", "Atanasov", 3.9),
							   new Student("Merhat", "Petrakiev", 5.46),
							   new Student("Todor", "Petrovski", 2.49),
							   new Student("Anton", "Georgiev", 2.34),
							   new Student("Martin", "Tsvetanov", 4.76),
							   new Student("Marin", "Apostolov", 6.00)
			               };

            var sortedStudents = students.OrderBy(st => st.Grade);
            Console.WriteLine("Sorted students: \n");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            var workers = new List<Worker>
			               {
				               new Worker("Pesho", "Vasilev", 127, 8),
							   new Worker("Gosho", "Petrakiev", 134, 7),
							   new Worker("Dragan", "Tzvetkov", 154, 8),
							   new Worker("Emil", "Kodjabashev", 257, 8),
							   new Worker("Vasil", "Dragoev", 327, 7),
							   new Worker("Petko", "Atanasov", 167, 8),
							   new Worker("Merhat", "Petrakiev", 137, 6),
							   new Worker("Todor", "Petrovski", 267, 8),
							   new Worker("Anton", "Georgiev", 231, 9),
							   new Worker("Martin", "Tsvetanov", 90, 6),
							   new Worker("Marin", "Apostolov", 126, 9)
			               };

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("Sorted workers: \n");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            var mergedList = new List<Human>();
            mergedList.AddRange(sortedStudents);
            mergedList.AddRange(sortedWorkers);

            var sortedList = mergedList.OrderBy(x => x.FirstName)
                                       .ThenBy(x => x.LastName);

            Console.WriteLine("Merged and sorted list of students and workers: \n");
            foreach (var human in sortedList)
            {
                Console.WriteLine(human);
            }
        }
    }
}
