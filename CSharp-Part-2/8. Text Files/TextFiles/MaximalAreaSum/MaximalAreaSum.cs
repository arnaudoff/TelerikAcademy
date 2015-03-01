/*
 * Write a program that reads a text file containing a square matrix of numbers.
 * Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
 *      The first line in the input file contains the size of matrix N.
 *      Each of the next N lines contain N numbers separated by space.
 *      The output should be a single number in a separate text file.
 */

using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        string matrixFileName = "matrix.txt";
        string resultFileName = "result.txt";

        CreateFile(matrixFileName);
        PrintFileContents(matrixFileName);

        StreamReader matrixFile = new StreamReader(matrixFileName);
        using (matrixFile)
        {
            string currentLine = matrixFile.ReadLine();
            int matrixSize = Int32.Parse(currentLine);
            int[,] matrix = new int[matrixSize, matrixSize];
            int rows = 0;
            int bestSum = 0;

            while (currentLine != null)
            {
                currentLine = matrixFile.ReadLine();
                if (currentLine != null)
                {
                    string[] rowValues = currentLine.Split(' ');

                    for (int i = rows; i <= rows; i++)
                    {
                        for (int j = 0; j < matrixSize; j++)
                        {
                            matrix[i, j] = Int32.Parse(rowValues[j]);
                        }
                    }
                    rows++;
                }
            }


            for (int i = 0; i < matrixSize - 1; i++)
            {
                for (int j = 0; j < matrixSize - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }

            File.WriteAllText(resultFileName, bestSum.ToString());
            PrintFileContents(resultFileName);
        }
    }

    private static void CreateFile(string matrixFileName)
    {
        if (!File.Exists(matrixFileName))
        {
            StreamWriter streamWriter = new StreamWriter(matrixFileName);
            using (streamWriter)
            {
                streamWriter.WriteLine("4");
                streamWriter.WriteLine("2 3 3 4");
                streamWriter.WriteLine("0 2 3 4");
                streamWriter.WriteLine("3 7 1 2");
                streamWriter.WriteLine("4 3 3 2");
            }
        }
    }

    private static void PrintFileContents(string fileName)
    {
        Console.WriteLine("File contents ({0}): ", fileName);
        StreamReader reader = new StreamReader(fileName);
        string fileContents;
        using (reader)
        {
            fileContents = reader.ReadToEnd();
            Console.WriteLine(fileContents);
        }
    }
}