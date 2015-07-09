namespace BooleanToStringConverter
{
    using System;

    public class BooleanToStringConverter
    {
        public static void Main()
        {
            Converter converter = new Converter();
            string convertedValue = converter.ConvertBooleanToString(true);
            Console.WriteLine(convertedValue);
        }
    }
}
