// Write a program that reverses the words in given sentence.

using System;
using System.Text;

class ReverseSentence
{
    static char[] punctuationSigns = { ',', '!', '?' };
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        ReverseWords(text);
    }
    static void ReverseWords(string text)
    {
        string[] splitText = text.Split(' ');
        char[] punctuation = new char[splitText.Length];
        for (int i = 0; i < splitText.Length; i++)
        {
            foreach (char token in punctuationSigns)
            {
                int index = splitText[i].IndexOf(token);
                if (index != -1)
                {
                    punctuation[i] = splitText[i][index];
                    splitText[i] = splitText[i].Remove(index);
                }
            }
        }
        Array.Reverse(punctuation);
        StringBuilder outputStr = new StringBuilder();
        for (int i = splitText.Length - 1; i >= 0; i--)
        {
            if (punctuation[i] != '\0')
            {
                outputStr.Append(string.Format("{0}{1} ", splitText[i], punctuation[i]));
            }
            else
            {
                outputStr.Append(string.Format("{0} ", splitText[i]));
            }
        }
        Console.WriteLine(outputStr.ToString());
    }
}
