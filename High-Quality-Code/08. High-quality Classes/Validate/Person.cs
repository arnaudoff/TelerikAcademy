namespace Validate
{
    using System;

    public static class Person
    {
        public static void IfPropertyIsNullOrWhitespace(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format("Person's {0} cannot be null or contain any whitespace.", propertyName));
            }
        }

        public static void IfAgeIsValid(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(string.Format("Person's age cannot be negative or zero."));
            }
        }
    }
}
