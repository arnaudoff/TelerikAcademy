namespace MobilePhone
{
    using System;

    class Battery
    {
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        private BatteryType batteryType;

        public enum BatteryType
        {
            Li_Ion,
            NiMH,
            NiCd
        }

        public BatteryType BatteryType { get; set; }
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

        public uint HoursTalk
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

        public uint HoursIdle
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
    }
}
