namespace PerformanceComparer
{
    using System;

    public static class SimpleMath
    {
        /*
         * Casting is done before the call to CalculateTime so it doesn't interfere with the actual time it takes for the operation.
         * This could have been a lot simpler if .NET had an arithmetic interface which could be used as a generic constraint.
         */

        public static TimeSpan Add<T>(T firstNumber, T secondNumber)
        {
            dynamic a = firstNumber;
            dynamic b = secondNumber;

            return ExecutionUtils.CalculateTime(() =>
            {
                dynamic result = a + b;
            });
        }

        public static TimeSpan Substract<T>(T firstNumber, T secondNumber)
        {
            dynamic a = firstNumber;
            dynamic b = secondNumber;

            return ExecutionUtils.CalculateTime(() =>
            {
                dynamic result = a - b;
            });
        }

        public static TimeSpan Multiply<T>(T firstNumber, T secondNumber)
        {
            dynamic a = firstNumber;
            dynamic b = secondNumber;

            return ExecutionUtils.CalculateTime(() =>
            {
                dynamic result = a * b;
            });
        }

        public static TimeSpan Divide<T>(T firstNumber, T secondNumber)
        {
            dynamic a = firstNumber;
            dynamic b = secondNumber;

            return ExecutionUtils.CalculateTime(() =>
            {
                dynamic result = a / b;
            });
        }

        public static TimeSpan Increment<T>(T number)
        {
            dynamic a = number;

            return ExecutionUtils.CalculateTime(() =>
            {
                dynamic result = a++;
            });
        }
    }
}
