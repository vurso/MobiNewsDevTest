using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Handlers
{
    public class XMLFeedDataHandler : XmlHandlerBase, IXMLFeedDataHandler
    {
        private PublishingXml publishingXml;

        public XMLFeedDataHandler()
        {
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

        void ProcessXmlFeed(string xmlFeedUri)
        {
            // in a real world scenario this code would be replaced by the 
            throw new NotImplementedException();
        }

        public PublishingXml GetPublishingStories(string xmlFeedUri)
        {
            throw new NotImplementedException();
        }

        //public Publishing GetXmlFeedData(string xmlfeedPath)
        //{
        //    var publishedStories = new Publishing();

        //    // use HttpRequest to call the URL
        //    // consume the xml data
        //    // inflate the entity
        //    // loop through the stories and add story to the Publishing collection

        //    return publishedStories;
        //}
    }
}
