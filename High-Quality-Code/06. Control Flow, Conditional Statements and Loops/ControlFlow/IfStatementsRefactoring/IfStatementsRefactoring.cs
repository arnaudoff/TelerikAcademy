namespace IfStatementsRefactoring
{
    using System;
    using Cooking.Ingredients.Vegetables;

    public class IfStatementsRefactoring
    {
        public static void Main()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                bool notPeeled = !potato.IsPeeled;
                bool notRotten = !potato.IsRotten;

                if (notPeeled && notRotten)
                {
                    potato.Cook();
                }
            }

            const int MinX = 13;
            const int MaxX = 37;
            const int MinY = 13;
            const int MaxY = 37;

            int x = 25;
            int y = 25;

            bool shouldVisitCell = true;

            if (shouldVisitCell && IsInRange(x, MinX, MaxX) && IsInRange(y, MinY, MaxY))
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
            Console.WriteLine("VisitCell() called.");
        }

        public static bool IsInRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
