// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter length of the first array: ");
        int firstArrayLength = int.Parse(Console.ReadLine());
        char[] firstArray = new char[firstArrayLength];
        Console.WriteLine("Enter the contents of the first array: ");
        for (int i = 0; i < firstArrayLength; i++ )
        {
            firstArray[i] = (char)Console.Read();
        }
        Console.ReadLine();
        Console.WriteLine("Enter length of the second array: ");
        int secondArrayLength = int.Parse(Console.ReadLine());
        char[] secondArray = new char[secondArrayLength];
        Console.WriteLine("Enter the contents of the second array: ");
        for (int i = 0; i < secondArrayLength; i++)
        {
            secondArray[i] = (char)Console.Read();
        }
        Console.ReadLine();
        if (firstArrayLength > secondArrayLength)
        {
            Console.WriteLine("The second array is lexicographically smaller than the first.");
        }
        else if (firstArrayLength < secondArrayLength)
        {
            Console.WriteLine("The first array is lexicographically smaller than the second.", secondArray.ToString(), firstArray.ToString());
        }
        else
        {
            int lexPosition = 0;
            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    lexPosition = 1;
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    lexPosition = 2;
                    break;
                }
            }
            switch (lexPosition)
            {
                case 0:
                    Console.WriteLine("The arrays are lexicographically and alphabetically equal.");
                    break;
                case 1:
                    Console.WriteLine("The first array is alphabetically smaller than the second.");
                    break;
                case 2:
                    Console.WriteLine("The second array is alphabetically smaller than the first.");
                    break;
            }
        }
    }
}
