namespace PerformanceComparer
{
    using System;

    public static class AdvancedMath
    {
        public static TimeSpan Sqrt(float number)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Sqrt(number);
            });
        }

        public static TimeSpan Sqrt(double number)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Sqrt(number);
            });
        }

        public static TimeSpan Sqrt(decimal number)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Sqrt((double)number);
            });
        }

        public static TimeSpan Log(float number)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Sqrt(number);
            });
        }

        public static TimeSpan Log(double number)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Log(number);
            });
        }

        public static TimeSpan Log(decimal number)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Log((double)number);
            });
        }

        public static TimeSpan Sin(float angle)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Sin(angle);
            });
        }

        public static TimeSpan Sin(double angle)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Sin(angle);
            });
        }

        public static TimeSpan Sin(decimal angle) 
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                Math.Sin((double)angle);
            });
        }
    }
}
