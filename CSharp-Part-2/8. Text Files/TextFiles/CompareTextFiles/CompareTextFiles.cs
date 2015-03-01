/*
 * Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
 * Assume the files have equal number of lines.
 */

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string firstFileName = "first.txt";
        string secondFileName = "second.txt";

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
                streamWriter.WriteLine("Hello");
                streamWriter.WriteLine("Pesho");
                streamWriter.WriteLine("How");
                streamWriter.WriteLine("Will");
                streamWriter.WriteLine("You");
                streamWriter.WriteLine("Feel");
                streamWriter.WriteLine("Tomorrow");
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

        int equalCount = 0;
        int differentCount = 0;
        StreamReader firstStream = new StreamReader(firstFileName);
        StreamReader secondStream = new StreamReader(secondFileName);
        using (firstStream)
        {
            using (secondStream)
            {
                string firstLine;
                string secondLine;

                firstLine = firstStream.ReadLine();
                secondLine = secondStream.ReadLine();
                while (firstLine != null && secondLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        ++equalCount;
                    }
                    else
                    {
                        ++differentCount;
                    }
                    firstLine = firstStream.ReadLine();
                    secondLine = secondStream.ReadLine();
                }

                Console.Write("Equal lines count: {0}\nDifferent lines count:  {1}\n", equalCount, differentCount);
            }
        }
    }
}