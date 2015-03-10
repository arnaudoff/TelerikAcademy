using System;
using System.Text;

namespace MobilePhone
{
    public class Call
    {
        private int duration;

        public Call(DateTime date, string dialledNumber, int duration)
        {
            this.Date = date;
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }

        public DateTime Date { get; set; }

        public string DialledNumber { get; set; }

        public int Duration
        {
            get 
            { 
                return this.duration; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The duration of the call cannot be a negative value.");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("[{0:dd.MM.yyyy HH:mm:ss}] Called {1} for {2} seconds.", this.Date, this.DialledNumber, this.Duration));

            return sb.ToString();
        }
    }
}
