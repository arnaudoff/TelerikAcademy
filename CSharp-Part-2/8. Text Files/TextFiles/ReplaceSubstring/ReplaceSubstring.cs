/*
 * Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
 * Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubstring
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
                streamWriter.WriteLine("start Start START sTaRt");
                streamWriter.WriteLine("fiNnNnish stArt start");
                streamWriter.WriteLine("start HELLO world");
                streamWriter.WriteLine("start, finnish, finland and finish");
                streamWriter.WriteLine("!+0start! ...!start+_=. --starT-");
            }
        }

        Console.WriteLine("Input file ({0}): ", inputFileName);
        StreamReader reader;
        reader = new StreamReader(inputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }

        using (reader = new StreamReader(inputFileName))
        {
            string currentLine;
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                while (!reader.EndOfStream)
                {
                    currentLine = reader.ReadLine();
                    currentLine = Regex.Replace(currentLine, "start", "finish", RegexOptions.IgnoreCase);

                    writer.WriteLine(currentLine);
                }
            }
        }

        Console.WriteLine("Output file ({0}): ", outputFileName);
        reader = new StreamReader(outputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}