using System;

class Program
{
    static void Main()
    {
        long[] numbers = new long[3];
        numbers[0] = long.Parse(Console.ReadLine());
        numbers[1] = long.Parse(Console.ReadLine());
        numbers[2] = long.Parse(Console.ReadLine());

        byte l = byte.Parse(Console.ReadLine());

        int n = 0;
        // Calculate N
        for (int i = 0; i < l; i++)
        {
            n = n + l - i;
        }

        long nextnumber = 0L;
        Console.WriteLine(numbers[0]);
        Console.WriteLine("{0} {1}", numbers[1], numbers[2]);
        int newline_number = 3;
        for (int i = 1; i <= n - 3; i++)
        {
            nextnumber = numbers[0] + numbers[1] + numbers[2];
            if (i != newline_number)
            {
                Console.Write("{0} ", nextnumber);
            }
            else
            {
                Console.Write("{0}", nextnumber);
            }
            numbers[0] = numbers[1];
            numbers[1] = numbers[2];
            numbers[2] = nextnumber;
            if (i == newline_number)
            {
                Console.WriteLine();
                newline_number = 2 * newline_number + 1;
            }
        }

    }
}