namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;
        private const decimal ConvertedHeight = 0.10m;

        public ConvertibleChair(string model, Models.MaterialType materialType, decimal price, decimal height, int numberOfLegs)
                : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public bool IsConverted 
        {
            get
            {
                return this.isConverted;
            }
        }

        public override decimal Height
        {
            get
            {
                if (this.isConverted)
                {
                    return ConvertedHeight;
                }
                else
                {
                    return base.Height;
                }
            }
            protected set
            {
                base.Height = value;
            }
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
