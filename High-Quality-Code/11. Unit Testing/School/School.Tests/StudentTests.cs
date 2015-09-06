namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        private const int MinValidID = 10000;
        private const int MaxValidID = 99999;

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowWhenIdIsBelowMinimum()
        {
            Random random = new Random();
            int randomID = random.Next(int.MinValue, MinValidID);

            Student gosho = new Student(randomID, "Georgi", "Petrov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowWhenIdIsAboveMaximum()
        {
            Random random = new Random();
            int randomID = random.Next(MaxValidID + 1, int.MaxValue);

            Student gosho = new Student(randomID, "Georgi", "Petrov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenFirstNameIsNull()
        {
            Student gosho = new Student(MinValidID, null, "Petrov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenFirstNameIsEmpty()
        {
            Student gosho = new Student(MinValidID, string.Empty, "Petrov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenLastNameIsNull()
        {
            Student gosho = new Student(MinValidID, "Georgi", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenLastNameIsEmpty()
        {
            Student gosho = new Student(MinValidID, "Georgi", string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenAttendedCourseIsNull()
        {
            Student gosho = new Student(MinValidID, "Georgi", "Petrov");

            gosho.AttendCourse(null);
        }

        [TestMethod]
        public void StudentShouldAttendCoursesCorrectly()
        {
            Student gosho = new Student(MinValidID, "Georgi", "Petrov");
            Course highQualityCode = new Course("High quality code");

            gosho.AttendCourse(highQualityCode);

            Assert.IsTrue(
                highQualityCode.Students.Contains(gosho), 
                "Adding a student to a course should accordingly add the student to the course's list of students.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhenLeftCourseIsNull()
        {
            Student gosho = new Student(MinValidID, "Georgi", "Petrov");
            gosho.LeaveCourse(null);
        }

        [TestMethod]
        public void StudentShouldLeaveCoursesCorrectly()
        {
            Student gosho = new Student(MinValidID, "Georgi", "Petrov");
            Course highQualityCode = new Course("High quality code");

            gosho.AttendCourse(highQualityCode);
            gosho.LeaveCourse(highQualityCode);

            Assert.AreEqual(
                0,
                highQualityCode.Students.Count,
                "Student attending a course and then leaving it should result in the same students list size for the course.");
        }
    }
}
