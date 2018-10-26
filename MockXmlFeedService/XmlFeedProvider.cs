using System;
using System.Collections.Generic;
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
            xw.WriteEndElement();
            xw.WriteEndElement();

            xw.Flush();

            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(sb.ToString());
            return xmlDocument;
        }
    }
}
