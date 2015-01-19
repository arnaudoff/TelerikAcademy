/* 
 * Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
 * Do the above in two different ways - with and without using quoted strings.
 */

using System;

class QuotesInStrings
{
    static void Main()
    {  
        string escapedString = "The \"use\" of quotations causes difficulties.";
        string varbatimString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(escapedString);
        Console.WriteLine(varbatimString);
    }
}
