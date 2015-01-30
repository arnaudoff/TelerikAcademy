using System;

namespace GameOfPage
{
    class GameOfPage
    {
        static float cashPaid = 0F;
        static void Main(string[] args)
        {
            string[] inputArray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                inputArray[i] = Console.ReadLine();
            }
            string inputStr;
            while (parseCommand(inputArray, inputStr = Console.ReadLine())) ;
        }

        /*
         * Return values:
         * Complete cookie -> 1
         * Broken cookie -> 2
         * Cookie crumb -> 3
         * Nothing -> 0
         */
    
        private static int checkCookie(string[] inputArray, int row, int col)
        {
            bool isBroken = false;
            bool isCookie = true;
            if (col == 0 && row == 0)
            {
                if (inputArray[0][1] == 1 || inputArray[1][1] == 1 || inputArray[1][0] == 1)
                {
                    isBroken = true;
                }
            }
            else if (col == 0 && row != 0)
            {
                if (inputArray[row - 1][0] == 1 || inputArray[row + 1][0] == 1 || inputArray[row - 1][1] == 1 || inputArray[row + 1][1] == 1 || inputArray[row][1] == 1)
                {
                    isBroken = true;
                }
            }
            else if (col != 0 && row == 0)
            {
                if (inputArray[0][col + 1] == 1 || inputArray[0][col - 1] == 1 || inputArray[1][col + 1] == 1 || inputArray[1][col - 1] == 1 || inputArray[1][col] == 1)
                {
                    isBroken = true;
                }
            }
            else if (col == 15 && row == 15)
            {
                if (inputArray[15][14] == 1 || inputArray[14][14] == 1 || inputArray[14][15] == 1)
                {
                    isBroken = true;
                }
            }
            else if (col == 15 && row != 15)
            {
                if (inputArray[row][14] == 1 || inputArray[row - 1][14] == 1 || inputArray[row + 1][14] == 1 || inputArray[row - 1][15] == 1 || inputArray[row + 1][15] == 1)
                {
                    isBroken = true;
                }
            }
            else if (col != 15 && row == 15)
            {
                if (inputArray[15][col - 1] == 1 || inputArray[15][col + 1] == 1 || inputArray[14][col] == 1 || inputArray[14][col - 1] == 1 || inputArray[14][col + 1] == 1)
                {
                    isBroken = true;
                }
            }
            else
            {
                // Check with ifs... Again.
            }
            if (isBroken == false && isCookie == false)
            {
                // Cookie crumb.
                if (inputArray[row][col] == 1)
                {
                    return 3;
                }
                // Nothing
                else
                {
                    return 0;
                }
            }
            if (isBroken == true)
            {
                return 2;
            }
            if (isCookie)
            {
                return 1;
            }
            return -1;
        }
        private static bool parseCommand(string[] inputArray, string inputStr)
        {
            bool isAcceptable = false;
            int row = 0;
            int col = 0;
            int res;
            switch (inputStr)
            {
                case "what is":
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());
                    res = checkCookie(inputArray, row, col);
                    // ....
                    isAcceptable = true;
                    break;
                case "buy":
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());
                    res = checkCookie(inputArray, row, col);
                    // increment cash by 1.79$              
                    isAcceptable = true;
                    break;
                case "paypal":
                    Console.WriteLine(cashPaid);
                    isAcceptable = false;
                    break;
            }
            if (isAcceptable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}