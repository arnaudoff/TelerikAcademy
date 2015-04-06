namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public string Model
        {
            get 
            {
                return this.model;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Furniture model cannot be null.");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Furniture model cannot be less than 3 symbols.");
                }

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Furniture price cannot be less or equal to 0.00$.");
                }

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Furniture height cannot be less or equal to 0.00 m.");
                }

                this.height = value;
            }
        }

        protected MaterialType MaterialType { get; set; }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
