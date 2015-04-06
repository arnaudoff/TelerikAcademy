namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}", this.NumberOfLegs);
        }
    }
}
