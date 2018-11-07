namespace MobiNews.Core.Definitions
{
    public interface IUrlDefinition
    {
        void Process();
        PublishingXml GetPublishingStories();
        PublishingXml GetPublishingStories(string xmlFeedUri);
    }
}
