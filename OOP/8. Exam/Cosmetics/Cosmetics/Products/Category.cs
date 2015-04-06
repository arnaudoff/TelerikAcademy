namespace Cosmetics.Products
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const byte MinNameLength = 2;
        private const byte MaxNameLength = 15;
        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.products = new List<IProduct>();
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinNameLength, MaxNameLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, cosmetics));
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, cosmetics));

            if (!this.products.Remove(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
        }

        public string Print()
        {
            var sortedProducts = products.OrderBy(pr => pr.Brand).ThenByDescending(pr => pr.Price);

            StringBuilder result = new StringBuilder();
            string productPluralModifier = this.products.Count == 1 ? "product" : "products";
            result.Append(string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, productPluralModifier));
            foreach (var product in sortedProducts)
            {
                result.Append(product.Print());
            }
            return result.ToString();
        }
    }
}
