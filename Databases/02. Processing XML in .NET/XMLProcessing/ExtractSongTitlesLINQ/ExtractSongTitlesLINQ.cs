namespace ExtractSongTitlesLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractSongTitlesLINQ
    {
        private const string XmlFilePath = "../../catalog.xml";

        public static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load(XmlFilePath);

            var songTitles = xmlDoc.Descendants("song")
                .Select(x => x.Element("title").Value)
                .ToList();

            foreach (var title in songTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
