namespace Validate
{
    using System;

    public static class Figure
    {
        public static void IfPropertyIsLessThanZero(double value, string figureName, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} {1} must be a positive number.", figureName, propertyName));
            }
        }
    }
}
