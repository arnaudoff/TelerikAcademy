// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        /*
         * Since the distance is hardcoded, we are going to store the bits in the interval 3-5 (the least significant bit side) and 24-26 (the most significant bit side) 
         * by using hexadecimal values that represent the binary masks instead of shifting. Then, another mask is created that clears 24-26
         * and 3-5. Finally, shift the already extracted sides (lsbSide and msbSide) by 21 positions respectively left and right and exchange the bits by OR-ing with the masks.
         */

        int lsbSide = inputNumber & 0x00000038;
        int msbSide = inputNumber & 0x07000000;
        inputNumber &= ~0x07000038;
        inputNumber |= lsbSide << 21;
        inputNumber |= msbSide >> 21;
        Console.WriteLine(inputNumber);

    }
}
