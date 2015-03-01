// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstFileName = "first.txt";
        string secondFileName = "second.txt";
        string resultFileName = "result.txt";

        if (!File.Exists(firstFileName))
        {
            StreamWriter streamWriter = new StreamWriter(firstFileName);
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

        if (!File.Exists(secondFileName))
        {
            StreamWriter streamWriter = new StreamWriter(secondFileName);
            using (streamWriter)
            {
                streamWriter.WriteLine("I am");
                streamWriter.WriteLine("fine");
                streamWriter.WriteLine("thanks");
            }
        }

        StreamReader reader;
        reader = new StreamReader(firstFileName);
        string firstFileContents;
        Console.WriteLine("First file contents ({0}): ", firstFileName);
        using (reader)
        {
            firstFileContents = reader.ReadToEnd();
            Console.WriteLine(firstFileContents);
        }

        Console.WriteLine("Second file contents ({0}): ", secondFileName);
        reader = new StreamReader(secondFileName);
        string secondFileContents;
        using (reader)
        {
            secondFileContents = reader.ReadToEnd();
            Console.WriteLine(secondFileContents);
        }

        string resultantString = string.Concat(firstFileContents, secondFileContents);
        Console.WriteLine("Result ({0}): ", resultFileName);
        Console.WriteLine(resultantString);

        StreamWriter writer = new StreamWriter(resultFileName);
        using(writer)
        {
            writer.Write(resultantString);
        }
    }
}