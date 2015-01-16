/*
 * The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter earth weight: ");
        float earthWeight = float.Parse(Console.ReadLine());
        float moonWeight = 0.17F * earthWeight;
        Console.WriteLine(moonWeight);
    }
}
