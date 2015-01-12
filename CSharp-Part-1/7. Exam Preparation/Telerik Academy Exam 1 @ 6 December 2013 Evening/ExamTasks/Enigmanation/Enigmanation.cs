using System;

class Enigmanation
{
    static void Main()
    {
        string inputStr = Console.ReadLine();

        bool isBracketOpen = true;
        int finalResult = 0;
        for (int i = 0; inputStr[i] != '='; i++)
        {
            if (inputStr[i] == '(')
            {
                isBracketOpen = true;
            }
            else if (inputStr[i] == ')')
            {
                isBracketOpen = false;
            }
            if (isBracketOpen)
            {
                if (!Char.IsDigit(inputStr[i]))
                {
                    switch (inputStr[i])
                    {
                        case '+':
                            finalResult = (inputStr[i - 1] - '0') + (inputStr[i + 1] - '0');
                            break;
                        case '-':
                            finalResult = inputStr[i - 1] - inputStr[i + 1];
                            break;
                        case '%':
                            finalResult = inputStr[i - 1] % inputStr[i + 1];
                            break;
                        case '*':
                            finalResult = inputStr[i - 1] * inputStr[i + 1];
                            break;
                    }
                }
            }
        }
        Console.WriteLine(finalResult);
    }
}
