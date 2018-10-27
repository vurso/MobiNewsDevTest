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
            var xw = XmlWriter.Create(sb);

            xw.WriteStartDocument();
            xw.WriteStartElement("publishing");
            xw.WriteElementString("publishingid", "23");
            xw.WriteStartElement("stories");
            xw.WriteStartElement("story");
            xw.WriteElementString("id", "2654");
            xw.WriteElementString("title", "The PM moves out of number 10");
            xw.WriteElementString("newstoryText", "he Mayor of London has forced the PM out of number 10 claiming \"the rent hasn't been paid in years\"");
            xw.WriteElementString("image", "https://picsum.photos/200/300/?image=197");
            xw.WriteEndElement();
            xw.WriteStartElement("story");
            xw.WriteElementString("id", "2655");
            xw.WriteElementString("title", "North and South Korea at Peace");
            xw.WriteElementString("newstoryText", "The Supreme Leader has had a change of heart after stubbing his toe on a missile and realising it's probably better if we're all friends.");
            xw.WriteElementString("image", "https://picsum.photos/200/300/?image=198");
            xw.WriteEndElement();
            xw.WriteEndElement();
            xw.WriteEndElement();
            xw.WriteEndDocument();
            xw.Flush();

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
