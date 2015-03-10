namespace MobilePhone
{
    using System;

    class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        private Display display;
        private Battery battery;

        public GSM(string model, string manufacturer, float price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
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

        public float Price
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

        public Battery Battery { get; set; }

        public Display Display { get; set; }
    }
}
