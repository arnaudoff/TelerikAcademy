/*
 * Write a program that removes from a text file all words listed in given another text file.
 * Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class RemoveWords
{
    static void Main()
    {

        string wordsFileName = "words.txt";
        string inputFileName = "input.txt";
        CreateFiles(wordsFileName, inputFileName);
        PrintFileContents(wordsFileName);
        PrintFileContents(inputFileName);

        List<string> result = new List<string>();
        List<string> forbidden = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(wordsFileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine()
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    forbidden.AddRange(words);
                }
            }
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine()
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => !forbidden.Contains(x))
                        .ToArray();

                    result.AddRange(words);
                }
            }

            using (StreamWriter writer = new StreamWriter(inputFileName))
            {
                writer.Write(String.Join(Environment.NewLine, result));
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
        }

        PrintFileContents(inputFileName);
    }

    private static void CreateFiles(string wordsFileName, string inputFileName)
    {
        if (!File.Exists(wordsFileName))
        {
            StreamWriter streamWriter = new StreamWriter(wordsFileName);
            using (streamWriter)
            {
                streamWriter.WriteLine("Gosho");
                streamWriter.WriteLine("Pesho");
                streamWriter.WriteLine("Misho");
            }
        }

        if (!File.Exists(inputFileName))
        {
            StreamWriter streamWriter = new StreamWriter(inputFileName);
            using (streamWriter)
            {
                streamWriter.WriteLine("Gosho Hello Pesho world Misho !");
            }
        }
    }
    private static void PrintFileContents(string fileName)
    {
        Console.WriteLine("File contents ({0}): ", fileName);
        StreamReader reader = new StreamReader(fileName);
        string fileContents;
        using (reader)
        {
            fileContents = reader.ReadToEnd();
            Console.WriteLine(fileContents);
        }
    }
}