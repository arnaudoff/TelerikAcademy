namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Product, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
                    : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; private set; }

        public override decimal Price
        {
            get
            {
                return this.Milliliters * base.Price;
            }
            set
            {
                base.Price = value;
            }
        }

        public UsageType Usage { get; private set; }

        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            result.Append(string.Format("  * Usage: {0}", this.Usage.ToString()));
            return base.Print() + result.ToString();
        }
    }
}
