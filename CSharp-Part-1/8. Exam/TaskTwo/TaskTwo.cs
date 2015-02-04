using System;

class TaskTwo
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string inputString = Console.ReadLine();
        int[] result = new int[inputString.Length];

        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == '@')
            {
                break;
            }
            if (Char.IsLetter(inputString[i]))
            {
                result[i] = (int)inputString[i] * salt + 1000;
            }
            else if (Char.IsDigit(inputString[i]))
            {
                result[i] = (int)inputString[i] + salt + 500;
            }
            else
            {
                result[i] = (int)inputString[i] - salt;
            }
        }
        double[] floatingPointResult = new double[inputString.Length - 1];

        for (int i = 0; i < inputString.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                floatingPointResult[i] = result[i] / 100.00;
            }
            else
            {
                floatingPointResult[i] = result[i] * 100;
            }
        }
        for (int i = 0; i < inputString.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F2}", floatingPointResult[i]);
            }
            else
            {
                Console.WriteLine(floatingPointResult[i]);
            }
        }

    }
}