namespace PerformanceComparer
{
    using System;
    using System.Diagnostics;

    public static class ExecutionUtils
    {
        public static TimeSpan CalculateTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            action();
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
