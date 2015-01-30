using System;
using System.Collections.Generic;

class Enigmanation
{
    static void Main()
    {
        string expression = Console.ReadLine();

        decimal result = 0;
        decimal currentBracketResult = 0;
        char currentOperator = '+';
        char currentBracketOperator = '+';

        bool isInBracket = false;
        foreach (char symbol in expression)
        {
            if (!Char.IsDigit(symbol))
            {
                if (symbol == '(')
                {
                    isInBracket = true;
                    continue;
                }
                if (isInBracket)
                {
                    currentBracketOperator = symbol;
                }
                else
                {
                    currentOperator = symbol;
                }
                if (symbol == ')')
                {
                    isInBracket = false;
                    switch (currentOperator)
                    {
                        case '+':
                            result += currentBracketResult;
                            break;
                        case '-':
                            result -= currentBracketResult;
                            break;
                        case '*':
                            result *= currentBracketResult;
                            break;
                        case '%':
                            result %= currentBracketResult;
                            break;
                    }
                    currentBracketResult = 0;
                    currentBracketOperator = '+';
                }
            }
            else
            {
                int currentNumber = symbol - '0';
                if (isInBracket)
                {
                    switch (currentBracketOperator)
                    {
                        case '+':
                            currentBracketResult += currentNumber;
                            break;
                        case '-':
                            currentBracketResult -= currentNumber;
                            break;
                        case '*':
                            currentBracketResult *= currentNumber;
                            break;
                        case '%':
                            currentBracketResult %= currentNumber;
                            break;
                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+':
                            result += currentNumber;
                            break;
                        case '-':
                            result -= currentNumber;
                            break;
                        case '*':
                            result *= currentNumber;
                            break;
                        case '%':
                            result %= currentNumber;
                            break;
                    }
                }
            }
        }
        Console.WriteLine("{0:F3}", result);
    }
}