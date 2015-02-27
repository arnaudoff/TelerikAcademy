/*
 * Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
 * Find in Google how to download files in C#.
 * Be sure to catch all exceptions and to free any used resources in the finally block.
 */

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        try
        {
            string fileName = "coding.jpg";
            WebClient webCilend = new WebClient();
            webCilend.DownloadFile("http://nc8digital.com.br/wp-content/uploads/2012/11/code-i-have-no-idea1-1024x358.jpg", fileName);
            Console.WriteLine("Saved: {0} -> {1}.", fileName, Directory.GetCurrentDirectory());
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
