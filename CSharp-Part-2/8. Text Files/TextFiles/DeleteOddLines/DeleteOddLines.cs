/*
 * Write a program that deletes from given text file all odd lines.
 * The result should be in the same file.
 */

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        string inputFileName = "input.txt";
        if (!File.Exists(inputFileName))
        {
            StreamWriter streamWriter = new StreamWriter(inputFileName);
            using (streamWriter)
            {
                streamWriter.WriteLine("Hello");
                streamWriter.WriteLine("Gosho");
                streamWriter.WriteLine("How");
                streamWriter.WriteLine("Are");
                streamWriter.WriteLine("You");
                streamWriter.WriteLine("Feeling");
                streamWriter.WriteLine("Today");
            }
        }
        Console.WriteLine("Input file ({0}): ", inputFileName);
        StreamReader reader;
        reader = new StreamReader(inputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }

        StringBuilder result = new StringBuilder();
        result.AppendLine("Without odd lines: ");
        using (reader = File.OpenText(inputFileName))
        {
            string currentLine;
            int line = 0;

            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                ++line;
                if (line % 2 == 0)
                {
                    result.AppendLine(currentLine);
                }
            }

        }

        // Since we have to use the same file, but we can't delete lines without creating a new file..
        using (StreamWriter writer = File.AppendText(inputFileName))
        {
            writer.WriteLine(result);
        }

        Console.WriteLine("Output file ({0}): ", inputFileName);
        reader = new StreamReader(inputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}