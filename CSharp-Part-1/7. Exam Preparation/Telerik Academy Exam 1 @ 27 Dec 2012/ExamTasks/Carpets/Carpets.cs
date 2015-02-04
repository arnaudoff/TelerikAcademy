using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int center = n / 2;
        for (int i = 1; i <= center; i++)
        {
            int currentPos = 1;
            while (currentPos <= n)
            {
                if (currentPos <= center - i || currentPos > center + i)
                {
                    Console.Write('.');
                    currentPos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('/');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        currentPos++;
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('\\');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        currentPos++;
                    }
                }
            }
            Console.WriteLine();
        }
        for (int i = center; i > 0; i--)
        {
            int currentPos = 1;
            while (currentPos <= n)
            {
                if (currentPos <= center - i || currentPos > center + i)
                {
                    Console.Write('.');
                    currentPos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('\\');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        currentPos++;
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('/');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        currentPos++;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}