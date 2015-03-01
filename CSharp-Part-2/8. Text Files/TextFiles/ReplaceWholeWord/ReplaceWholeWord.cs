/*
 * Modify the solution of the previous problem to replace only whole words (not strings).
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
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
                streamWriter.WriteLine("!+0start! hellostarthello hellostarTbye");
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
                while ((currentLine = reader.ReadLine()) != null)
                {
                    currentLine = currentLine.ToLower();
                    currentLine = Regex.Replace(currentLine, @"\bstart\b", "finish");
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