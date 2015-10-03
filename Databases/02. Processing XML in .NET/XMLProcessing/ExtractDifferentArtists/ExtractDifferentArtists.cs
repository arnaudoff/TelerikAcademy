namespace ExtractDifferentArtists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    public class ExtractDifferentArtists
    {
        private const string XmlFilePath = "../../catalog.xml";

        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            Dictionary<string, int> uniqueCatalogArtists = new Dictionary<string, int>();

            XmlNode catalog = doc.DocumentElement;
            foreach (XmlNode album in catalog.ChildNodes)
            {
                string currentArtist = album.ChildNodes[1].InnerText;
                if (uniqueCatalogArtists.ContainsKey(currentArtist))
                {
                    uniqueCatalogArtists[currentArtist] = ++uniqueCatalogArtists[currentArtist];
                }
                else
                {
                    uniqueCatalogArtists.Add(currentArtist, 1);
                }
            }

            foreach (KeyValuePair<string, int> kvp in uniqueCatalogArtists)
            {
                Console.WriteLine("{0} => {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
