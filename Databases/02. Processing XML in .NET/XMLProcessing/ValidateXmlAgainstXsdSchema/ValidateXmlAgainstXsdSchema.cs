namespace ValidateXmlAgainstXsdSchema
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class ValidateXmlAgainstXsdSchema
    {
        private const string ValidCatalogXmlFilePath = "../../catalog-valid.xml";
        private const string InvalidCatalogXmlFilePath = "../../catalog-invalid.xml";
        private const string CatalogXsdFilePath = "../../catalog.xsd";

        public static void Main(string[] args)
        {
            ValidateXmlFileAgainstSchemas(ValidCatalogXmlFilePath, new string[] { CatalogXsdFilePath });
            ValidateXmlFileAgainstSchemas(InvalidCatalogXmlFilePath, new string[] { CatalogXsdFilePath });
        }

        private static void ValidateXmlFileAgainstSchemas(string xmlFilePath, string[] schemasPaths)
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            foreach (string schemaPath in schemasPaths)
            {
                XmlTextReader reader = new XmlTextReader(schemaPath);
                schemaSet.Add(XmlSchema.Read(reader, SchemaValidationCallback));
            }

            XDocument xmlFile = XDocument.Load(xmlFilePath);

            bool errors = false;
            xmlFile.Validate(
                schemaSet,
                (o, e) =>
                {
                    Console.WriteLine("{0}", e.Message);
                    errors = true;
                });

            Console.WriteLine(
                "Catalog XML '{0}' {1} validated against schema '{2}'.",
                ValidCatalogXmlFilePath,
                errors ? "could NOT be" : "was successfully",
                CatalogXsdFilePath);
        }

        private static void SchemaValidationCallback(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
            }
            else if (args.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
            }

            Console.WriteLine(args.Message);
        }
    }
}
