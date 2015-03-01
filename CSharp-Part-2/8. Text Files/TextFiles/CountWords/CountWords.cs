/*
 * Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
 * The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
 * Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        string wordsFileName = "words.txt";
        string inputFileName = "test.txt";
        string resultFileName = "result.txt";

        CreateFiles(wordsFileName, inputFileName);
        PrintFileContents(wordsFileName);
        PrintFileContents(inputFileName);
        try
        {
            using (StreamWriter writer = new StreamWriter(resultFileName))
            {
                using (StreamReader reader = new StreamReader(inputFileName))
                {
                    string currentLine;
                    string[] wordsList = File.ReadAllLines(wordsFileName);
                    int[] occurencesCount = new int[wordsList.Length];

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        currentLine = currentLine.ToLower();
                        for (int i = 0; i < wordsList.Length; i++)
                        {
                            occurencesCount[i] += Regex.Matches(currentLine, @"\b" + wordsList[i] + @"\b").Count;
                        }
                    }
                    Array.Sort(occurencesCount, wordsList);
                    for (int i = wordsList.Length - 1; i >= 0; i--)
                    {
                        writer.WriteLine("{0} -> {1}", wordsList[i], occurencesCount[i]);
                    }
                }
            }
            PrintFileContents(resultFileName);
        }
        catch (FieldAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void CreateFiles(string wordsFileName, string inputFileName)
    {
        if (!File.Exists(wordsFileName))
        {
            StreamWriter streamWriter = new StreamWriter(wordsFileName);
            using (streamWriter)
            {
                streamWriter.WriteLine("foo");
                streamWriter.WriteLine("bar");
                streamWriter.WriteLine("foobar");
            }
        }

        if (!File.Exists(inputFileName))
        {
            StreamWriter streamWriter = new StreamWriter(inputFileName);
            using (streamWriter)
            {
                streamWriter.WriteLine("foobar foo foo foobar bar foo bar");
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