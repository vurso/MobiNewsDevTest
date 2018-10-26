using System.Xml;

namespace MockXmlFeedService
{
    public interface IXmlFeedService
    {
        XmlDocument GetXmlFeed();
    }
}