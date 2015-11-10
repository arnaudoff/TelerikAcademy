namespace Products
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Wintellect.PowerCollections;

    public class Startup
    {
        private const int ProductsCount = 500000;
        private const int PriceSearchCount = 10000;

        public static void Main()
        {
            var products = new OrderedBag<Product>();

            Console.WriteLine("Populating products");
            for (int i = 0; i < ProductsCount; i++)
            {
                products.Add(new Product(i.ToString(), i * 3.14));

                if (i % 5000 == 0)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine("Running search on products");
            for (int i = 0; i < PriceSearchCount; i++)
            {
                var minPriceProduct = new Product("foo", i);
                var maxPriceProduct = new Product("bar", i + 42);

                var result = products.Range(minPriceProduct, true, maxPriceProduct, true).Take(20).ToList();
                Console.WriteLine("Reached search count {0}:", i);
                result.ForEach(x => Console.WriteLine(x));
            }
        }
    }
}
