// Using delegates write a class Timer that can execute certain method at each t seconds.

namespace Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {

        private int seconds;
        private int tickCount;
        public Timer(int tickCount, int interval, TimerDelegate timerDelegate)
        {
            this.TickCount = tickCount;
            this.Interval = interval;
            this.TimerDelegate = timerDelegate;
        }

        public int TickCount
        {
            get
            {
                return this.tickCount;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid tick count given.");
                }

                this.tickCount = value;
            }
        }

        public TimerDelegate TimerDelegate { get; set; }

        public int Interval
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid interval given.");
                }

                // Convert to milliseconds
                this.seconds = value * 1000;
            }
        }

        public void CallDelegate()
        {
            while (tickCount > 0)
            {
                Thread.Sleep((int)seconds);
                --tickCount;
                TimerDelegate();
            }
        }
    }
}
