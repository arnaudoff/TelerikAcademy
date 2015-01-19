using System;

class Enigmanation
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        int i = 0;
        int totalOpCount = 0;
        while (inputStr[i] != '=')
        {
            if (inputStr[i] != '(' && inputStr[i] != ')' && !Char.IsDigit(inputStr[i]))
            {
                totalOpCount++;
            }
            i++;
        }
        i = 0;
        int currentOpCount = 0;
        bool isBracketOpen = true;
        int finalResult = 0;
        while (inputStr[i] != '=' && currentOpCount < totalOpCount)
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
                            if (currentOpCount >= 1)
                            {
                                // finalResult = finalResult + inputStr[i + 1 - '0'];
                                Console.WriteLine(i);
                            }
                            else finalResult = (inputStr[i - 1] - '0') + (inputStr[i + 1] - '0');
                            break;
                        /*
                        case '-':
                            finalResult -= (inputStr[i - 1] - '0') - (inputStr[i + 1] - '0');
                            break;
                        case '%':
                            finalResult %= (inputStr[i - 1] - '0') % (inputStr[i + 1] - '0');
                            break;
                        case '*':
                            finalResult *= (inputStr[i - 1] - '0') * (inputStr[i + 1] - '0');
                            break;
                        */
                    }
                    currentOpCount++;
                }
            }
            i++;
        }
        Console.WriteLine(finalResult);
    }
}
