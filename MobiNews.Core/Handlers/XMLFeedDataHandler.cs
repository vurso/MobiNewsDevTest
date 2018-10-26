using MockXmlFeedService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MobiNews.Core.Handlers
{
    public class XMLFeedDataHandler : XmlHandlerBase, IXMLFeedDataHandler
    {
        private PublishingXml publishingXml;
        private IXmlFeedService _xmlFeedService;

        public XMLFeedDataHandler(IXmlFeedService xmlFeedService)
        {
            _xmlFeedService = xmlFeedService;
        }

        public PublishingXml GetPublishingStories()
        {
            var xmlFeedUri = ConfigurationManager.AppSettings.Get(XMLFEEDURIKEY);

            if (!string.IsNullOrEmpty(xmlFeedUri))
            {
                if (!Uri.IsWellFormedUriString(xmlFeedUri, UriKind.RelativeOrAbsolute))
                {
                    // uri doesn't look valid
                    // log this
                    return publishingXml;
                }

                ProcessXmlFeed(xmlFeedUri);
            }

            return publishingXml;
        }

        public PublishingXml GetPublishingStories(string xmlFeedUri)
        {
            if(!string.IsNullOrEmpty(xmlFeedUri))
            {
                ProcessXmlFeed(xmlFeedUri);
            }

            return publishingXml;
        }

        private void ProcessXmlFeed(string xmlFeedUri)
        {
            // in a real world scenario this code would be replaced by the method(s)
            // using WebRequest to get a response from the provided Uri path
            var xmlFeedData = _xmlFeedService.GetXmlFeed();

            var xmlSerializer = new XmlSerializer(typeof(PublishingXml));
            using (var nodeReader = new XmlNodeReader(xmlFeedData))
            {
                publishingXml = (PublishingXml)xmlSerializer.Deserialize(nodeReader);
            }
        }
    }
}