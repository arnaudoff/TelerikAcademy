/*
 * Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the 
 * classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
 * The card faces should start from 2 to A.
 * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement. 
 */

using System;

class PrintDeckOfCards
{
    static void Main()
    {
        int[] numericCards = {2, 3, 4, 5, 6, 7, 8, 9, 10};
        char[] alphaCards = { 'J', 'Q', 'K', 'A' };

        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", numericCards[i]);
        }
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", alphaCards[i]);
        }
    }
}