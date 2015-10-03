namespace CreateXmlFromTextFile
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    public class CreateXmlFromTextFile
    {
        private const string TextFilePath = "../../person.txt";
        private const string XmlFilePath = "../../people.xml";

        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(TextFilePath);

            XElement books =
                new XElement(
                    "people",
                    new XElement(
                        "person",
                        new XElement("name", lines[0]),
                        new XElement("address", lines[1]),
                        new XElement("phoneNumber", lines[2])));

            books.Save(XmlFilePath);

            Console.WriteLine("You may now open the generated XML file. Location: {0}", XmlFilePath);
        }
    }
}
