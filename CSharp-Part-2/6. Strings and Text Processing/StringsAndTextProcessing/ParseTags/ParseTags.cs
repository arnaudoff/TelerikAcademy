/*
 * You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
 * The tags cannot be nested.
 */

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string inputStr = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        bool isTag = false;
        bool isInUpcase = false;
        StringBuilder finalStr = new StringBuilder();
        for (int i = 0; i < inputStr.Length; i++)
        {
            // Match an opening tag
            if (inputStr[i] == '<' && inputStr[i + 1] != '/' && i != inputStr.Length - 1)
            {
                isTag = true;
                continue;
            }
            // Match a closing tag
            if (inputStr[i] == '<' && inputStr[i + 1] == '/')
            {
                isInUpcase = false;
                isTag = true;
            }
            if (i > 0 && inputStr[i - 1] == '>')
            {
                // Only capitalize the next sequence if the tag isn't closing
                if (inputStr[i - 8] != '/')
                {
                    isInUpcase = true;
                }
                isTag = false;
            }
            if (isInUpcase)
            {
                finalStr.Append(Char.ToUpper(inputStr[i]));
            }
            else if (!isTag)
            {
                finalStr.Append(inputStr[i]);
            }
        }
        Console.WriteLine(finalStr);
    }
}
