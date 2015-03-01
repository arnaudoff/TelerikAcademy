// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class SaveSortedNames
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
                streamWriter.WriteLine("Ivan");
                streamWriter.WriteLine("Peter");
                streamWriter.WriteLine("Maria");
                streamWriter.WriteLine("George");
            }
        }

        Console.WriteLine("Input file ({0}): ", inputFileName);
        StreamReader reader;
        reader = new StreamReader(inputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }

        List<string> names = new List<string>();
        reader = new StreamReader(inputFileName);
        using (reader)
        {
            names = reader.ReadToEnd()
                .Split('\n')
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToList();

            File.WriteAllLines(outputFileName, names);
        }

        Console.WriteLine("Output file ({0}): ", outputFileName);
        reader = new StreamReader(outputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}