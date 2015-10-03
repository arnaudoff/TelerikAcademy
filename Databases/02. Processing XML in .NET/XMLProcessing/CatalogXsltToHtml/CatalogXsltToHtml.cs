namespace CatalogXsltToHtml
{
    using System;
    using System.Xml.Xsl;

    public class CatalogXsltToHtml
    {
        private const string CatalogXmlFilePath = "../../catalog.xml";
        private const string CatalogXsltFilePath = "../../catalog.xsl";
        private const string CatalogHtmlFilePath = "../../catalog.html";

        public static void Main()
        {
            try
            {
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(CatalogXsltFilePath);
                xslt.Transform(CatalogXmlFilePath, CatalogHtmlFilePath);
                Console.WriteLine("Transformation completed. Location: {0}", CatalogHtmlFilePath);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}