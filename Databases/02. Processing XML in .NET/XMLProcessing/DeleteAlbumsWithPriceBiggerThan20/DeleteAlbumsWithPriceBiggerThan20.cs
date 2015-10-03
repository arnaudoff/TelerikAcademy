namespace DeleteAlbumsWithPriceBiggerThan20
{
    using System;
    using System.Xml;

    public class DeleteAlbumsWithPriceBiggerThan20
    {
        public const int LimitPriceAmount = 20;
        private const string XmlFilePath = "../../catalog.xml";

        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            Console.WriteLine("---------- Before deletion ----------");
            Console.WriteLine(doc.Beautify());

            XmlNodeList allPrices = doc.SelectNodes("//album/price");

            foreach (XmlNode node in allPrices)
            {
                int currentPrice = int.Parse(node.InnerText);

                if (currentPrice > LimitPriceAmount)
                {
                    node.ParentNode.ParentNode.RemoveChild(node.ParentNode);
                }
            }

            Console.WriteLine("---------- After deletion ----------");
            Console.WriteLine(doc.Beautify());
            
            // Call doc.Save() to override with the XmlDocument after deletion
        }
    }
}
