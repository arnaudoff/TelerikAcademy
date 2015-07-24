namespace Validate
{
    using System;

    public static class Course
    {
        public static void IfPropertyIsNullOrWhitespace(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format("Course {0} cannot be null or contain any whitespace.", propertyName));
            }
        }
    }
}