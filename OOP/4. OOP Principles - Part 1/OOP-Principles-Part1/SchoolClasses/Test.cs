/*
 * We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 * Each teacher teaches, a set of disciplines. Students have a name and unique class number. Classes have unique text identifier. Teachers have a name. 
 * Disciplines have a name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
 * Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
 */

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student> 
                                     { 
                                        new Student("Mihail Todorov", 20, "Male", 123123), 
                                        new Student("Djordjano Ivanov", 25, "Male", 1010)
                                     };
            List<Teacher> teachers = new List<Teacher>
                                    {
                                        new Teacher("Bistra Basheva", 70, "Female", new List<Discipline> { new Discipline("Electronics", 14, 0), new Discipline("Electronics - Practice", 0, 14)}),
                                        new Teacher("Daniel Alexandrov", 35, "Male", new List<Discipline> { new Discipline("History", 100, 0) })
                                    };

            List<SchoolClass> schoolclasses = new List<SchoolClass>
                                              {
                                                  new SchoolClass("10B", students, teachers)
                                              };
            School school = new School("ELSYS", schoolclasses);
            Console.WriteLine(school.ToString());
        }
    }
}
