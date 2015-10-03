namespace TraverseDirectoryXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class TraverseDirectoryXDocument
    {
        private const string XmlFilePath = "../../dirinfo.xml";
        private const string DirectoryToTraverse = "../../";

        public static void Main(string[] args)
        {
            XElement directoryTree = TraverseChildrenDirectories(DirectoryToTraverse);
            XDocument dirInfoDoc = new XDocument(directoryTree);
            dirInfoDoc.Save(XmlFilePath);

            Console.WriteLine("Created XML directory tree of path '{0}'. Location: {1}", DirectoryToTraverse, XmlFilePath);
        }

        private static XElement TraverseChildrenDirectories(string rootDirPath)
        {
            XElement dirElement = new XElement("dir", new XAttribute("path", rootDirPath));

            try
            {
                foreach (string directory in Directory.GetDirectories(rootDirPath))
                {
                    dirElement.Add(TraverseChildrenDirectories(directory));
                }

                foreach (string file in Directory.GetFiles(rootDirPath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    XElement fileElement = BuildFileElement(fileInfo.Name, fileInfo.Length, fileInfo.CreationTime);
                    dirElement.Add(fileElement);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return dirElement;
        }

        private static XElement BuildFileElement(string fileName, long fileLength, DateTime fileCreationTime)
        {
            return new XElement(
                "file",
                new XAttribute("name", fileName),
                new XAttribute("length", fileLength),
                new XAttribute("createdOn", fileCreationTime));
        }
    }
}
