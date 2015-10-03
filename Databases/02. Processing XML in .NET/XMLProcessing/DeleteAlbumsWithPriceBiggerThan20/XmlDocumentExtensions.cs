namespace DeleteAlbumsWithPriceBiggerThan20
{
    using System.Text;
    using System.Xml;

    public static class XmlDocumentExtensions
    {
        public static string Beautify(this XmlDocument doc)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };

            StringBuilder sb = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                doc.Save(writer);
            }

            return sb.ToString();
        }
    }
}
