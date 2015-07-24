namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            var highQualityCodeStudents = new List<Student>();

            Student ivan = new Student("Ivan", "Petrov", 20);
            Student maria = new Student("Maria", "Georgieva", 18);

            highQualityCodeStudents.Add(ivan);
            highQualityCodeStudents.Add(maria);

            var highQualityCodeTeachers = new List<Teacher>();

            Teacher kenov = new Teacher("Ivaylo", "Kenov", 1337);
            Teacher kostov = new Teacher("Nikolay", "Kostov", 666);

            highQualityCodeTeachers.Add(kenov);
            highQualityCodeTeachers.Add(kostov);

            LocalCourse highQualityCode = new LocalCourse("High quality code", highQualityCodeTeachers, highQualityCodeStudents, "Ultimate");
            Console.WriteLine(highQualityCode);

            var systemAdministrationStudents = new List<Student>();
            
            systemAdministrationStudents.Add(ivan);
            systemAdministrationStudents.Add(maria);

            var systemAdministrationTeachers = new List<Teacher>();

            Teacher krokodila = new Teacher("Vasil", "Kolev", 1337);
            Teacher hackman = new Teacher("Marian", "Marinov", 666);

            systemAdministrationTeachers.Add(krokodila);
            systemAdministrationTeachers.Add(hackman);

            OffsiteCourse systemAdministration = new OffsiteCourse("System administration", systemAdministrationTeachers, systemAdministrationStudents, "Durankulak");
            Console.WriteLine(systemAdministration);
        }
    }
}
