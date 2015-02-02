using System;

class TribonacciTriangle
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
        int difference = 3;
        int differenceCount = 4;
        // Draw the triangle
        for (int i = 1; i <= n - 3; i++)
        {
            nextnumber = numbers[0] + numbers[1] + numbers[2];
            numbers[0] = numbers[1];
            numbers[1] = numbers[2];
            numbers[2] = nextnumber;
            if (i == difference)
            {
                Console.Write("{0}", nextnumber);
                Console.WriteLine();
                difference = difference + differenceCount;
                differenceCount++;
            }
            else
            {
                Console.Write("{0} ", nextnumber);
            }
        }
        Console.WriteLine();
    }
}