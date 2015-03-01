// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
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
        reader = new StreamReader(inputFileName);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = reader.ReadLine();
            }
        }

    }
}