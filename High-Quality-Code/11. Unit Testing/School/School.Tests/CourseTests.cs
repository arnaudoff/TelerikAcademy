namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowWhenNameIsNull()
        {
            Course highQualityCode = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowWhenNameIsEmpty()
        {
            Course highQualityCode = new Course(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowWhenAddedStudentIsNull()
        {
            Course highQualityCode = new Course("High quality code");

            highQualityCode.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowWhenAddedStudentAlreadyExists()
        {
            Course highQualityCode = new Course("High quality code");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            highQualityCode.AddStudent(gosho);
            highQualityCode.AddStudent(gosho);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowWhenAddedStudentExceedsMaxStudentsCount()
        {
            Course highQualityCode = new Course("High quality code");

            for (int i = 0; i < Course.MaxStudentsCount + 1; i++)
            {
                Student gosho = new Student(10000 + i, "Georgi", "Petrov");
                highQualityCode.AddStudent(gosho);
            }
        }

        [TestMethod]
        public void CourseShouldAddStudentsCorrectly()
        {
            Course highQualityCode = new Course("High quality code");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            highQualityCode.AddStudent(gosho);

            Assert.AreEqual(1, highQualityCode.Students.Count, "Adding a new student should accordingly update the students list.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowWhenRemovedStudentIsNull()
        {
            Course highQualityCode = new Course("High quality code");

            highQualityCode.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowWhenRemovedStudentDoesNotExist()
        {
            Course highQualityCode = new Course("High quality code");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            highQualityCode.RemoveStudent(gosho);
        }

        [TestMethod]
        public void CourseShouldRemoveStudentsCorrectly()
        {
            Course highQualityCode = new Course("High quality code");
            Student gosho = new Student(10000, "Georgi", "Petrov");

            highQualityCode.AddStudent(gosho);
            highQualityCode.RemoveStudent(gosho);

            Assert.AreEqual(0, highQualityCode.Students.Count, "Adding a student and then removing it should result in the same list size.");
        }
    }
}
