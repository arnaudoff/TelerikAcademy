using System;
using System.Collections.Generic;
using System.Numerics;

class TaskThree
{
    static void Main()
    {
        string inputNumber;
        List<string> numbers = new List<string>();
        while ((inputNumber = Console.ReadLine()) != "END")
        {
            numbers.Add(inputNumber);
        }
        BigInteger firstFinalProduct = 1;
        BigInteger currentProduct = 1;
        if (numbers.Count <= 10)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    if (numbers[i] == "0")
                    {
                        currentProduct = 1;
                    }
                    else
                    {
                        for (int j = 0; j < numbers[i].Length; j++)
                        {
                            if (numbers[i][j] != '0')
                            {
                                currentProduct *= numbers[i][j] - '0';
                            }
                        }
                    }
                    firstFinalProduct *= currentProduct;
                    currentProduct = 1;
                }
            }
            Console.WriteLine(firstFinalProduct);
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    if (numbers[i] == "0")
                    {
                        currentProduct = 1;
                    }
                    else
                    {
                        for (int j = 0; j < numbers[i].Length; j++)
                        {
                            if (numbers[i][j] != '0')
                            {
                                currentProduct *= numbers[i][j] - '0';
                            }
                        }
                    }
                    firstFinalProduct *= currentProduct;
                    currentProduct = 1;
                }
            }
            Console.WriteLine(firstFinalProduct);
            BigInteger secondFinalProduct = 1;
            currentProduct = 1;
            for (int i = 10; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    if (numbers[i] == "0")
                    {
                        currentProduct = 1;
                    }
                    else
                    {
                        for (int j = 0; j < numbers[i].Length; j++)
                        {
                            if (numbers[i][j] != '0')
                            {
                                currentProduct *= numbers[i][j] - '0';
                            }
                        }
                    }
                    secondFinalProduct *= currentProduct;
                    currentProduct = 1;
                }
            }
            Console.WriteLine(secondFinalProduct);
        }
    }
}