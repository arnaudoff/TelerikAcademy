/*
 * Write a program that reads a text file and inserts line numbers in front of each of its lines.
 * The result should be written to another text file.
 */

using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {
        string inputFileName = "input.txt";
        string outputFileName = "output.txt";
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
        StringBuilder result = new StringBuilder();
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                result.AppendLine(String.Format("{0,-5:D3}{1}", lineNumber, line));
                line = reader.ReadLine();
            }
            File.WriteAllLines(outputFileName, result.ToString().Split('\n'));
        }

        Console.WriteLine("Output file ({0}): ", outputFileName);
        reader = new StreamReader(outputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}