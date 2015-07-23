namespace Methods
{
    using System;

    public static class NumberUtils
    {
        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentOutOfRangeException("Invalid digit!");
            }
        }

        public static void PrintAsNumber(object number, FormatSpecifier formatSpecifier)
        {
            switch (formatSpecifier)
            {
                case FormatSpecifier.Precision:
                    Console.WriteLine("{0:f2}", number);
                    break;
                case FormatSpecifier.Percent:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case FormatSpecifier.RightAlignment:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid format specifier given.");
            }
        }
    }
}
