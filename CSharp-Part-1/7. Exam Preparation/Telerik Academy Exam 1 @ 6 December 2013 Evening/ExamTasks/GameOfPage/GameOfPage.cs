using System;

namespace GameOfPage
{
    class GameOfPage
    {
        static float cashPaid = 0F;
        static void Main(string[] args)
        {
            char[,] inputArray = new char[18, 18];
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    inputArray[i, j] = '0';
                }
            }
            for (int i = 1; i < 17; i++)
            {
                for (int j = 1; j < 17; j++)
                {
                    inputArray[i, j] = (char)Console.Read();
                }
                Console.ReadLine();
            }
            string inputStr;
            while (parseCommand(inputArray, inputStr = Console.ReadLine())) ;
        }
        static void clearCookie(char[,] inputArray, int row, int col)
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    inputArray[i, j] = '0';
                }
            }
        }
        private static string checkCookie(char[,] inputArray, int row, int col)
        {
            bool isCookie = true;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
		        {
                    if (inputArray[i, j] == '0')
                    {
                        isCookie = false;
                    }
		        }
            }
            if (isCookie)
            {
                return "cookie";
            }
            else
            {
                bool adjacentBits = false;
                bool nearBits = false;
                if (inputArray[row, col - 1] == '1'|| inputArray[row, col + 1] == '1')
                {
                    adjacentBits = true;
                }
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (inputArray[row - 1, col] == '1' || inputArray[row + 1, col] == '1')
                    {
                        nearBits = true;
                    }
                }
                if (adjacentBits == true || nearBits == true)
                {
                    return "broken cookie";
                }
                else if (inputArray[row, col] == '1')
                {
                    return "cookie crumb";
                }
                else
                {
                    return "smile";
                }
            }
        }
        private static bool parseCommand(char[,] inputArray, string inputStr)
        {
            bool isAcceptable = false;
            int row = 0;
            int col = 0;
            string res;
            switch (inputStr)
            {
                case "what is":
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());
                    res = checkCookie(inputArray, row + 1, col + 1);
                    Console.WriteLine(res);
                    isAcceptable = true;
                    break;
                case "buy":
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());
                    res = checkCookie(inputArray, row + 1, col + 1);
                    switch (res)
                    {
                        case "cookie":
                            cashPaid += 1.79F;
                            clearCookie(inputArray, row + 1, col + 1);
                            break;
                        case "broken cookie":
                        case "cookie crumb":
                            Console.WriteLine("page");
                            break;
                        default: 
                            Console.WriteLine("smile");
                            break;
                    }
                    isAcceptable = true;
                    break;
                case "paypal":
                    Console.WriteLine("{0:F2}", cashPaid);
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