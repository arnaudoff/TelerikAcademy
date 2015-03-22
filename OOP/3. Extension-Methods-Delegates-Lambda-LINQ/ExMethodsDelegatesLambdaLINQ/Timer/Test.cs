namespace Timer
{
    using System;
    using System.Threading;

    public class Test
    {
        static void Main()
        {
            int tickCount = 10;
            int interval = 1;
            Timer testTimer = new Timer(tickCount, interval, delegate() { TestMethod(tickCount, interval); });
            Thread delegateThread = new Thread(new ThreadStart(testTimer.CallDelegate));
            delegateThread.Start();
        }

        private static void TestMethod(int tickCount, int interval)
        {
            Console.WriteLine("TestMethod() called with tick count = {0} and interval = {1}", tickCount, interval);
        }
    }
}
