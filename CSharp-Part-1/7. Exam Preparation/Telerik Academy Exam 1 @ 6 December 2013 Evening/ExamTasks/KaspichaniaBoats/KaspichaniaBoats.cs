using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int asteriskStartPos = (N * 2 + 1) / 2;
        Console.WriteLine(asteriskStartPos);
        for (int rows = 0; rows < 6 + ((N - 3) / 2) * 3; rows++)
        {
            for (int columns = 0; columns < N * 2 + 1; columns++)
            {
                if (columns == asteriskStartPos || rows == asteriskStartPos)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
