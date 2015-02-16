// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {

        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        string[] inputArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter string[{0}]: ", i + 1);
            inputArray[i] = Console.ReadLine();
        }
        var result = inputArray.OrderBy(s => s.Length);

        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
    }
}