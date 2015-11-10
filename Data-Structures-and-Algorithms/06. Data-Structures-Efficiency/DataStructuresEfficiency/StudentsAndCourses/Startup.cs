namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public const string FilePath = "../../students.txt";

        public static void Main()
        {
            var students = new SortedDictionary<string, SortedSet<Student>>();

            using (FileStream fs = File.Open(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var tokens = line.Split('|')
                        .Select(x => x.Trim())
                        .ToArray();

                    string firstName = tokens[0];
                    string lastName = tokens[1];
                    string course = tokens[2];

                    var student = new Student(firstName, lastName);

                    if (!students.ContainsKey(course))
                    {
                        // Change to OrderedBag if name duplicates are allowed.
                        students.Add(course, new SortedSet<Student>());
                    }

                    students[course].Add(student);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine(string.Format("{0}: {1}", student.Key, string.Join(", ", student.Value)));
            }
        }
    }
}
