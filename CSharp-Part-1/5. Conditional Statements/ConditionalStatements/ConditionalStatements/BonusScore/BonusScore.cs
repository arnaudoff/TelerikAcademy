/* 
 * Write a program that applies bonus score to given score in the range [1…9] by the following rules:
 * If the score is between 1 and 3, the program multiplies it by 10.
 * If the score is between 4 and 6, the program multiplies it by 100.
 * If the score is between 7 and 9, the program multiplies it by 1000.
 * If the score is 0 or more than 9, the program prints “invalid score”.
 */

using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter input score: ");
        int inputScore = int.Parse(Console.ReadLine());

        if (inputScore >= 1 && inputScore <= 3)
        {
            Console.WriteLine(inputScore * 10);
        }
        else if (inputScore >= 4 && inputScore <= 6)
        {
            Console.WriteLine(inputScore * 100);
        }
        else if (inputScore >= 7 && inputScore <= 9)
        {
            Console.WriteLine(inputScore * 1000);
        }
        else
        {
            Console.WriteLine("Invalid score.");
        }
    }
}
