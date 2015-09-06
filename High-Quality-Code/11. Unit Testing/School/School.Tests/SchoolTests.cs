namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowWhenNameIsNull()
        {
            School telerikAcademy = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowWhenNameIsEmpty()
        {
            School telerikAcademy = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowWhenAddedStudentIsNull()
        {
            School telerikAcademy = new School("TelerikAcademy");

            telerikAcademy.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowWhenAddedStudentAlreadyExists()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            telerikAcademy.AddStudent(gosho);
            telerikAcademy.AddStudent(gosho);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowWhenAddedStudentsHaveTheSameId()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Student gosho = new Student(10000, "Georgi", "Petrov");
            Student pesho = new Student(10000, "Petar", "Georgiev");

            telerikAcademy.AddStudent(gosho);
            telerikAcademy.AddStudent(pesho);
        }

        [TestMethod]
        public void SchoolShouldAddStudentsCorrectly()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            telerikAcademy.AddStudent(gosho);

            Assert.AreEqual(1, telerikAcademy.Students.Count, "Adding a new student should accordingly update the students list.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowWhenRemovedStudentIsNull()
        {
            School telerikAcademy = new School("TelerikAcademy");

            telerikAcademy.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowWhenRemovedStudentDoesNotExist()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            telerikAcademy.RemoveStudent(gosho);
        }

        [TestMethod]
        public void SchoolShouldRemoveStudentsCorrectly()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            telerikAcademy.AddStudent(gosho);
            telerikAcademy.RemoveStudent(gosho);

            Assert.AreEqual(0, telerikAcademy.Students.Count, "Adding a student and then removing it should result in the same list size.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowWhenAddedCourseIsNull()
        {
            School telerikAcademy = new School("TelerikAcademy");

            telerikAcademy.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowWhenAddedCourseAlreadyExists()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Course highQualityCode = new Course("High quality code");

            telerikAcademy.AddCourse(highQualityCode);
            telerikAcademy.AddCourse(highQualityCode);
        }

        [TestMethod]
        public void SchoolShouldAddCoursesCorrectly()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Course highQualityCode = new Course("High quality code");

            telerikAcademy.AddCourse(highQualityCode);

            Assert.AreEqual(1, telerikAcademy.Courses.Count, "Adding a new course should accordingly update the courses list.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowWhenRemovedCourseIsNull()
        {
            School telerikAcademy = new School("TelerikAcademy");

            telerikAcademy.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowWhenRemovedCourseDoesNotExist()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Course highQualityCode = new Course("High quality code");

            telerikAcademy.RemoveCourse(highQualityCode);
        }

        [TestMethod]
        public void SchoolShouldRemoveCoursesCorrectly()
        {
            School telerikAcademy = new School("TelerikAcademy");
            Course highQualityCode = new Course("High quality code");

            telerikAcademy.AddCourse(highQualityCode);
            telerikAcademy.RemoveCourse(highQualityCode);

            Assert.AreEqual(0, telerikAcademy.Courses.Count, "Adding a course and then removing it should result in the same list size.");
        }
    }
}