using Form_26_1_.InterFaces;
using Form_26_1_.models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Form_26_1_.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }
        public void Add(Parking parking)
        {
            var xRoot = _document.DocumentElement;
            XmlElement parkingElem = _document.CreateElement("mark");

            XmlAttribute markAttribute = _document.CreateAttribute("mark");
            XmlText markText = _document.CreateTextNode(parking.Mark);
            markAttribute.AppendChild(markText);

            XmlElement yearElem = _document.CreateElement("year");
            XmlText yearInnerText = _document.CreateTextNode(parking.Year.ToString());
            yearElem.AppendChild(yearElem);
            parkingElem.AppendChild(yearElem);

            XmlElement dateElem = _document.CreateElement("Date");
            XmlText dateInnerText = _document.CreateTextNode(parking.Date.ToString());
            dateElem.AppendChild(dateInnerText);
            parkingElem.AppendChild(dateElem);

            xRoot.AppendChild(parkingElem);
            _document.Save(_xmlFilePath);
        }
        public void Delete(string mark)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeMark = xNode.Attributes.GetNamedItem("mark");
                    try
                    {
                        var atrributeMarkText = attributeMark?.InnerText;
                        if (atrributeMarkText.Equals(mark))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeMark));
                    }
                }
            }
        }
        public Parking FindBy(string mark)
        {
            Parking parking = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xmlNode in xRoot)
            {
                parking = GetParking(xmlNode);
                if (parking.Mark.Equals(mark))
                {
                    return parking;
                }
            }
            return parking;
        }
        public List<Parking> GetAll()
        {
            List<Parking> parkingg = new List<Parking>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                var parking = GetParking(node);
                parkingg.Add(parking);
            }
            return parkingg;
        }
        public void Load(string xmlDocPath)
        {
            _xmlFilePath = xmlDocPath;
            _document.Load(xmlDocPath);
        }
        private Parking GetParking(XmlNode node)
        {
            var parking = new Parking();
            if (node.Attributes.Count > 0)
            {
                var attributeMark = node.Attributes.GetNamedItem("mark");
                parking.Mark = attributeMark?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("year"))
                    {
                        parking.Year = (childNode.InnerText);
                    }
                    if (childNode.Name.Equals("date"))
                    {
                        parking.Date = int.Parse(childNode.InnerText);
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return parking;
        }
    }
}
