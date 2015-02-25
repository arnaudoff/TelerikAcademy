// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        Console.WriteLine("Before replace: ");
        Console.WriteLine();
        Console.WriteLine(text);
        Console.WriteLine();
        text = text.Replace("</a>", "[/URL]");
        MatchCollection matches = Regex.Matches(text, @"<a href=""[a-zA-Z0-9./:]+"">");
        foreach (var match in matches)
        {
            string savedMatch = match.ToString();
            savedMatch = savedMatch.Replace("<a href=", "[URL=");
            savedMatch = savedMatch.Replace(">", "]");
            savedMatch = savedMatch.Replace("\"", "");
            text = text.Replace(match.ToString(), savedMatch);
        }
        Console.WriteLine("After replace: ");
        Console.WriteLine();
        Console.WriteLine(text);
    }
}