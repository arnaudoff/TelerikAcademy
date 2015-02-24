// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string word = "in";
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string[] splitText = text.Split(new string[] {". "}, StringSplitOptions.None);
        for (int i = 0; i < splitText.Length; i++)
        {
            if (Regex.IsMatch(splitText[i], string.Format("[^a-zA-Z]{0}[^a-zA-Z]", word), RegexOptions.IgnoreCase))
            {
                Console.Write(splitText[i]);
                if (i != splitText.Length - 1)
                {
                    Console.Write(". ");
                }
            }
        }
        Console.WriteLine();
    }


}