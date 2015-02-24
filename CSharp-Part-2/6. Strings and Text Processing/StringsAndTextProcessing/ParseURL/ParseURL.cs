// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";

        // Iterate through the url and save the segments into new strings
        int i = 0;
        StringBuilder protocol = new StringBuilder();
        while (url[i] != ':')
        {
            protocol.Append(url[i]);
            i++;
        }
        i += 3;
        StringBuilder server = new StringBuilder();
        while (url[i] != '/')
        {
            server.Append(url[i]);
            i++;
        }

        StringBuilder resource = new StringBuilder();
        while (i < url.Length)
        {
            resource.Append(url[i]);
            i++;
        }
        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);
    }
}
