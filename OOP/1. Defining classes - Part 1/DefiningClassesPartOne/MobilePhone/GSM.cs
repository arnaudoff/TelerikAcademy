namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static GSM iPhone4S = new GSM("iPhone 4s", "Apple", 10000, "Mrs. Kifla", new Battery(Battery.Type.NiMH), new Display(3.5f, 16000000));

        private string model;
        private string manufacturer;
        private float? price;
        private string owner;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S
        {
            get 
            { 
                return iPhone4S;
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> CallHistory 
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

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
                    throw new ArgumentException("Model cannot be empty.");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be empty.");
                }

                this.manufacturer = value;
            }
        }

        public float? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less than zero.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner cannot be empty.");
                }

                this.owner = value;
            }
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public float CalculateTotalCallsPrices(float pricePerMinute)
        {
            float price = 0;

            foreach (var call in this.CallHistory)
            {
                price += call.Duration * pricePerMinute;
            }
    
            return price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Model: {0}", this.Model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            if (this.Price != null)
            {
                sb.AppendLine(string.Format("Price: {0}", this.Price));
            }
            if (this.Owner != null)
            {
                sb.AppendLine(string.Format("Owner: {0}", this.Owner));
            }
            // These use the custom overrides within Display and Battery
            if (this.Display != null)
            {
                sb.AppendLine(string.Format("Display: {0}", this.Display.ToString()));
            }
            if (this.Battery != null)
            {
                sb.AppendLine(string.Format("Battery type: {0}", this.Battery.ToString()));
            }
            return sb.ToString();
        }
    }
}
