// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text.RegularExpressions;

class ExtractHTML
{
    static void Main()
    {
        string htmlStr = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a> aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        string title = Regex.Match(htmlStr, @"<title>.*?</title>").ToString();
        title = Regex.Replace(title, @"<.*?>", String.Empty);
        Console.Write("Title: ");
        Console.WriteLine(title);

        string text = Regex.Match(htmlStr, @"<body>.*?</body>").ToString();
        Console.Write("Text: ");
        Console.WriteLine(Regex.Replace(text, @"<.*?>", String.Empty));
    }
}