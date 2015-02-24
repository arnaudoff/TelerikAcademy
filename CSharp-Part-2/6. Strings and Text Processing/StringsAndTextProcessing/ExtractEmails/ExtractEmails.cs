/*
 * Write a program for extracting all email addresses from given text.
 * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "Hello. My name is Tsun Kai Hui and I'm from China! Feel free to mail me - tsun.kai12@totally-valid.com or tsun_kai@also.valid.com";

        // The identifier can contain letters, numbers, an underscore, a dot or a dash.
        string pattern = @"[a-z0-9_.-]+@[a-z0-9-.]+[.][a-z]+";
        MatchCollection matches = Regex.Matches(text.ToLower(), pattern);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}