using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MockXmlFeedService
{
    public class XmlFeedProvider : IXmlFeedProvider
    {

        public XmlDocument GenerateMockXmlFeedData()
        {
            var sb = new StringBuilder();
            var xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Encoding = Encoding.UTF8;
            var xmlWriter = XmlWriter.Create(sb);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("publishing");
            xmlWriter.WriteElementString("publishingid", "23");
            xmlWriter.WriteStartElement("stories");
            xmlWriter.WriteStartElement("story");
            xmlWriter.WriteElementString("id", "2654");
            xmlWriter.WriteElementString("title", "The PM moves out of number 10");
            xmlWriter.WriteElementString("newstoryText", "he Mayor of London has forced the PM out of number 10 claiming \"the rent hasn't been paid in years\"");
            xmlWriter.WriteElementString("image", "https://picsum.photos/200/300/?image=197");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("story");
            xmlWriter.WriteElementString("id", "2655");
            xmlWriter.WriteElementString("title", "North and South Korea at Peace");
            xmlWriter.WriteElementString("newstoryText", "The Supreme Leader has had a change of heart after stubbing his toe on a missile and realising it's probably better if we're all friends.");
            xmlWriter.WriteElementString("image", "https://picsum.photos/200/300/?image=198");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();

            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(sb.ToString());

            // for testing purposes only
            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter))
            {
                xmlDocument.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                var testXmlString = stringWriter.GetStringBuilder().ToString();
            }

            return xmlDocument;
        }
    }
}
