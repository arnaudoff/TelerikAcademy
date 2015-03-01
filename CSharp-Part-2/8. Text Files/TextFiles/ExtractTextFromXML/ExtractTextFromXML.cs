/*
 * Write a program that extracts from given XML file all the text without the tags.
 */

using System;
using System.Text;
using System.IO;

class ExtractTextFromXML
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
                streamWriter.WriteLine(@"<?xml version=""1.0""><student><name>Pesho</name><age>21</age><interests count=""3""><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>");
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
            string XMLString = reader.ReadToEnd();

            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                writer.Write(ParseXML(XMLString));
            }
        }
        Console.WriteLine("Output file ({0}): ", outputFileName);
        reader = new StreamReader(outputFileName);
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }      
    }

    private static string ParseXML(string XMLString)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder current = new StringBuilder();
        bool insideTag = false;

        foreach (var token in XMLString)
        {
            if (insideTag)
            {
                if (token == '>')
                {
                    insideTag = false;
                }
                continue;
            }
            else
            {
                if (token == '<')
                {
                    if (current.Length > 0)
                    {
                        result.AppendLine(current.ToString());
                        current.Clear();
                    }
                    insideTag = true;
                }
                else
                {
                    current.Append(token);
                }
                continue;
            }
        }
        return result.ToString();
    }
}