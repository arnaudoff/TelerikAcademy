namespace TraverseDirectoryXml
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class TraverseDirectoryXml
    {
        private const string XmlFilePath = "../../dirinfo.xml";
        private const string DirectoryToTraverse = "../../";

        public static void Main(string[] args)
        {
            Encoding encoding = Encoding.GetEncoding("UTF-8");

            using (XmlTextWriter writer = new XmlTextWriter(XmlFilePath, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", DirectoryToTraverse);

                TraverseChildrenDirectories(DirectoryToTraverse, writer);

                writer.WriteEndDocument();

                Console.WriteLine("Created XML directory tree of path '{0}'. Location: {1}", DirectoryToTraverse, XmlFilePath);
            }
        }

        private static void TraverseChildrenDirectories(string rootDirPath, XmlWriter writer)
        {
            try
            {
                foreach (string directory in Directory.GetDirectories(rootDirPath))
                {
                    writer.WriteStartElement("dir");
                    writer.WriteAttributeString("path", directory);

                    TraverseChildrenDirectories(directory, writer);

                    writer.WriteEndElement();
                }

                foreach (string file in Directory.GetFiles(rootDirPath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    WriteFile(writer, fileInfo.Name, fileInfo.Length, fileInfo.CreationTime);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void WriteFile(XmlWriter writer, string fileName, long fileLength, DateTime fileCreationTime)
        {
            writer.WriteStartElement("file");
            writer.WriteAttributeString("name", fileName);
            writer.WriteAttributeString("length", fileLength.ToString());
            writer.WriteAttributeString("createdOn", fileCreationTime.ToShortDateString());
            writer.WriteEndElement();
        }
    }
}
