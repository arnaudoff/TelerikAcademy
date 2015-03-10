namespace MobilePhone
{
    using System;
    using System.Text;

    public class Battery
    {
        private string model;
        private uint? hoursIdle;
        private uint? hoursTalk;

        public Battery(Type batteryType)
        {
            this.BatteryType = batteryType;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }
        public Battery(Type batteryType, uint? hoursIdle, uint? hoursTalk)
        {
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;

        }

        // Not quite sure whether this is the right place for the enum.
        public enum Type
        {
            Li_Ion,
            NiMH,
            NiCd
        }

        public Type BatteryType { get; set; }

        public string Model
        {
            get 
            { 
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery model cannot be emtpy.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public uint? HoursTalk
        {
            get 
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talk hours cannot have a negative value.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public uint? HoursIdle
        {
            get 
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours cannot have a negative value.");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.BatteryType);

            if (this.HoursIdle != null)
            {
                sb.Append(" - ");
                sb.Append(this.HoursIdle);
                sb.Append(" hour(s) idle");
            }
            if (this.HoursTalk != null)
            {
                if (this.HoursIdle != null)
                {
                    sb.Append(", ");
                }
                sb.Append(this.HoursTalk);
                sb.Append(" hour(s) of talking");
            }

            return sb.ToString();
        }
    }
}
