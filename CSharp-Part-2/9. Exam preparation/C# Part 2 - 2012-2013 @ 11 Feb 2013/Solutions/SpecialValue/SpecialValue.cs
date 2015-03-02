using System;

class SpecialValue
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[][] inputField = new int[N][];
        bool[][] usedFieldElements = new bool[N][];

        for (int row = 0; row < N; row++)
        {
            string[] splitRow = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            inputField[row] = new int[splitRow.Length];
            usedFieldElements[row] = new bool[splitRow.Length];
            for (int col = 0; col < splitRow.Length; col++)
            {
                inputField[row][col] = int.Parse(splitRow[col]);
                usedFieldElements[row][col] = false;
            }
        }

        int maxSpecialValue = 0;
        for (int col = 0; col < inputField[0].Length; col++)
        {
            int currentSpecialValue = CalculateSpecialValue(inputField, col, usedFieldElements);
            if (currentSpecialValue > maxSpecialValue)
            {
                maxSpecialValue = currentSpecialValue;
            }
        }

        Console.WriteLine(maxSpecialValue);
    }

    private static int CalculateSpecialValue(int[][] inputField, int currentColumn, bool[][] usedFieldElements)
    {
        int currentRow = 0;
        int result = 0;

        while(true)
        {
            result++;
            if (currentRow == inputField.GetLength(0))
            {
                currentRow = 0;
            }

            if (usedFieldElements[currentRow][currentColumn])
            {
                return int.MinValue;
            }

            if (inputField[currentRow][currentColumn] < 0)
            {
                result -= inputField[currentRow][currentColumn];
                return result;
            }

            usedFieldElements[currentRow][currentColumn] = true;
            currentColumn = inputField[currentRow][currentColumn];
            currentRow++;
        }
    }
}
