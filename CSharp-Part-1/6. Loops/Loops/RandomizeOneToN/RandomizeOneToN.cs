// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number [n]: ");
        int inputNumber = int.Parse(Console.ReadLine());

        int[] numArray = new int[inputNumber];
        for (int i = 0; i < inputNumber; i++)
        {
            numArray[i] = i + 1;
        }
        numArray = ShuffleArray(numArray);
        for (int i = 0; i < inputNumber; i++)
        {
            Console.Write("{0}", numArray[i]);
        }
        Console.WriteLine();
    }

    static int[] ShuffleArray(int[] array)
    {
        Random r = new Random();
        for (int i = array.Length; i > 0; i--)
        {
            int j = r.Next(i);
            int temp = array[j];
            array[j] = array[i - 1];
            array[i - 1] = temp;
        }
        return array;
    }
}