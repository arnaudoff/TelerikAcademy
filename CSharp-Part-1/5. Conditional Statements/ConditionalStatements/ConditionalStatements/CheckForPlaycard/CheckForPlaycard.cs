/*
 * Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
 * and prints “yes” if it is a valid card sign or “no” otherwise.
 */

using System;

class CheckForPlaycard
{
    static void Main()
    {
        Console.WriteLine("Enter card sign: ");
        string inputStr = Console.ReadLine();
        int number;

        bool result = Int32.TryParse(inputStr, out number);
        if (result)
        {
           if (number >= 2 && number <= 10)
           {
               Console.WriteLine("Yes.");
           }
           else
           {
               Console.WriteLine("No.");
           }
        }
        else
        {
           if (inputStr[0] == 'J' || inputStr[0] == 'Q' || inputStr[0] == 'K' || inputStr[0] == 'A')
           {
               Console.WriteLine("Yes.");
           }
           else
           {
               Console.WriteLine("No.");
           }
        }
    }
}
