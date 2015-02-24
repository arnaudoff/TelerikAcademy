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
        int currentIndex = 0;
        foreach (var str in splitText)
        {
            // wtf?
        }
    }


}