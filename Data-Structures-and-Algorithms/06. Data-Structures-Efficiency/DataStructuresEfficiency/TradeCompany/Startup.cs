namespace TradeCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Startup
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static readonly Random Random = new Random();

        public static void Main()
        {
            var articles = new OrderedMultiDictionary<double, Article>(false);

            for (int i = 0; i < 1000; i++)
            {
                double price = GetRandomNumber(1.5D, 20.5D);
                articles.Add(price, new Article(GetRandomString((int)GetRandomNumber(8, 12)), i.ToString(), GetRandomString(4), price));
            }

            var result = GetArticlesByPriceRange(articles, 5.5D, 12.5D);

            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Value);
            }
        }

        private static OrderedMultiDictionary<double, Article>.View GetArticlesByPriceRange(
            OrderedMultiDictionary<double, Article> articles,
            double fromPrice,
            double toPrice)
        {
            return articles.Range(fromPrice, true, toPrice, true);
        }

        private static double GetRandomNumber(double minimum, double maximum)
        {
            return (Random.NextDouble() * (maximum - minimum)) + minimum;
        }

        private static string GetRandomString(int length)
        {
            return new string(Enumerable.Repeat(Chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
