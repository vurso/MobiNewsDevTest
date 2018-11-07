using MobiNews.Core.Extensions;
using MockXmlFeedService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Definitions
{
    public class UrlDefinition : DefintionBase, IUrlDefinition
    {
        private PublishingXml publishingXml;
        private IXmlFeedService _xmlFeedService;
        private readonly string XMLFEEDURIKEY = "XmlFeedUriKey";

        public UrlDefinition(IXmlFeedService xmlFeedService)
        {
            _xmlFeedService = xmlFeedService;
        }

        public UrlDefinition()
        {
            // default ctor
        }

        public void Process()
        {
            GetPublishingStories();
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
            if (!string.IsNullOrEmpty(xmlFeedUri))
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

            publishingXml = xmlFeedData.Deserialize<PublishingXml>();
        }
    }
}
