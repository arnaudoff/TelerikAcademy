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
            while (parseCommand(inputArray, inputStr = Console.ReadLine()));
        }

        /*
         * Return values:
         * Complete cookie -> 1
         * Broken cookie -> 2
         * Cookie crumb -> 3
         * Nothing -> -1
         */
        private static int checkCookie(string[] inputArray, int row, int col)
        {
            // TODO: implement checkCookie
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
