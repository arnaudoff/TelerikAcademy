using System;
using System.Text;

class FakeTextMarkupLanguage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder inputFTML = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            inputFTML.AppendLine(Console.ReadLine());
        }

        string line = inputFTML.ToString().Trim();
        int closingTagStartIndex = line.IndexOf("</");
        while (closingTagStartIndex != -1)
        {
            int closingTagEndIndex = line.IndexOf(">", closingTagStartIndex + 1);
            string tagName = line.Substring(closingTagStartIndex + 2, closingTagEndIndex - closingTagStartIndex - 2);

            int openingTagStartIndex = line.LastIndexOf(string.Format("<{0}>", tagName), closingTagStartIndex);
            int openingTagEndIndex = openingTagStartIndex + tagName.Length + 2;
            string tagContents = line.Substring(openingTagEndIndex, closingTagStartIndex - openingTagEndIndex);

            switch (tagName)
            {
                case "rev": 
                    tagContents = Reverse(tagContents); 
                    break;
                case "toggle": 
                    tagContents = Toggle(tagContents); 
                    break;
                case "lower": 
                    tagContents = tagContents.ToLower(); 
                    break;
                case "upper": 
                    tagContents = tagContents.ToUpper(); 
                    break;
                case "del": 
                    tagContents = "";
                    break;
            }

            line = line.Remove(openingTagStartIndex, closingTagEndIndex - openingTagStartIndex + 1);
            line = line.Insert(openingTagStartIndex, tagContents);

            closingTagStartIndex = line.IndexOf("</");
        }

        Console.WriteLine(line);
    }

    private static string Toggle(string tagContents)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char ch in tagContents)
        {
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    sb.Append(Char.ToLower(ch));
                }
                else
                {
                    sb.Append(Char.ToUpper(ch));
                }
            }
            else
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }

    private static string Reverse(string tagContents)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = tagContents.Length - 1; i >= 0; i--)
        {
            if (tagContents[i] != '\r')
            {
                sb.Append(tagContents[i]);
            }
        }

        return sb.ToString();
    }
}
