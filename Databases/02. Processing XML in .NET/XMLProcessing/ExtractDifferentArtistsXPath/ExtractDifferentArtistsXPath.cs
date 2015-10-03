namespace ExtractDifferentArtistsXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ExtractDifferentArtistsXPath
    {
        private const string XmlFilePath = "../../catalog.xml";

        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            Dictionary<string, int> uniqueCatalogArtists = new Dictionary<string, int>();

            XmlNodeList artists = doc.SelectNodes("//album/artist");
            foreach (XmlNode node in artists)
            {
                string currentArtist = node.InnerText;

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
