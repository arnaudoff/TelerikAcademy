namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public abstract class Product : IProduct
    {
        private const byte MinNameLength = 3;
        private const byte MaxNameLength = 10;
        private const byte MinBrandLength = 2;
        private const byte MaxBrandLength = 10;

        private string name;
        private string brand;

        protected Product()
        {

        }

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", MinNameLength, MaxNameLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
                Validator.CheckIfStringLengthIsValid(value, MaxBrandLength, MinBrandLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", MinBrandLength, MaxBrandLength));

                this.brand = value;
            }
        }

        public virtual decimal Price { get; set; }

        public GenderType Gender { get; protected set; }

        public virtual string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine();
            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender.ToString()));

            return result.ToString();
        }
    }
}
