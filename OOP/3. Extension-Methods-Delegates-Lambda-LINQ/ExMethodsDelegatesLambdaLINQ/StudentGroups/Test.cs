namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Gosho", "Ivanov", "123105", 3, "0288888888", "gosho_svalq4a@abv.bg", new[] { 4.50f, 3.20f, 4.20f, 6.00f }));
            students.Add(new Student("Pesho", "Petkanov", "123106", 2, "0887628189", "pesho_igra4a@mail.bg", new[] { 2.50f, 2.75f, 4.25f, 5.50f }));
            students.Add(new Student("Asen", "Qnkov", "123106", 3, "0288388383", "asenkata493284823984@gmail.com", new[] { 2.00f, 2.00f, 2.50f, 2.50f }));

            /*
             * Create a List<Student> with sample students. Select only the students that are from group number 2.
             * Use LINQ query. Order the students by FirstName.
             */

            var result = from student in students
                         where student.GroupNumber == 2
                         orderby student.FirstName ascending
                         select student;

            Console.WriteLine("LINQ: \n");

            foreach (var student in result)
            {
                Console.WriteLine("First name: {0} Last name: {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nLINQ with extension methods: \n");

            // Implement the previous using the same query expressed with extension methods.

            var secondResult = students.Where(student => student.GroupNumber == 2)
                                       .OrderBy(student => student.FirstName);

            foreach (var student in secondResult)
            {
                Console.WriteLine("First name: {0} Last name: {1}", student.FirstName, student.LastName);
            }

            // Extract all students that have email in abv.bg.Use string methods and LINQ.

            var emailResult = students.Where(student => student.Email.Substring(student.Email.IndexOf("@") + 1) == "abv.bg")
                                      .OrderBy(student => student.FirstName);

            Console.WriteLine("\nStudents with email provider \"abv.bg\": \n");
            foreach (var student in emailResult)
            {
                Console.WriteLine("First name: {0} Last name: {1} Email: {2}", student.FirstName, student.LastName, student.Email);
            }

            // Extract all students with phones in Sofia. Use LINQ.

            var phonesResult = students.Where(student => student.Telephone.StartsWith("02"))
                                       .OrderBy(student => student.FirstName);

            Console.WriteLine("\nStudents with phone numbers from \"Sofia\": \n");
            foreach (var student in phonesResult)
            {
                Console.WriteLine("First name: {0} Last name: {1} Phone: {2}", student.FirstName, student.LastName, student.Telephone);
            }

            // Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.

            var excellentMarkResult = from student in students
                                      where student.Marks.Contains(6)
                                      select new {FullName = String.Format("{0} {1}", student.FirstName, student.LastName), Marks = student.Marks};

            Console.WriteLine("\nStudents with excellent marks: \n");
            foreach (var student in excellentMarkResult)
            {
                Console.WriteLine(String.Format("Full name: {0} Marks: {1}", student.FullName, String.Join(", ", student.Marks)));
            }

            // Write down a similar program that extracts the students with exactly two marks "2". Use extension methods.

            Console.WriteLine("\nStudents with exactly two marks \"2\": \n");
            var twoPoorMarksResult = students.Where(student => student.Marks.Count(mark => mark == 2) == 2);
            foreach (var student in twoPoorMarksResult)
            {
                Console.WriteLine("First name: {0} Last name: {1} -> {2}", student.FirstName, student.LastName, String.Join(", ", student.Marks));
            }
            
            // Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            var marksByYearResult = students.Where(student => student.FacultyNumber[4] == '0' && student.FacultyNumber[5] == '6');
            Console.WriteLine("\nMarks of students enrolled in 2006: \n");
            foreach (var student in marksByYearResult)
            {
                Console.WriteLine("First name: {0} Last name: {1} Marks: {2}", student.FirstName, student.LastName, String.Join(", ", student.Marks));
            }

            // Extract all students from "Mathematics" department. Use the Join operator.
            var groups = new List<Group>
			             {
							 new Group(1, "Informatics"),
                             new Group(2, "Computer science"),
							 new Group(3, "Mathematics"),
							 new Group(4, "Software engineering"),
			             };

            var mathsDepartmentResult = from student in students
                                        join group_ in groups on student.GroupNumber equals group_.GroupNumber
                                        where group_.DepartmentName == "Mathematics"
                                        select student;

            Console.WriteLine("\nStudents from the \"Mathematics\" deparment: \n");
            foreach (var student in mathsDepartmentResult)
            {
                Console.WriteLine("First name: {0} Last name: {1}", student.FirstName, student.LastName);
            }
            
            // Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.

            var groupsResult = from stud in students
                               group stud by stud.GroupNumber;

            Console.WriteLine("\nStudents by groups (LINQ): \n");
            foreach (var group in groupsResult)
            {
                    Console.WriteLine(String.Format("Group {0}: {1}", group.ElementAt(0).GroupNumber, String.Join(", ", group)));
            }

            // Rewrite the previous using extension methods.

            var groupsResultExtensions = students.GroupBy(x => x.GroupNumber);

            Console.WriteLine("\nStudents by groups (Extensions): \n");
            foreach (var group in groupsResultExtensions)
            {
                Console.WriteLine(String.Format("Group {0}: {1}", group.ElementAt(0).GroupNumber, String.Join(", ", group)));
            }
        }
    }
}
