using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Handlers
{
    public interface IXMLFeedDataHandler
    {
        PublishingXml GetPublishingStories();
        PublishingXml GetPublishingStories(string xmlFeedUri);
    }
}
