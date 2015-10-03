namespace ExtractPricesByTimePublishedLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractPricesByTimePublishedLINQ
    {
        private const string XmlFilePath = "../../catalog.xml";

        public static void Main(string[] args)
        {
            XDocument catalog = XDocument.Load(XmlFilePath);

            var matchedAlbums =
                from album in catalog.Descendants("album")
                where int.Parse(album.Element("year").Value) <= DateTime.Now.Year - 5
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            // Road Trippin’ Through Time's price is ignored as it was released in 2011.
            foreach (var album in matchedAlbums)
            {
                Console.WriteLine("{0} => {1}", album.Name, album.Price);
            }
        }
    }
}
