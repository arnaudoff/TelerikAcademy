// Write a program to check if in a given expression the brackets are put correctly.

using System;

class CorrectBrackets
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        bool res = CheckForBrackets(inputString);
        Console.WriteLine("The given expression is {0} in terms of the brackets count.", res ? "valid" : "invalid");
    }

    static bool CheckForBrackets(string expression)
    {
        int leftCount = 0;
        int rightCount = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                leftCount++;
            }
            if (expression[i] == ')')
            {
                rightCount++;
            }
        }
        if (leftCount == rightCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}