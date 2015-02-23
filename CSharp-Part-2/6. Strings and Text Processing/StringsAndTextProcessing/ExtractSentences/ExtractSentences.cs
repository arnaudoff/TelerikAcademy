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

        // TODO.
        Console.WriteLine(Regex.IsMatch(text, string.Format("\b{0}\b", word)));
        string[] sentencesArray = text.Split(new string[] { ". " }, StringSplitOptions.None);
        StringBuilder finalStr = new StringBuilder();
        foreach (string sentence in sentencesArray)
        {
            if (Regex.IsMatch(sentence, string.Format("\b{0}\b", word)))
            {
                finalStr.Append(string.Format("{0}. ", sentence));
            }
        }
        //Console.WriteLine(finalStr);
    }
}