using System;

class Enigmanation
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        int i = 0;

        // Check if brackets even exist in the input
        int totalBracketCount = 0;
        while (inputStr[i] != '=')
        {
            if (inputStr[i] == '(' || inputStr[i] == ')')
            {
                totalBracketCount++;
            }
            i++;
        }
        totalBracketCount /= 2;
        inputStr = inputStr.Remove(inputStr.Length - 1);
        double finalResult = 0D;
        Console.WriteLine(totalBracketCount);
        if (totalBracketCount < 1)
        {
            finalResult = calculateInsideBrackets(inputStr);
        }
        else
        {
            // (1+9)%6–(7%2)*8=
            int currentBracketCount = 0;
            int currentLength = 0;
            while (currentLength < inputStr.Length && currentBracketCount < totalBracketCount)
            {
                // TODO..
            }
        }
        Console.WriteLine("{0:F3}", finalResult);
    }

    static double calculateInsideBrackets(string inputStr)
    {
        int totalOpCount = 0;
        int i;
        for (i = 0; i < inputStr.Length; i++)
        {
            if (!Char.IsDigit(inputStr[i]))
            {
                totalOpCount++;
            }
        }
        int currentOpCount = 0;
        double finalResult = 0D;
        i = 0;
        while (i < inputStr.Length && currentOpCount < totalOpCount)
        {
            if (!Char.IsDigit(inputStr[i]))
            {
                switch (inputStr[i])
                {
                    case '+':
                        if (currentOpCount >= 1)
                        {
                            finalResult = finalResult + (inputStr[i + 1] - '0');
                        }
                        else
                        {
                            finalResult = (inputStr[i - 1] - '0') + (inputStr[i + 1] - '0');
                        }
                        break;
                    case '-':
                        if (currentOpCount >= 1)
                        {
                            finalResult = finalResult - (inputStr[i + 1] - '0');
                        }
                        else
                        {
                            finalResult = (inputStr[i - 1] - '0') - (inputStr[i + 1] - '0');
                        }
                        break;
                    case '%':
                        if (currentOpCount >= 1)
                        {
                            finalResult = finalResult % (inputStr[i + 1] - '0');
                        }
                        else
                        {
                            finalResult = (inputStr[i - 1] - '0') % (inputStr[i + 1] - '0');
                        }
                        break;
                    case '*':
                        if (currentOpCount >= 1)
                        {
                            finalResult = finalResult * (inputStr[i + 1] - '0');
                        }
                        else
                        {
                            finalResult = (inputStr[i - 1] - '0') * (inputStr[i + 1] - '0');
                        }
                        break;
                }
                currentOpCount++;
            }
            i++;
        }
        return finalResult;
    }
}
