namespace CatalogToAlbumXDocument
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class CatalogToAlbumXDocument
    {
        private const string CatalogXmlFilePath = "../../catalog.xml";
        private const string AlbumXmlFilePath = "../../album.xml";

        public static void Main(string[] args)
        {
            XDocument catalog = XDocument.Load(CatalogXmlFilePath);

            var albums = catalog.Descendants("album")
                .Select(album => new
                {
                    Name = album.Element("name").Value,
                    Artist = album.Element("artist").Value
                });

            XDocument albumDoc = new XDocument(
                new XElement(
                    "albums",
                    from album in albums
                    select new XElement(
                        "album",
                            new XElement("name", album.Name),
                            new XElement("artist", album.Artist))));

            albumDoc.Save(AlbumXmlFilePath);

            Console.WriteLine("Created XML file with albums. Location: " + AlbumXmlFilePath);
        }
    }
}
