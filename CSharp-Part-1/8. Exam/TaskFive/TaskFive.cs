using System;

class TaskFive
{
    static void Main()
    {
        int substring = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string sTempSubString = Convert.ToString(substring, 2);
        string sFinalSubstring = "";
        if (substring < 8)
        {
            sFinalSubstring = sTempSubString.PadLeft(4, '0');
        }
        else
        {
            sFinalSubstring = sTempSubString.Substring(sTempSubString.Length - Math.Min(4, sTempSubString.Length));
        }
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        string[] strNumbers = new string[n];
        string tmpStrNumber;
        for (int i = 0; i < n; i++)
        {
            tmpStrNumber = Convert.ToString(numbers[i], 2);
            strNumbers[i] = tmpStrNumber.Substring(tmpStrNumber.Length - Math.Min(30, tmpStrNumber.Length));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(strNumbers[i]);
        }
        int currentCount = 0;
        int finalCount = 0;
        for (int i = 0; i < n; i++)
        {
            for (var j = 0; j <= strNumbers[i].Length - sTempSubString.Length; j++)
            {
                if (strNumbers[i].Substring(j, sTempSubString.Length) == sTempSubString)
                {
                    currentCount++;
                }
            }
            finalCount += currentCount;
            currentCount = 0;
        }
        Console.WriteLine(finalCount);
    }
}