namespace Cosmetics.Products
{
    using System.Linq;
    using System.Collections.Generic;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    internal class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> products;

        public ShoppingCart()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, product));
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, product));
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.products.Any(pr => pr.Name == product.Name);
        }

        public decimal TotalPrice()
        {
            return this.products.Sum(pr => pr.Price);
        }
    }
}
