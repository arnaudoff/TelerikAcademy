namespace Methods
{
    using System;

    public static class MathUtils
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid triangle specified: Side length should be a positive number.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException(string.Format("Invalid triangle specified: The triangle {0} {1} {2} does not exist.", sideA, sideB, sideC));
            }

            // This is Heron's formula (https://en.wikipedia.org/wiki/Heron%27s_formula)
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        public static double CalculateDistanceBetweenTwoPoints(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double productAfterSubstractionX = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            double productAfterSubstractionY = (secondPointY - firstPointY) * (secondPointY - firstPointY);
            double distance = Math.Sqrt(productAfterSubstractionX + productAfterSubstractionY);
            return distance;
        }

        public static LineType GetLineType(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            if (firstPointX == secondPointX)
            {
                return LineType.Vertical;
            }
            else if (firstPointY == secondPointY)
            {
                return LineType.Horizontal;
            }
            else
            {
                return LineType.Undefined;
            }
        }
    }
}
