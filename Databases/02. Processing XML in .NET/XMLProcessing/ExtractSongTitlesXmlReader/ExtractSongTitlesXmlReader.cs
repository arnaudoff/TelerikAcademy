namespace ExtractSongTitlesXmlReader
{
    using System;
    using System.Xml;

    public class ExtractSongTitlesXmlReader
    {
        private const string XmlFilePath = "../../catalog.xml";

        public static void Main()
        {
            using (XmlReader reader = XmlReader.Create(XmlFilePath))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
