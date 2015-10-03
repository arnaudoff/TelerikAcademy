namespace ExtractPricesByTimePublishedXPath
{
    using System;
    using System.Xml;

    public class ExtractPricesByTimePublishedXPath
    {
        private const string XmlFilePath = "../../catalog.xml";

        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            int limitYear = DateTime.Now.Year - 5;
            XmlNodeList matchedPriceNodes = doc.SelectNodes(string.Format("/catalog/album[year<={0}]/price", limitYear));

            // Road Trippin’ Through Time's price is ignored as it was released in 2011.
            foreach (XmlNode priceNode in matchedPriceNodes)
            {
                Console.WriteLine(priceNode.InnerText);
            }
        }
    }
}
