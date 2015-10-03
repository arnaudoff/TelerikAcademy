namespace CatalogToAlbum
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    public class CatalogToAlbum
    {
        private const string CatalogXmlFilePath = "../../catalog.xml";
        private const string AlbumXmlFilePath = "../../album.xml";

        public static void Main(string[] args)
        {
            List<string> albums = new List<string>();
            List<string> artists = new List<string>();

            using (XmlReader reader = XmlReader.Create(CatalogXmlFilePath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.Name)
                        {
                            case "name":
                                albums.Add(reader.ReadElementString());
                                break;
                            case "artist":
                                artists.Add(reader.ReadElementString());
                                break;
                        }
                    }
                }
            }

            Encoding encoding = Encoding.GetEncoding("UTF-8");

            using (XmlTextWriter writer = new XmlTextWriter(AlbumXmlFilePath, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                
                writer.WriteStartElement("albums");
                for (int i = 0; i < albums.Count; i++)
                {
                    WriteAlbum(writer, albums[i], artists[i]);
                }
                
                writer.WriteEndDocument();
            }

            Console.WriteLine("Created XML file with albums. Location: " + AlbumXmlFilePath);
        }

        private static void WriteAlbum(XmlWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }
    }
}
