/*
 * Write a program that deletes from a text file all words that start with the prefix test.
 * Words contain only the symbols 0…9, a…z, A…Z, _.
 */

using System;
using System.IO;
using System.Linq;
using System.Text;

class PrefixTest
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
                streamWriter.WriteLine("testhello notest hahatest testprefixedagain TESTokay");
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
        using (reader = new StreamReader(inputFileName))
        {
            string currentLine;
            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                string[] splitWords = currentLine.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                result.AppendLine(String.Join(" ", splitWords));
            }
        }


        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            writer.Write(result.ToString());
        }

        Console.WriteLine("Output file ({0}): ", outputFileName);
        reader = new StreamReader(outputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        } 
    }
}